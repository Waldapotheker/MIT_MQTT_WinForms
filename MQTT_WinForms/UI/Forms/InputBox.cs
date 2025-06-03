using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT_WinForms.UI.Forms
{
    public static class InputBox
    {
        public static string? Show(string prompt, string title = "Eingabe", string defaultValue = "")
        {
            Form form = new();
            Label label = new();
            TextBox textBox = new();
            Button buttonOk = new();
            Button buttonCancel = new();

            form.Text = title;
            label.Text = prompt;
            textBox.Text = defaultValue;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Abbrechen";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(10, 10, 380, 20);
            textBox.SetBounds(10, 35, 380, 20);
            buttonOk.SetBounds(220, 70, 80, 30);
            buttonCancel.SetBounds(310, 70, 80, 30);

            label.AutoSize = true;
            textBox.Anchor |= AnchorStyles.Right;
            form.ClientSize = new Size(400, 110);
            form.Controls.AddRange([label, textBox, buttonOk, buttonCancel]);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult == DialogResult.OK ? textBox.Text : null;
        }
    }
}
