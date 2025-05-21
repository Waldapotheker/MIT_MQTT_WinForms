using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MQTT_WinForms.BASE;
using MQTTnet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MQTT_WinForms.MQTT
{
    public static class MqttClient
    {
        public static async Task  ConnectToMqttServer(ConnectionData connectionData)
        {
            #region Verbindungsinformationen übernehmen
            var options = new MqttClientOptionsBuilder();
            if (connectionData.Username != null || connectionData.Username != string.Empty)
            {
                options
                .WithClientId(connectionData.ClientID)
                .WithTcpServer(connectionData.Address, connectionData.Port)
                .WithCredentials(connectionData.Username, connectionData.Password)
                .WithCleanSession()
                .Build();
            }
            else
            {

                options
                .WithClientId(connectionData.ClientID)
                .WithTcpServer(connectionData.Address, connectionData.Port)
                .WithCleanSession()
                .Build();
            }
            #endregion

            
            var mqttFactory = new MqttClientFactory();
            var mqttClient = mqttFactory.CreateMqttClient();


            #region Events für Connect/Disconnect
            mqttClient.ConnectedAsync += async e =>
            {
                MessageBox.Show("MQTT Verbindung erfolgreich hergestellt!");
            };

            mqttClient.DisconnectedAsync += async e =>
            {
                MessageBox.Show("MQTT Verbindung verloren oder fehlgeschlagen.");
            };
            #endregion

            try
            {
                await mqttClient.ConnectAsync(options.Build());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Verbinden mit MQTT: " + ex.Message);
            }


        }

    }
}
