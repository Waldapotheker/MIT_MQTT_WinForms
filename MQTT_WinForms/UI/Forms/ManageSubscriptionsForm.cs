using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
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
                .Select(c => new {
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
            UserInput.InputResult? input = UserInput.QueryUser();
            if (input.HasValue)
            {
                await using DataBaseContext context = new();

                context.Connections.Attach(connection);

                Subscription sub = new()
                {
                    Connection = connection,
                    QualityOfService = (int)input.Value.QualityOfService,
                    Topic = input.Value.Topic
                };

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
                    try
                    {
                        MainForm? form = (MainForm?)Application.OpenForms["MainForm"];
                        if (form?.ActiveControl is ConnectToBrokerControl control && control.Wrapper?.Client?.IsConnected == true)
                        {
                            await control.Wrapper.Client.UnsubscribeAsync(subscriptionItem.Subscription.Topic);
                        }
                    }
                    catch
                    {
                        // Do nothing; the broker doesn't care
                    }

                    await using DataBaseContext context = new();
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

        private async void lbSubscriptions_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSubscriptions.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
                return;

            if (lbSubscriptions.Items[index] is SubscriptionItem subscriptionItem)
            {
                MainForm? form = (MainForm?)Application.OpenForms["MainForm"];
                if (form?.ActiveControl is ConnectToBrokerControl control && control.Wrapper?.Client?.IsConnected == true)
                {
                    _ = await control.Wrapper.SubscribeAsync(
                        subscriptionItem.Subscription.Topic,
                        (MqttQualityOfServiceLevel)subscriptionItem.Subscription.QualityOfService
                    );

                    control.LogMessage($"[(RE)SUBSCRIBED] - {subscriptionItem.Subscription.Topic} - QoS {subscriptionItem.Subscription.QualityOfService}");
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