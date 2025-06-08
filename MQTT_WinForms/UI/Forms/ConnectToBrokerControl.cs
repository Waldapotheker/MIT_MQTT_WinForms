using MQTT_WinForms.BASE;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Enums;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.MQTT;
using MQTT_WinForms.UI.Helpers;
using MQTTnet.Protocol;
using System.Windows.Forms;
using Message = MQTT_WinForms.DB.Objects.Message;

namespace MQTT_WinForms.UI.Forms
{
    public partial class ConnectToBrokerControl : UserControl, ILogSink
    {
        public MQTTWrapper? Wrapper { get; set; }
        private string PublishTopic { get; set; } = "default";
        private MqttQualityOfServiceLevel PublishQOS { get; set; } = MqttQualityOfServiceLevel.AtMostOnce;
        private Connection? Connection { get; set; }

        public ConnectToBrokerControl()
        {
            InitializeComponent();
            tbAdresse.Text = "127.0.0.1";
            nudPort.Minimum = 0;
            nudPort.Maximum = 65535;
            nudPort.Value = 1883;
            tbClientId.Text = "default";

            richTextBoxAusgabe.Visible = true;
            textBoxInput.Visible = true;
            mainTable.RowStyles[0].Height = 100;
            mainTable.RowStyles[1].Height = 0;
        }

        public void LogMessage(string message)
        {
            richTextBoxAusgabe.AppendText(message + Environment.NewLine);
        }

        private async Task<bool> Connect(MQTTWrapper wrapper)
        {
            if (wrapper?.Options == null) return false;

            var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
            wrapper.Connected += (s, e) => tcs.TrySetResult(true);

            var status = await wrapper.ConnectAsync();
            if (status != MqttClientHelper.Status.Success) tcs.TrySetResult(false);

            var completed = await Task.WhenAny(tcs.Task, Task.Delay(wrapper.Options.Timeout));
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

            var connectionData = new ConnectionData
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
                await using var context = new DataBaseContext();
                var existingConnection = context.Connections.FirstOrDefault(x =>
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

                richTextBoxAusgabe.Clear();
                await SubscribeToSavedTopicsAsync();
                await LoadSavedMessagesAsync();

                ToggleView();
                toolStripStatusLabel.Text = "Verbindung erfolgreich!";
                toolStripButtonSave.Enabled = true;
                toolStripButtonSend.Enabled = true;
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
                    string formatted = string.Format("{0,-10} {1,-20} {2,-5} {3,-10} {4}", "[SEND]",
                        PublishTopic, (int)PublishQOS, DateTime.Now.ToString("HH:mm:ss"), messageText);

                    richTextBoxAusgabe.AppendText(formatted + Environment.NewLine);
                    toolStripStatusLabel.Text = "Erfolgreich gesendet";
                    await LogSentMessageAsync(PublishTopic, messageText);
                    textBoxInput.Text = string.Empty;
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
                await using var context = new DataBaseContext();
                var subscriptions = context.Subscriptions
                    .Where(s => s.Connection.ID == Connection.ID)
                    .ToList();

                foreach (var sub in subscriptions)
                {
                    await Wrapper.SubscribeAsync(sub.Topic, sub.QualityOfService, this.SafeLog);
                }

                this.SafeLog("");
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler beim Laden der Subscriptions";
            }
        }

        private async Task LoadSavedMessagesAsync()
        {
            if (Connection == null) return;

            string header = string.Format("{0,-10} {1,-20} {2,-5} {3,-10} {4}", "Direction", "Topic", "QoS", "Time", "Text");
            richTextBoxAusgabe.AppendText(header + Environment.NewLine);

            try
            {
                await using var context = new DataBaseContext();
                var savedMessages = context.Messages
                    .Where(m => m.Topic == PublishTopic)
                    .OrderByDescending(m => m.Timestamp)
                    .Take(100)
                    .OrderBy(m => m.Timestamp)
                    .ToList();

                foreach (var message in savedMessages)
                {
                    string prefix = message.Direction == MessageDirection.Sent ? "[SEND]" : "[RECV]";
                    string formatted = string.Format("{0,-10} {1,-20} {2,-5} {3,-10} {4}",
                        prefix, message.Topic, message.QoSLevel, message.Timestamp.ToString("HH:mm:ss"), message.MessageText);

                    richTextBoxAusgabe.AppendText(formatted + Environment.NewLine);
                }
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler beim Laden der Nachrichten";
            }
        }

        private async void OnMessageReceived(object? sender, MQTTWrapper.MessageEventArgs e)
        {
            string formatted = string.Format("{0,-10} {1,-20} {2,-5} {3,-10} {4}",
                "[RECV]", e.Topic, (int)e.QoS, DateTime.Now.ToString("HH:mm:ss"), e.Message);

            this.SafeLog(formatted);

            try
            {
                await using var context = new DataBaseContext();
                var log = new Message
                {
                    Topic = e.Topic ?? "unknown",
                    MessageText = e.Message ?? "",
                    Timestamp = DateTime.Now,
                    Direction = MessageDirection.Received,
                    QoSLevel = (int)e.QoS,
                    ClientID = Wrapper?.Options?.ClientId ?? "unknown"
                };
                context.Messages.Add(log);
                await context.SaveChangesAsync();
            }
            catch
            {
                toolStripStatusLabel.Text = "Fehler beim Speichern empfangener Nachricht";
            }
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
            using (DataBaseContext context = new())
            {
                if (Connection == null) return;

                ManageSubscriptionsForm.Manage(Connection);
            }
        }

        private async Task LogSentMessageAsync(string topic, string messageText)
        {
            try
            {
                await using DataBaseContext context = new();
                Message log = new()
                {
                    Topic = topic,
                    MessageText = messageText,
                    Timestamp = DateTime.Now,
                    Direction = MessageDirection.Sent
                };
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
    }
}