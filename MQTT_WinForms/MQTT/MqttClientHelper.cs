using MQTT_WinForms.BASE;
using MQTTnet;

namespace MQTT_WinForms.MQTT
{
    public static class MqttClientHelper
    {
        public class MQTTWrapper
        {
            public IMqttClient? Client { get; set; }

            public MqttClientOptions? Options { get; set; }
        }

        public static MQTTWrapper ConnectToMqttServer(ConnectionData connectionData)
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

            MqttClientFactory mqttFactory = new MqttClientFactory();
            IMqttClient mqttClient = mqttFactory.CreateMqttClient();

            return new MQTTWrapper
            {
                Client = mqttClient,
                Options = options.Build()
            };
            


        }

    }
}
