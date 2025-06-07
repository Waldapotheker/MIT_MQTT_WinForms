using System.Text;
using MQTTnet.Protocol;
using MQTT_WinForms.BASE;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using static MQTT_WinForms.UI.Forms.UserInput;

namespace MQTT_WinForms.UI.Forms
{
    public partial class LoadConnectionForm : Form
    {
        public LoadConnectionForm()
        {
            InitializeComponent();
        }

        private Connection connection;

        public static Connection? QueryUser(List<Connection> connections)
        {
            LoadConnectionForm input = new LoadConnectionForm();

            input.btOK.DialogResult = DialogResult.OK;
            input.btCancel.DialogResult = DialogResult.Cancel;
            input.AcceptButton = input.btOK;
            input.CancelButton = input.btCancel;

            input.lbConnections.Items.Clear();

            foreach (Connection item in connections)
            {
                input.lbConnections.Items.Add(new ConnectionItem(item));
            }

            DialogResult result = input.ShowDialog();

            if (result == DialogResult.OK)
            {
                return input.connection;
            }

            return null;
        }

        private void lbConnections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbConnections.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                object item = lbConnections.Items[index];
                if (item is ConnectionItem connectionItem)
                {
                    connection = connectionItem.Connection;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (lbConnections.SelectedIndex != -1)
            {
                object item = lbConnections.Items[lbConnections.SelectedIndex];
                if (item is ConnectionItem connectionItem)
                {
                    connection = connectionItem.Connection;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        public class ConnectionItem(Connection connection)
        {
            private string Text
            {
                get
                {
                    return string.IsNullOrEmpty(Connection.Username) ?
                        $"{Connection.Host}:{Connection.Port}" :
                        $"{Connection.Host}:{Connection.Port} - {Connection.Username}";
                }
            }

            public Connection Connection { get; } = connection;

            public override string ToString()
            {
                return Text;
            }
        }

        private async void btDelete_Click(object sender, EventArgs e)
        {
            if (lbConnections.SelectedIndex == -1)
            {
                return;
            }

            object item = lbConnections.Items[lbConnections.SelectedIndex];
            if (item is not ConnectionItem connectionItem)
            {
                return;
            }

            using DataBaseContext context = new();
            context.Connections.Remove(connectionItem.Connection);

            await context.SaveChangesAsync();

            lbConnections.Items.Remove(connectionItem);
        }
    }
}