using MQTT_WinForms.BASE;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.MQTT;
using MQTTnet;
using static MQTT_WinForms.MQTT.MqttClientHelper;

namespace MQTT_WinForms.Forms
{
    public partial class ConnectToBrokerControl : UserControl
    {
        public ConnectToBrokerControl()
        {
            InitializeComponent();
            tbAdresse.Text = "127.0.0.1";
            nudPort.Minimum = 0;
            nudPort.Maximum = 65535;
            nudPort.Value = 1883;
            tbClientId.Text = "default";
            richTextBoxAusgabe.Dock = DockStyle.Fill;
        }

        private async void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            ConnectionData connectionData = new ConnectionData()
            {
                Address = tbAdresse.Text,
                Port = Convert.ToInt32(nudPort.Value),
                ClientID = tbClientId.Text,
                Username = tbUsername.Text,
                Password = tbPasswort.Text,
            };

            
            try
            {
                MQTTWrapper wrapper = MqttClientHelper.ConnectToMqttServer(connectionData);
                Task<MqttClientConnectResult> result = wrapper.Client.ConnectAsync(wrapper.Options);

                if (result.IsFaulted)
                    throw result.Exception;
                Connections.ActiveConnections.Add(result);
                MessageBox.Show($"{Connections.ActiveConnections.Count} aktive Verbindungen");
                toolStripStatusLabel.Text = "Verbindung hergestellt!";
                
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Verbindung nicht möglich!\n" + ex.Message;
            }
            
            
        }

        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            if (!richTextBoxAusgabe.Visible)
                richTextBoxAusgabe.Visible = true;
            else
                richTextBoxAusgabe.Visible = false;


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
    }
}
