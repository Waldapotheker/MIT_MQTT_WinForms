using MQTTnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT_WinForms.MQTT
{
    public static class MQTTConnectionHelper
    {
        public static MqttClientOptionsBuilder NewClientObjectsBuilder(string serveradresse, int port, string clientId, string username = null, string passwort = null)
        {
            MqttClientOptionsBuilder clientBuilder = new MqttClientOptionsBuilder();
            clientBuilder.WithTcpServer("broker.hivemq.com", 1883);
            clientBuilder.Build();

            return clientBuilder;
        }
    
    
    }
}
