using Microsoft.VisualBasic.FileIO;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using System.Text.RegularExpressions;

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
            nudPort.Value = 1833;
            tbClientId.Text = "default";
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {

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
