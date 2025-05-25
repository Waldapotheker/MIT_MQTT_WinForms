using Microsoft.VisualBasic.ApplicationServices;
using MQTT_WinForms.Forms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTT_WinForms.UI.Helpers
{
    public static class TabHelper
    {
        /// <summary>
        /// Gibt einen Tab zurück, der zu Programmstart erscheint
        /// </summary>
        /// <param name="tabPage">TabPage, die als Willkommens-Tab verwendet wird</param>
        /// <param name="tabControl">TabControl, in der der Tab hinzugefügt werden soll</param>
        /// <returns></returns>
        public static TabPage WelcomeTab(TabControl tabControl, TabPage tabPage = null)
        {
            if (tabPage == null)
                tabPage = new TabPage();
            tabPage.Text = "Willkommen";
            WelcomeControl welcomeControl = new WelcomeControl();
            welcomeControl.BackgroundImage = Properties.Resources.MQTT_Image;
            welcomeControl.BackgroundImageLayout = ImageLayout.Stretch; 
            welcomeControl.Dock = DockStyle.Fill;
            welcomeControl.Size = tabPage.Size;
            welcomeControl.Parent = tabPage;
            welcomeControl.Show();
            tabPage.Controls.Add(welcomeControl);
            tabControl.Controls.Add(tabPage);

            return tabPage;
        }

        public static MainForm GetMainForm(object sender)
        {
            MainForm mainForm = null;
            switch (sender.GetType().Name)
            {
                case "ToolStripButton":
                    mainForm = ToolStripButton();
                    break;

                case "ToolStripMenuItem":
                    mainForm = ToolStripMenuItem();
                    break;

                default:
                    throw new NotImplementedException("Falscher Datentyp");

            }

            MainForm ToolStripButton()
            {
                ToolStripButton? button = sender as ToolStripButton;
                ToolStrip? toolStrip = button.GetCurrentParent();
                Control? control = toolStrip;
                Form? form = control?.FindForm();
                MainForm? mainForm = form as MainForm;
                return mainForm;
            }

            MainForm ToolStripMenuItem()
            {
                MainForm mainForm = null;
                ToolStripItem item = sender as ToolStripItem;
                ToolStrip current = item?.Owner;

                while (current != null)
                {
                    if (current is ToolStripDropDown dropDown && dropDown.OwnerItem != null)
                    {
                        current = dropDown.OwnerItem.Owner;
                    }
                    else
                        break;
                }

                if (current != null)
                {
                    Form parent = current.FindForm();
                    mainForm = parent as MainForm;
                }


                return mainForm;
            }
            return mainForm;
        }

        public static TabPage NewConnectionTab()
        {
            TabPage tabPage = new TabPage()
            {
                Text = "Neue Verbindung"
            };

            ConnectToBrokerControl control = new ConnectToBrokerControl();
            control.Dock = DockStyle.Fill;
            control.Size = tabPage.Size;
            control.Parent = tabPage;
            tabPage.Controls.Add(control);

            return tabPage;
        }
    }
}
