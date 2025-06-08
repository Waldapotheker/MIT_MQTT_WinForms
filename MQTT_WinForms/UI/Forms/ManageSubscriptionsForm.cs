using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.UI.Helpers;
using MQTTnet.Protocol;

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

            if (fullConnection == null)
            {
                return;
            }

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
            if (!input.HasValue) return;

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

        private async void BtEditClick(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedItem is not SubscriptionItem subscriptionItem) return;

            UserInput.InputResult? input = UserInput.QueryUser(
                subscriptionItem.Subscription.Topic,
                (MqttQualityOfServiceLevel)subscriptionItem.Subscription.QualityOfService);

            if (!input.HasValue)
            {
                return;
            }

            await using DataBaseContext context = new();
            Subscription? subInDb = context.Subscriptions.FirstOrDefault(s => s.ID == subscriptionItem.Subscription.ID);
            if (subInDb == null)
            {
                return;
            }

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

            ConnectToBrokerControl? control = TryGetBrokerControl();
            if (control?.Wrapper != null)
            {
                await control.Wrapper.UnsubscribeAsync(item.Subscription, control.GetLogControl().AddLogEntry);
            }

            await using DataBaseContext context = new();
            context.Subscriptions.Remove(item.Subscription);
            await context.SaveChangesAsync();

            lbSubscriptions.Items.Remove(item);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btSubscribe_Click(object sender, EventArgs e)
        {
            if (lbSubscriptions.SelectedItem is SubscriptionItem item)
            {
                ConnectToBrokerControl? control = TryGetBrokerControl();
                if (control?.Wrapper != null)
                {
                    if (item.Subscription.IsActive)
                    {
                        await control.Wrapper.UnsubscribeAsync(item.Subscription, control.GetLogControl().AddLogEntry);
                    }
                    else
                    {
                        await control.Wrapper.SubscribeAsync(item.Subscription, control.GetLogControl().AddLogEntry);
                    }
                }

                btSubscribe.Text = item.Subscription.IsActive ? "Unsubscribe" : "Subscribe";
            }
        }

        private void LbSubscriptions_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || lbSubscriptions.Items[e.Index] is not SubscriptionItem item)
                return;

            e.DrawBackground();
            Font font = e.Font;
            Color color = e.ForeColor;

            if (item.Subscription.IsActive)
            {
                color = Color.DarkGreen;
                font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
            }

            using SolidBrush brush = new(color);
            e.Graphics.DrawString(item.ToString(), font, brush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private static ConnectToBrokerControl? TryGetBrokerControl()
        {
            return Application.OpenForms["MainForm"] is MainForm
            { ActiveControl: ConnectToBrokerControl control }
                ? control : null;
        }

        private async void lbSubscriptions_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSubscriptions.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
            {
                return;
            }

            if (lbSubscriptions.Items[index] is not SubscriptionItem item)
            {
                return;
            }
            ConnectToBrokerControl? control = TryGetBrokerControl();
            if (control?.Wrapper == null)
            {
                return;
            }

            if (item.Subscription.IsActive)
            {
                await control.Wrapper.UnsubscribeAsync(item.Subscription, control.GetLogControl().AddLogEntry);
            }
            else
            {
                await control.Wrapper.SubscribeAsync(item.Subscription, control.GetLogControl().AddLogEntry);
            }

            btSubscribe.Text = item.Subscription.IsActive ? "Unsubscribe" : "Subscribe";
        }

        private void lbSubscriptions_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lbSubscriptions.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            if (lbSubscriptions.Items[index] is not SubscriptionItem item)
            {
                return;
            }
            btSubscribe.Text = item.Subscription.IsActive ? "Unsubscribe" : "Subscribe";
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