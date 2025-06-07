using MQTT_WinForms.BASE;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.UI.Helpers;
using System.Runtime.InteropServices;
using MQTT_WinForms.UI.Forms;

namespace MQTT_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TabHelper.WelcomeTab(tabControl);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;

        private void CloseTabClick(object sender, EventArgs e)
        {
            MainForm mainForm = TabHelper.GetMainForm(sender);

            if (mainForm.tabControl.TabPages.Count > 0)
            {
                TabPage? currentTabPage = mainForm.tabControl.SelectedTab;
                currentTabPage?.Dispose();
            }
        }

        private void NewConnectionClick(object sender, EventArgs e)
        {
            MainForm mainForm = TabHelper.GetMainForm(sender);
            TabPage tabPage = TabHelper.NewConnectionTab();
            mainForm.tabControl.TabPages.Add(tabPage);
            mainForm.tabControl.SelectedTab = tabPage;
        }

        private async void LoadConnectionClick(object sender, EventArgs e)
        {
            await using DataBaseContext context = new();

            List<Connection> connections = context.Connections
                                                  .AsEnumerable()
                                                  .OrderBy(x => Math.Abs((x.CreationTime - DateTime.Now).Ticks))
                                                  .ToList();

            if (connections.Count == 0)
            {
                MessageBox.Show("Keine vorherigen Verbindungen.", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            Connection? result = LoadConnectionForm.QueryUser(connections);
            if (result != null)
            {
                MainForm mainForm = TabHelper.GetMainForm(sender);
                TabPage connectionTab = TabHelper.NewConnectionTab();

                ConnectToBrokerControl? connectionControl = connectionTab.Controls.OfType<ConnectToBrokerControl>().FirstOrDefault();
                await connectionControl?.SetConnection(result)!;

                mainForm.tabControl.TabPages.Add(connectionTab);
                mainForm.tabControl.SelectedTab = connectionTab;
            }
        }

        private void TabControlOnHandleCreated(object? sender, EventArgs e)
        {
            SendMessage(tabControl.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, 16);
        }

        private void TabControl_DrawItem(object? sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabRect = tabControl.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);

            Bitmap? closeImage = resources.Close;
            e.Graphics.DrawImage(closeImage,
                tabRect.Right - closeImage.Width,
                tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                tabRect, tabPage.ForeColor, TextFormatFlags.Left);
        }

        private void TabControl_MouseDown(object? sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                Rectangle tabRect = tabControl.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                Bitmap? closeImage = resources.Icon_Close;
                Rectangle imageRect = new(
                    tabRect.Right - closeImage.Width,
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    tabControl.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
    }
}