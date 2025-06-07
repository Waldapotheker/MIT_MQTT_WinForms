using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
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
            ManageSubscriptionsForm form = new ManageSubscriptionsForm();
            form.connection = connection;
            foreach (Subscription subscription in connection.Subscriptions)
            {
                form.lbSubscriptions.Items.Add(new SubscriptionItem(subscription));
            }

            form.ShowDialog();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            UserInput.InputResult? input = UserInput.QueryUser();
            if (input.HasValue)
            {
                Subscription sub = new()
                {
                    Connection = connection,
                    QualityOfService = (int)input.Value.QualityOfService,
                    Topic = input.Value.Topic
                };

                await using DataBaseContext context = new();

                connection.Subscriptions.Add(sub);
                await context.Subscriptions.AddAsync(sub);

                await context.SaveChangesAsync();
                lbSubscriptions.Items.Add(new SubscriptionItem(sub));
            }
        }

        private async void BtEditClick(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedIndex != -1)
            {
                object item = lbSubscriptions.Items[lbSubscriptions.SelectedIndex];
                if (item is SubscriptionItem subscriptionItem)
                {
                    var existingSubscription = subscriptionItem.Subscription;
                    UserInput.InputResult? input = UserInput.QueryUser(subscriptionItem.Subscription.Topic, (MqttQualityOfServiceLevel)subscriptionItem.Subscription.QualityOfService);
                    if (input.HasValue)
                    {
                        await using DataBaseContext context = new();
                        existingSubscription.QualityOfService = (int)input.Value.QualityOfService;
                        existingSubscription.Topic = input.Value.Topic;

                        await context.SaveChangesAsync();
                    }
                }
            }
        }

        private async void btRemove_Click(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedIndex != -1)
            {
                object item = lbSubscriptions.Items[lbSubscriptions.SelectedIndex];
                if (item is SubscriptionItem subscriptionItem)
                {
                    await using DataBaseContext context = new();
                    subscriptionItem.Subscription.Connection.Subscriptions.Remove(subscriptionItem.Subscription);
                    context.Subscriptions.Remove(subscriptionItem.Subscription);

                    await context.SaveChangesAsync();

                    lbSubscriptions.Items.Remove(subscriptionItem);
                }
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbSubscriptions_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSubscriptions.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                object item = lbSubscriptions.Items[index];
                if (item is SubscriptionItem subscriptionItem)
                {
                }
            }
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
            return Text;
        }
    }
}