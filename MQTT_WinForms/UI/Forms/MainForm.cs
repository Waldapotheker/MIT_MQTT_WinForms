using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.Forms;
using MQTT_WinForms.UI.Helpers;

namespace MQTT_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TabPage tabPage = TabHelper.WelcomeTab(tabControl);
        }

        private static void StripButtonCloseTab_Click(object sender, EventArgs e)
        {
            MainForm mainForm = TabHelper.GetMainForm(sender);

            if (mainForm != null && mainForm.tabControl.TabPages.Count > 0)
            {
                TabPage? currentTabPage = mainForm.tabControl.SelectedTab;
                currentTabPage?.Dispose();
            }
        }

        private static void NewConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = TabHelper.GetMainForm(sender);
            TabPage tabPage = TabHelper.NewConnectionTab();
            mainForm.tabControl.TabPages.Add(tabPage);
            mainForm.tabControl.SelectedTab = tabPage;
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            using DataBaseContext context = new();

            Connection? lastConnection = context.Connections
                .AsEnumerable()
                .OrderBy(x => Math.Abs((x.CreationTime - DateTime.Now).Ticks))
                .FirstOrDefault();

            if(lastConnection != null)
            {
                MainForm mainForm = TabHelper.GetMainForm(sender);
                TabPage connectionTab = TabHelper.NewConnectionTab();

                ConnectToBrokerControl? connectionControl = connectionTab.Controls.OfType<ConnectToBrokerControl>().FirstOrDefault();
                if(connectionControl != null)
                {
                    connectionControl.SetConnection(lastConnection);
                }
               
                mainForm.tabControl.TabPages.Add(connectionTab);
                mainForm.tabControl.SelectedTab = connectionTab;
            }

        }
    }
}
