using MQTTnet.Protocol;
using MQTTnet;

using static MQTT_WinForms.MQTT.MqttClientHelper;

namespace MQTT_WinForms.MQTT
{
    public class MQTTWrapper
    {
        public IMqttClient? Client { get; set; }

        public MqttClientOptions? Options { get; set; }

        public async Task<Status> ConnectAsync()
        {
            if (Client == null)
            {
                return Status.NotInitialized;
            }

            if (Client.IsConnected)
            {
                return Status.AlreadyConnected;
            }

            MqttClientConnectResult connectionResult = await Client.ConnectAsync(Options);
            return connectionResult.ResultCode switch
            {
                MqttClientConnectResultCode.Success => Status.Success,
                MqttClientConnectResultCode.ClientIdentifierNotValid => Status.InvalidID,
                MqttClientConnectResultCode.BadUserNameOrPassword => Status.InvalidUserOrPassword,
                MqttClientConnectResultCode.ServerUnavailable
                or MqttClientConnectResultCode.ServerBusy
                or MqttClientConnectResultCode.UseAnotherServer => Status.ServerUnavailiable,

                MqttClientConnectResultCode.Banned => Status.Banned,
                _ => Status.UnspecifiedError,
            };
        }

        public async Task<Status> PublishAsync(string topic, string payload, bool retain = false, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtLeastOnce)
        {
            if (Client == null)
            {
                return Status.NotInitialized;
            }

            if (!Client.IsConnected)
            {
                return Status.NoConnection;
            }

            MqttApplicationMessage message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(payload)
                .WithQualityOfServiceLevel(qos)
                .WithRetainFlag(retain)
                .Build();

            MqttClientPublishResult result = await Client.PublishAsync(message);
            return result.ReasonCode switch
            {
                MqttClientPublishReasonCode.Success => Status.Success,
                MqttClientPublishReasonCode.NoMatchingSubscribers => Status.NoMatchingSubscribers,
                MqttClientPublishReasonCode.PayloadFormatInvalid
                or MqttClientPublishReasonCode.UnspecifiedError
                or MqttClientPublishReasonCode.ImplementationSpecificError => Status.UnspecifiedError,

                MqttClientPublishReasonCode.NotAuthorized => Status.Unauthorized,
                MqttClientPublishReasonCode.TopicNameInvalid => Status.InvalidTopic,
                MqttClientPublishReasonCode.PacketIdentifierInUse => Status.PacketIDInUse,
                MqttClientPublishReasonCode.QuotaExceeded => Status.QuotaExceeded,
                _ => Status.UnspecifiedError,
            };
        }

        public async Task<SubscriptionResult> SubscribeAsync(string topic, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtLeastOnce)
        {
            if (Client == null)
            {
                return new SubscriptionResult(Status.NotInitialized);
            }

            if (!Client.IsConnected)
            {
                return new SubscriptionResult(Status.NoConnection);
            }

            MqttClientSubscribeResult result = await Client.SubscribeAsync(new MqttClientSubscribeOptionsBuilder()
                .WithTopicFilter(f => f.WithTopic(topic).WithQualityOfServiceLevel(qos))
                .Build());

            SubscriptionResult output = new();
            foreach (var item in result.Items)
            {
                var status = Status.UnspecifiedError;
                status = item.ResultCode switch
                {
                    MqttClientSubscribeResultCode.GrantedQoS0 => Status.QoS0Grant,
                    MqttClientSubscribeResultCode.GrantedQoS1 => Status.QoS1Grant,
                    MqttClientSubscribeResultCode.GrantedQoS2 => Status.QoS2Grant,
                    MqttClientSubscribeResultCode.NotAuthorized => Status.Unauthorized,
                    MqttClientSubscribeResultCode.TopicFilterInvalid => Status.InvalidTopic,
                    MqttClientSubscribeResultCode.PacketIdentifierInUse => Status.PacketIDInUse,
                    MqttClientSubscribeResultCode.QuotaExceeded => Status.QuotaExceeded,
                    MqttClientSubscribeResultCode.SharedSubscriptionsNotSupported
                    or MqttClientSubscribeResultCode.SubscriptionIdentifiersNotSupported
                    or MqttClientSubscribeResultCode.WildcardSubscriptionsNotSupported => Status.NotSupported,
                    _ => Status.UnspecifiedError,
                };
                output.Subscriptions.Add(new Subscription()
                {
                    Topic = item.TopicFilter.Topic,
                    Status = status
                });
            }

            return output;
        }
    }
}
