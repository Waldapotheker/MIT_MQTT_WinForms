using MQTT_WinForms.DB;
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
        public static async Task SubscribeAsync(this MQTTWrapper wrapper, Subscription subscription, Action<string>? log = null)
        {
            if (wrapper?.Client?.IsConnected == true)
            {
                var _ = await wrapper.SubscribeAsync(subscription.Topic, (MqttQualityOfServiceLevel)subscription.QualityOfService);
                await UpdateSubscriptionStatus(subscription, true, log);
            }
        }

        public static async Task UnsubscribeAsync(this MQTTWrapper wrapper, Subscription subscription, Action<string>? log = null)
        {
            if (wrapper?.Client?.IsConnected == true)
            {
                await wrapper.Client.UnsubscribeAsync(subscription.Topic);
                await UpdateSubscriptionStatus(subscription, false, log);
            }
        }

        private static async Task UpdateSubscriptionStatus(Subscription subscription, bool isActive, Action<string>? log)
        {
            subscription.IsActive = isActive;
            string action = isActive ? "[SUBSCRIBED]" : "[UNSUBSCRIBED]";
            log?.Invoke($"{action} - {subscription.Topic}{(isActive ? $" - QoS {subscription.QualityOfService}" : string.Empty)}");

            await using var context = new DataBaseContext();
            var dbSub = context.Subscriptions.FirstOrDefault(s => s.ID == subscription.ID);
            if (dbSub != null)
            {
                dbSub.IsActive = isActive;
                await context.SaveChangesAsync();
            }
        }
    }
}
