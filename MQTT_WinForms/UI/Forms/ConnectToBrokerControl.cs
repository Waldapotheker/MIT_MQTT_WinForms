using System.Collections.Concurrent;
using System.Diagnostics;
using MQTT_WinForms.BASE;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Enums;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.MQTT;
using MQTT_WinForms.UI.Helpers;
using MQTTnet.Protocol;
using System.Text;
using System.Threading.Channels;
using Message = MQTT_WinForms.DB.Objects.Message;

namespace MQTT_WinForms.UI.Forms
{
    public partial class ConnectToBrokerControl : UserControl, ILogSink
    {
        public MQTTWrapper? Wrapper { get; set; }
        private string PublishTopic { get; set; } = "default";
        private MqttQualityOfServiceLevel PublishQOS { get; set; } = MqttQualityOfServiceLevel.AtMostOnce;
        private Connection? Connection { get; set; }

        private readonly Channel<MQTTWrapper.MessageEventArgs> channel = Channel.CreateBounded<MQTTWrapper.MessageEventArgs>(new BoundedChannelOptions(100)
        {
            FullMode = BoundedChannelFullMode.Wait
        });

        public ConnectToBrokerControl()
        {
            InitializeComponent();
            tbAdresse.Text = "127.0.0.1";
            nudPort.Minimum = 0;
            nudPort.Maximum = 65535;
            nudPort.Value = 1883;
            tbClientId.Text = "default";

            textBoxInput.Visible = true;
            mainTable.RowStyles[0].Height = 100;
            mainTable.RowStyles[1].Height = 0;
        }

        public MessageLogControl GetLogControl()
        {
            return messageLog;
        }

        public void LogMessage(Message message)
        {
            messageLog.AddEntry(message);
        }

        private async Task<bool> Connect(MQTTWrapper wrapper)
        {
            if (wrapper?.Options == null) return false;

            TaskCompletionSource<bool> tcs = new(TaskCreationOptions.RunContinuationsAsynchronously);
            wrapper.Connected += (s, e) => tcs.TrySetResult(true);

            MqttClientHelper.Status status = await wrapper.ConnectAsync();
            if (status != MqttClientHelper.Status.Success) tcs.TrySetResult(false);

            Task completed = await Task.WhenAny(tcs.Task, Task.Delay(wrapper.Options.Timeout));
            return completed == tcs.Task && await tcs.Task;
        }

        private async Task<bool> TryPublish(string text)
        {
            if (Wrapper?.Options == null)
                return false;

            TaskCompletionSource<bool> tcs = new(TaskCreationOptions.RunContinuationsAsynchronously);

            MqttClientHelper.Status status = await Wrapper.PublishAsync(PublishTopic, text, qos: PublishQOS);

            tcs.TrySetResult(status == MqttClientHelper.Status.Success);

            Task completion = await Task.WhenAny(tcs.Task, Task.Delay(Wrapper.Options.Timeout));

            if (completion == tcs.Task) return await tcs.Task;

            return false;
        }

        private async void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            MainForm? form = (MainForm?)ParentForm;
            if (form?.tabControl.SelectedTab == null) return;

            form.tabControl.SelectedTab.Text = tbAdresse.Text;

            toolStripProgressBar.Value = 25;
            toolStripStatusLabel.Text = "Verbinde...";

            ConnectionData connectionData = new()
            {
                Address = tbAdresse.Text,
                Port = Convert.ToInt32(nudPort.Value),
                Username = tbUsername.Text,
                Password = tbPasswort.Text
            };
            toolStripProgressBar.Value = 60;

            Wrapper = MqttClientHelper.Setup(connectionData);
            Wrapper.ReceiveMessage += OnMessageReceived;
            if (Wrapper == null) return;

            if (await Connect(Wrapper))
            {
                await using DataBaseContext context = new();
                Connection? existingConnection = context.Connections.FirstOrDefault(x =>
                    x.Host == connectionData.Address &&
                    x.Port == connectionData.Port &&
                    x.Username == connectionData.Username &&
                    x.Password == connectionData.Password);

                if (existingConnection == null)
                {
                    existingConnection = new Connection
                    {
                        Username = connectionData.Username,
                        Password = connectionData.Password,
                        Host = connectionData.Address,
                        Port = connectionData.Port
                    };
                    await context.Connections.AddAsync(existingConnection);
                    await context.SaveChangesAsync();
                }

                Connection = existingConnection;

                await SubscribeToSavedTopicsAsync();
                await LoadSavedMessagesAsync();

                ToggleView();
                toolStripStatusLabel.Text = "Verbindung erfolgreich!";
                toolStripButtonSave.Enabled = true;
                toolStripButtonSend.Enabled = true;
                buttonExport.Enabled = true;
                btClear.Enabled = true;
                toolStripButtonConnect.Enabled = false;

                _ = Task.Run(ProcessMessageChannel);
            }
            else
            {
                toolStripStatusLabel.Text = "Keine Verbindung möglich!";
            }

            toolStripProgressBar.Value = 100;
        }

        private void ToggleView()
        {
            if (mainTable.RowStyles[0].Height.Equals(100))
            {
                mainTable.RowStyles[0].Height = 0;
                mainTable.RowStyles[1].Height = 1;
            }
            else
            {
                mainTable.RowStyles[0].Height = 100;
                mainTable.RowStyles[1].Height = 0;
            }
        }

        private async void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Speichere Verbindung";

            try
            {
                await using DataBaseContext context = new();
                Connection connection = new()
                {
                    Host = tbAdresse.Text,
                    Port = decimal.ToInt32(nudPort.Value),
                    Username = tbUsername.Text,
                    Password = tbPasswort.Text
                };

                context.Connections.Add(connection);
                await context.SaveChangesAsync();

                toolStripStatusLabel.Text = "Verbindung gespeichert";
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler beim Speichern";
            }
        }

        public async Task SetConnection(Connection connection)
        {
            tbAdresse.Text = connection.Host;
            nudPort.Value = connection.Port;
            tbUsername.Text = connection.Username;
            tbPasswort.Text = connection.Password;

            await using DataBaseContext context = new();
            if (!context.Connections.Contains(connection))
            {
                await context.Connections.AddAsync(connection);
                await context.SaveChangesAsync();
            }
        }

        private async void toolStripButtonTopic_Click(object sender, EventArgs e)
        {
            string? topic = InputBox.Show("PublishTopic eingeben:");
            if (Wrapper == null || string.IsNullOrEmpty(topic))
                return;

            PublishTopic = topic;
            await Wrapper.SubscribeAsync(PublishTopic);
        }

        private async void textBoxInput_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e is { KeyCode: Keys.Enter, Shift: false })
            {
                e.SuppressKeyPress = true;
                await SendMessageAsync();
            }
        }

        private async Task SendMessageAsync()
        {
            string messageText = textBoxInput.Text;
            if (!string.IsNullOrEmpty(messageText))
            {
                bool result = await TryPublish(messageText);

                if (result)
                {
                    await LogSentMessageAsync(PublishTopic, messageText);
                    textBoxInput.Text = string.Empty;
                    toolStripStatusLabel.Text = "Erfolgreich gesendet";
                }
                else
                {
                    toolStripStatusLabel.Text = "Fehler beim Senden";
                }
            }
            else
            {
                toolStripStatusLabel.Text = "Das Eingabefeld ist leer";
            }
        }

        private async Task SubscribeToSavedTopicsAsync()
        {
            if (Wrapper == null || Connection == null) return;

            try
            {
                await using DataBaseContext context = new();
                List<Subscription> subscriptions = context.Subscriptions
                                                          .Where(s => s.Connection.ID == Connection.ID && s.IsActive)
                                                          .ToList();

                foreach (Subscription sub in subscriptions) await Wrapper.SubscribeAsync(sub, messageLog.AddLogEntry);
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler beim Laden der Subscriptions";
            }
        }

        private async Task LoadSavedMessagesAsync()
        {
            if (Connection == null) return;

            try
            {
                await using DataBaseContext context = new();
                List<Message> savedMessages = context.Messages
                                                     .Where(m => m.Topic == PublishTopic && m.Connection == Connection)
                                                     .OrderByDescending(m => m.Timestamp)
                                                     .Take(100)
                                                     .OrderBy(m => m.Timestamp)
                                                     .ToList();

                foreach (Message message in savedMessages) LogMessage(message);
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler beim Laden der Nachrichten";
            }
        }

        private async Task ProcessMessageChannel()
        {
            while (await channel.Reader.WaitToReadAsync())
            {
                while (channel.Reader.TryRead(out MQTTWrapper.MessageEventArgs item))
                {
                    try
                    {
                        await SaveMessage(item);
                    }
                    catch
                    {
                        toolStripStatusLabel.Text = "Fehler beim Speichern von Nachricht";
                    }
                }
            }
        }

        private async Task SaveMessage(MQTTWrapper.MessageEventArgs e)
        {
            if (Connection == null)
            {
                return;
            }

            try
            {
                await using DataBaseContext context = new();

                context.Connections.Attach(Connection);

                Message log = new()
                {
                    Connection = Connection,
                    Topic = e.Topic ?? "unknown",
                    MessageText = e.Message ?? "",
                    Timestamp = DateTime.Now,
                    Direction = MessageDirection.Received,
                    QoSLevel = (int)e.QoS,
                    ClientID = Wrapper?.Options?.ClientId ?? "unknown"
                };

                this.SafeLog(log);
                context.Messages.Add(log);
                await context.SaveChangesAsync();
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler beim Speichern empfangener Nachricht";
            }
        }

        private void OnMessageReceived(object? sender, MQTTWrapper.MessageEventArgs e)
        {
            channel.Writer.TryWrite(e);
        }

        private void buttonSetTopic_Click(object sender, EventArgs e)
        {
            if (Wrapper == null)
                return;

            UserInput.InputResult? result = UserInput.QueryUser(PublishTopic, PublishQOS);
            if (!result.HasValue) return;
            PublishTopic = result.Value.Topic;
            PublishQOS = result.Value.QualityOfService;
            toolStripStatusLabel.Text = $"Topic ist jetzt '{PublishTopic}' mit Quality of Service {(int)PublishQOS}";
        }

        private void ManageSubscriptions(object sender, EventArgs e)
        {
            using DataBaseContext context = new();
            if (Connection == null) return;

            ManageSubscriptionsForm.Manage(Connection);
        }

        private async Task LogSentMessageAsync(string topic, string messageText)
        {
            if (Connection == null) return;

            try
            {
                await using DataBaseContext context = new();

                context.Connections.Attach(Connection);

                Message log = new()
                {
                    Connection = Connection,
                    Topic = topic,
                    MessageText = messageText,
                    Timestamp = DateTime.Now,
                    Direction = MessageDirection.Sent
                };

                LogMessage(log);
                context.Messages.Add(log);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                toolStripStatusLabel.Text = "Fehler beim Speichern von Nachricht";
            }
        }

        private async void toolStripButtonSend_Click(object sender, EventArgs e)
        {
            await SendMessageAsync();
        }

        private async void btClear_Click(object sender, EventArgs e)
        {
            await ClearLog();
        }

        private async Task ClearLog()
        {
            if (Connection == null)
            {
                return;
            }

            await using DataBaseContext context = new();

            foreach (Message message in context.Messages.Where(x => x.Connection == Connection))
            {
                context.Messages.Remove(message);
            }

            await context.SaveChangesAsync();
            messageLog.Clear();
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            if (Connection == null)
            {
                return;
            }

            SaveFileDialog dialog = new();
            dialog.FileName = $"{Connection.Host}_{Connection.Port}_{Connection.Username}.csv";
            dialog.CheckPathExists = true;
            dialog.CheckWriteAccess = true;
            dialog.OverwritePrompt = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string data = messageLog.ToCSV(path);

                File.WriteAllText(path, data, Encoding.UTF8);
                DialogResult result = MessageBox.Show("Protokoll gespeichert.\nBestehendes Protokoll leeren?", "Export erfolgreich",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ClearLog();
                }
            }
        }
    }
}