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

            if (mainForm.tabControl.TabPages.Count > 0)
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
            await using DataBaseContext context = new();

            Connection? lastConnection = context.Connections
                .AsEnumerable()
                .OrderBy(x => Math.Abs((x.CreationTime - DateTime.Now).Ticks))
                .FirstOrDefault();

            if(lastConnection != null)
            {
                MainForm mainForm = TabHelper.GetMainForm(sender);
                TabPage connectionTab = TabHelper.NewConnectionTab();

                ConnectToBrokerControl? connectionControl = connectionTab.Controls.OfType<ConnectToBrokerControl>().FirstOrDefault();
                connectionControl?.SetConnection(lastConnection);
               
                mainForm.tabControl.TabPages.Add(connectionTab);
                mainForm.tabControl.SelectedTab = connectionTab;
            }

        }

        private void TabControl_DrawItem(object? sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabRect = tabControl.GetTabRect(e.Index);

            TextRenderer.DrawText(
                e.Graphics,
                tabPage.Text,
                e.Font,
                tabRect,
                tabPage.ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            const int xMargin = 5;
            const int yMargin = 4;
            const int xSize = 6;
            Rectangle closeRect = new(
                tabRect.Right - xSize - xMargin,
                tabRect.Top + yMargin,
                xSize, xSize);

            using Pen pen = new(Color.IndianRed, 2);
            e.Graphics.DrawLine(pen, closeRect.Left, closeRect.Top, closeRect.Right, closeRect.Bottom);
            e.Graphics.DrawLine(pen, closeRect.Right, closeRect.Top, closeRect.Left, closeRect.Bottom);

        }

        private void TabControl_MouseDown(object? sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                Rectangle tabRect = tabControl.GetTabRect(i);
                const int xMargin = 5;
                const int yMargin = 4;
                const int xSize = 6;
                Rectangle closeRect = new (
                    tabRect.Right - xSize - xMargin,
                    tabRect.Top + yMargin,
                    xSize, xSize);

                if (closeRect.Contains(e.Location))
                {
                    tabControl.TabPages[i].Dispose();
                    break;
                }
            }
        }
    }
}
