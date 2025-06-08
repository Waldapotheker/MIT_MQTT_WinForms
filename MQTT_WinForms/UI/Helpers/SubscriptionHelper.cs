using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.MQTT;
using MQTTnet;
using MQTTnet.Protocol;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTT_WinForms.UI.Helpers
{
    public static class MqttSubscriptionHelper
    {
        public static async Task SubscribeAsync(this MQTTWrapper wrapper, string topic, int qos, Action<string>? log = null)
        {
            if (wrapper?.Client?.IsConnected == true)
            {
                _ = await wrapper.SubscribeAsync(topic, (MqttQualityOfServiceLevel)qos);
                log?.Invoke($"[SUBSCRIBED] - {topic} - QoS {qos}");
            }
        }

        public static async Task UnsubscribeAsync(this MQTTWrapper wrapper, string topic, Action<string>? log = null)
        {
            if (wrapper?.Client?.IsConnected == true)
            {
                await wrapper.Client.UnsubscribeAsync(topic);
                log?.Invoke($"[UNSUBSCRIBED] - {topic}");
            }
        }
    }
}
