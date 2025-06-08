using System.Text;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.MQTT;
using MQTTnet;
using MQTTnet.Protocol;
using MQTT_WinForms.UI.Forms;

namespace MQTT_WinForms.UI.Helpers
{
    public static class MqttSubscriptionHelper
    {
        public static async Task SubscribeAsync(this MQTTWrapper wrapper, Subscription subscription, Action<MessageLogControl.Log>? log = null)
        {
            if (wrapper?.Client?.IsConnected == true)
            {
                var _ = await wrapper.SubscribeAsync(subscription.Topic, (MqttQualityOfServiceLevel)subscription.QualityOfService);
                await UpdateSubscriptionStatus(subscription, true, log);
            }
        }

        public static async Task UnsubscribeAsync(this MQTTWrapper wrapper, Subscription subscription, Action<MessageLogControl.Log>? log = null)
        {
            if (wrapper?.Client?.IsConnected == true)
            {
                await wrapper.Client.UnsubscribeAsync(subscription.Topic);
                await UpdateSubscriptionStatus(subscription, false, log);
            }
        }

        private static async Task UpdateSubscriptionStatus(Subscription subscription, bool isActive, Action<MessageLogControl.Log>? log)
        {
            subscription.IsActive = isActive;
            string status = isActive ? "Subscribed" : "Unsubscribed";
            MessageLogControl.Log toLog = new()
            {
                Status = status,
                Topic = subscription.Topic,
                QOS = subscription.QualityOfService,
            };

            log?.Invoke(toLog);

            await using DataBaseContext context = new();
            Subscription? dbSub = context.Subscriptions.FirstOrDefault(s => s.ID == subscription.ID);
            if (dbSub != null)
            {
                dbSub.IsActive = isActive;
                await context.SaveChangesAsync();
            }
        }
    }
}