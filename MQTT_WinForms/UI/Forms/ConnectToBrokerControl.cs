﻿using MQTT_WinForms.BASE;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.MQTT;
using MQTT_WinForms.UI.Forms;

namespace MQTT_WinForms.Forms
{
    public partial class ConnectToBrokerControl : UserControl
    {
        public MQTTWrapper? Wrapper { get; private set; }
        public string Topic { get; private set; } = "default";

        public ConnectToBrokerControl()
        {
            InitializeComponent();
            tbAdresse.Text = "127.0.0.1";
            nudPort.Minimum = 0;
            nudPort.Maximum = 65535;
            nudPort.Value = 1883;
            tbClientId.Text = "default";

            richTextBoxAusgabe.Dock = DockStyle.Fill;
            textBoxInput.Dock = DockStyle.Bottom;
        }

        private async Task<bool> Connect(MQTTWrapper wrapper)
        {
            TaskCompletionSource<bool> tcs = new(TaskCreationOptions.RunContinuationsAsynchronously);

            wrapper.Connected += (sender, args) =>
            {
                tcs.TrySetResult(true);
            };

            var status = await wrapper.ConnectAsync();

            if(status != MqttClientHelper.Status.Success)
            {
                tcs.TrySetResult(false);
            }

            Task completion = await Task.WhenAny(tcs.Task, Task.Delay(wrapper!.Options!.Timeout));

            if(completion == tcs.Task)
            {
                return await tcs.Task;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> TryPublish(string text)
        {
            TaskCompletionSource<bool> tcs = new(TaskCreationOptions.RunContinuationsAsynchronously);

            var status = await Wrapper!.PublishAsync(Topic, text);

            if (status != MqttClientHelper.Status.Success)
            {
                tcs.TrySetResult(false);
            }
            else
            {
                tcs.TrySetResult(true);
            }

            Task completion = await Task.WhenAny(tcs.Task, Task.Delay(Wrapper!.Options!.Timeout));

            if (completion == tcs.Task)
            {
                return await tcs.Task;
            }
            else
            {
                return false;
            }
        }



        private async void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            toolStripProgressBar.Value = 25;
            toolStripStatusLabel.Text = "Verbinde...";

       
            ConnectionData connectionData = new()
            {
                Address = tbAdresse.Text,
                Port = Convert.ToInt32(nudPort.Value),
                ClientID = tbClientId.Text,
                Username = tbUsername.Text,
                Password = tbPasswort.Text,
            };
            toolStripProgressBar.Value = 60;
  
            Wrapper = MqttClientHelper.Setup(connectionData);
            if (Wrapper != null)
            {
                bool result = await Connect(Wrapper);
                if(result)
                {
                    toolStripStatusLabel.Text = "Verbindung erfolgreich!";
                    toolStripProgressBar.BackColor = Color.Green;
                    toolStripButtonView_Click(null, null);
                }
                else
                {
                    toolStripStatusLabel.Text = "Keine Verbindung möglich!";
                    toolStripProgressBar.BackColor = Color.Red;
                }
                toolStripProgressBar.Value = 100;
            }
        }

        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            if (!richTextBoxAusgabe.Visible)
            {
                richTextBoxAusgabe.Visible = true;
                textBoxInput.Visible = true;
            }
            else
            {
                richTextBoxAusgabe.Visible = false;
                textBoxInput.Visible = false;
            }


        }

        private async void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Speichere Verbindung";

            try
            {
                using DataBaseContext context = new();
                Connection connection = new()
                {
                    Host = tbAdresse.Text,
                    Port = Decimal.ToInt32(nudPort.Value),
                    Topic = tbClientId.Text,
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

        public void SetConnection(Connection connection)
        {
            tbAdresse.Text = connection.Host;
            nudPort.Value = connection.Port;
            tbClientId.Text = connection.Topic;
            tbUsername.Text = connection.Username;
            tbPasswort.Text = connection.Password;
        }

        private async void toolStripButtonSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxInput.Text))
            {
                bool result = await TryPublish(textBoxInput.Text);

                if (result)
                {
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



        private async void toolStripButtonTopic_Click(object sender, EventArgs e)
        {
            string topic = InputBox.Show("Topic eingeben:");
            if (Wrapper != null && topic != string.Empty)
            {
                Topic = topic;
                await Wrapper.SubscribeAsync(Topic);
            }
        }
    }
}
