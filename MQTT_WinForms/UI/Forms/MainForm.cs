using MQTT_WinForms.BASE;
using MQTT_WinForms.DB;
using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.Forms;
using MQTT_WinForms.Properties;
using MQTT_WinForms.UI.Helpers;
using System.Runtime.InteropServices;

namespace MQTT_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TabPage tabPage = TabHelper.WelcomeTab(tabControl);
        }

        private static void CloseTabClick(object sender, EventArgs e)
        {
            MainForm mainForm = TabHelper.GetMainForm(sender);

            if (mainForm.tabControl.TabPages.Count > 0)
            {
                TabPage? currentTabPage = mainForm.tabControl.SelectedTab;
                currentTabPage?.Dispose();
            }
        }

        private static void NewConnectionClick(object sender, EventArgs e)
        {
            MainForm mainForm = TabHelper.GetMainForm(sender);
            TabPage tabPage = TabHelper.NewConnectionTab();
            mainForm.tabControl.TabPages.Add(tabPage);
            mainForm.tabControl.SelectedTab = tabPage;
        }

        private async void LoadConnectionClick(object sender, EventArgs e)
        {
            await using DataBaseContext context = new();

            Connection? lastConnection = context.Connections
                .AsEnumerable()
                .OrderBy(x => Math.Abs((x.CreationTime - DateTime.Now).Ticks))
                .FirstOrDefault();

            if (lastConnection != null)
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
            tabRect.Inflate(-2, -2);

            Bitmap closeImage = resources.Icon_Close;

            int iconPadding = 4;
            Rectangle textRect = new Rectangle(tabRect.X, tabRect.Y, tabRect.Width - closeImage.Width - iconPadding, tabRect.Height);

            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, textRect, tabPage.ForeColor, TextFormatFlags.Left);

            int iconX = tabRect.Right - closeImage.Width;
            int iconY = tabRect.Top + (tabRect.Height - closeImage.Height) / 2;
            e.Graphics.DrawImage(closeImage, iconX, iconY);
        }

        private void TabControl_MouseDown(object? sender, MouseEventArgs e)
        {
            for (var i = 0; i < tabControl.TabPages.Count; i++)
            {
                var tabRect = tabControl.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = resources.Icon_Close;
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
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
