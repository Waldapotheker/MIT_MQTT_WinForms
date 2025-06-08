using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.UI.Helpers;
using MQTTnet;
using MQTTnet.Protocol;
using static MQTT_WinForms.UI.Forms.LoadConnectionForm;

namespace MQTT_WinForms.UI.Forms
{
    public partial class ManageSubscriptionsForm : Form
    {
        private Connection connection;

        public ManageSubscriptionsForm()
        {
            InitializeComponent();
        }

        public static void Manage(Connection connection)
        {
            using DataBaseContext context = new();

            var fullConnection = context.Connections
                .Where(c => c.ID == connection.ID)
                .Select(c => new
                {
                    Connection = c,
                    Subscriptions = c.Subscriptions.ToList()
                })
                .FirstOrDefault();

            if (fullConnection == null) return;

            ManageSubscriptionsForm form = new()
            {
                connection = fullConnection.Connection
            };

            foreach (Subscription sub in fullConnection.Subscriptions)
            {
                form.lbSubscriptions.Items.Add(new SubscriptionItem(sub));
            }

            form.ShowDialog();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            var input = UserInput.QueryUser();
            if (!input.HasValue) return;

            await using var context = new DataBaseContext();
            context.Connections.Attach(connection);

            var sub = new Subscription
            {
                Connection = connection,
                QualityOfService = (int)input.Value.QualityOfService,
                Topic = input.Value.Topic
            };

            await context.Subscriptions.AddAsync(sub);
            await context.SaveChangesAsync();

            lbSubscriptions.Items.Add(new SubscriptionItem(sub));
        }

        private async void BtEditClick(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedItem is not SubscriptionItem subscriptionItem) return;

            var input = UserInput.QueryUser(
                subscriptionItem.Subscription.Topic,
                (MqttQualityOfServiceLevel)subscriptionItem.Subscription.QualityOfService);

            if (!input.HasValue) return;

            await using var context = new DataBaseContext();
            var subInDb = context.Subscriptions.FirstOrDefault(s => s.ID == subscriptionItem.Subscription.ID);
            if (subInDb == null) return;

            subInDb.Topic = input.Value.Topic;
            subInDb.QualityOfService = (int)input.Value.QualityOfService;
            await context.SaveChangesAsync();

            subscriptionItem.Subscription.Topic = input.Value.Topic;
            subscriptionItem.Subscription.QualityOfService = (int)input.Value.QualityOfService;

            int index = lbSubscriptions.SelectedIndex;
            lbSubscriptions.Items[index] = new SubscriptionItem(subscriptionItem.Subscription);
        }

        private async void btRemove_Click(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedItem is not SubscriptionItem item) return;

            var control = TryGetBrokerControl();
            if (control?.Wrapper != null)
                await control.Wrapper.UnsubscribeAsync(item.Subscription.Topic, control.SafeLog);

            await using var context = new DataBaseContext();
            context.Subscriptions.Remove(item.Subscription);
            await context.SaveChangesAsync();

            lbSubscriptions.Items.Remove(item);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void lbSubscriptions_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSubscriptions.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            if (lbSubscriptions.Items[index] is SubscriptionItem item)
            {
                var control = TryGetBrokerControl();
                if (control?.Wrapper != null)
                    await control.Wrapper.SubscribeAsync(item.Subscription.Topic, item.Subscription.QualityOfService, control.SafeLog);
            }
        }

        private async void btSubscribe_Click(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedItem is SubscriptionItem item)
            {
                var control = TryGetBrokerControl();
                if (control?.Wrapper != null)
                    await control.Wrapper.SubscribeAsync(item.Subscription.Topic, item.Subscription.QualityOfService, control.SafeLog);
            }
        }

        private async void btUnsubscribe_Click(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedItem is SubscriptionItem item)
            {
                var control = TryGetBrokerControl();
                if (control?.Wrapper != null)
                    await control.Wrapper.UnsubscribeAsync(item.Subscription.Topic, control.SafeLog);
            }
        }

        private static ConnectToBrokerControl? TryGetBrokerControl()
        {
            return Application.OpenForms["MainForm"] is MainForm form &&
                   form.ActiveControl is ConnectToBrokerControl control
                   ? control
                   : null;
        }
    }

    public class SubscriptionItem(Subscription subscription)
    {
        public string Text
        {
            get
            {
                return $"{subscription.Topic} - {subscription.QualityOfService}";
            }
        }

        public Subscription Subscription { get; } = subscription;

        public override string ToString()
        {
            return $"{subscription.Topic} - {subscription.QualityOfService}";
        }
    }
}