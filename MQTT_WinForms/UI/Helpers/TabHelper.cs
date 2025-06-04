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
        public static TabPage WelcomeTab(TabControl tabControl, TabPage? tabPage = null)
        {
            tabPage ??= new TabPage();
            tabPage.Text = "Willkommen";
            WelcomeControl welcomeControl = new()
            {
                BackgroundImage = Properties.Resources.MQTT_Image,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Fill,
                Size = tabPage.Size,
                Parent = tabPage
            };
            welcomeControl.Show();
            tabPage.Controls.Add(welcomeControl);
            tabControl.Controls.Add(tabPage);

            return tabPage;
        }

        public static MainForm GetMainForm(object sender)
        {
            if(sender is Control control)
            {
                if (control.FindForm() is MainForm form)
                { 
                    return form; 
                }
            }

            MainForm? mainForm = sender.GetType().Name switch
            {
                "ToolStripButton" => GetFromToolStripButton(),
                "ToolStripMenuItem" => GetFromToolStripMenuItem(),
                _ => throw new NotImplementedException("Falscher Datentyp: " + sender.GetType().Name),
            };

            return mainForm ?? throw new InvalidOperationException("MainForm nicht gefunden");

            MainForm? GetFromToolStripButton()
            {
                ToolStripButton? button = sender as ToolStripButton;
                Control? control = button?.GetCurrentParent();
                return control?.FindForm() as MainForm;
            }

            MainForm? GetFromToolStripMenuItem()
            {
                ToolStripItem? item = sender as ToolStripItem;
                ToolStrip? current = item?.Owner;

                while (current != null)
                {
                    Form? form = current.FindForm();
                    if (form is MainForm mainForm)
                        return mainForm;

                    if (current is ToolStripDropDown dropDown && dropDown.OwnerItem != null)
                    {
                        current = dropDown.OwnerItem.Owner;
                    }
                    else
                    {
                        break;
                    }
                }

                return null;
            }
        }

        public static TabPage NewConnectionTab()
        {
            TabPage tabPage = new()
            {
                Text = "Neu"
            };

            ConnectToBrokerControl control = new();
            control.Dock = DockStyle.Fill;
            control.Size = tabPage.Size;
            control.Parent = tabPage;
            tabPage.Controls.Add(control);

            return tabPage;
        }
    }
}
