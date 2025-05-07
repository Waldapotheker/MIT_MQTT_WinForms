
using MQTT_WinForms.Helpers;
using System.Collections.ObjectModel;
using System.Diagnostics;

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
    }
}
