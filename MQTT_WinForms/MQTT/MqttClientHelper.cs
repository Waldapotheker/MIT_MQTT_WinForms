using MQTT_WinForms.BASE;
using MQTTnet;
using System.Linq.Expressions;

namespace MQTT_WinForms.MQTT
{
    public static class MqttClientHelper
    {
        public enum Status
        {
            Success = 100,
            QoS0Grant = 101,
            QoS1Grant = 102,
            QoS2Grant = 103,

            NotInitialized = 200,
            NoConnection = 201,
            AlreadyConnected = 202,
            Unauthorized = 203,
     
            InvalidID = 301,
            InvalidUserOrPassword = 302,
            ServerUnavailiable = 303,
            Banned = 304,

            NoMatchingSubscribers = 401,
            InvalidTopic = 402,
            PacketIDInUse = 403,
            QuotaExceeded = 404,

            NotSupported = 501,

            UnspecifiedError = 600,
        }

        public struct Subscription
        {
            public string Topic;

            public Status Status;
        }

        public struct SubscriptionResult
        {
            public SubscriptionResult()
            {
                Subscriptions = [];
            }

            public SubscriptionResult(Status status)
            {
                Subscriptions = [];
                Subscriptions.Add(new Subscription
                {
                    Topic = "Unknown",
                    Status = status
                });
            }

            public List<Subscription> Subscriptions { get; set; }
        }

        public static MQTTWrapper Setup(ConnectionData connectionData)
        {
            #region Verbindungsinformationen übernehmen

            MqttClientOptionsBuilder optionsBuilder = new MqttClientOptionsBuilder()
                .WithClientId(connectionData.ClientID)
                .WithTcpServer(connectionData.Address, connectionData.Port)
                .WithCleanSession()
                .WithKeepAlivePeriod(TimeSpan.FromSeconds(60));

            if (!string.IsNullOrEmpty(connectionData.Username))
            {
                optionsBuilder = optionsBuilder.WithCredentials(connectionData.Username, connectionData.Password);
            }

            MqttClientOptions options = optionsBuilder.Build();

            #endregion

            MqttClientFactory mqttFactory = new();
            IMqttClient mqttClient = mqttFactory.CreateMqttClient();

            MQTTWrapper wrapper = new()
            {
                Client = mqttClient,
                Options = options
            };

            wrapper.Initialize();

            return wrapper;
        }
    }
}
