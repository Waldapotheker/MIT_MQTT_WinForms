namespace MQTT_WinForms.UI.Forms
{
    partial class LoadConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbConnections = new ListBox();
            btOK = new Button();
            btCancel = new Button();
            btDelete = new Button();
            SuspendLayout();
            // 
            // lbConnections
            // 
            lbConnections.FormattingEnabled = true;
            lbConnections.ItemHeight = 17;
            lbConnections.Location = new Point(12, 12);
            lbConnections.Name = "lbConnections";
            lbConnections.ScrollAlwaysVisible = true;
            lbConnections.Size = new Size(536, 157);
            lbConnections.TabIndex = 0;
            lbConnections.MouseDoubleClick += lbConnections_MouseDoubleClick;
            // 
            // btOK
            // 
            btOK.Location = new Point(12, 175);
            btOK.Name = "btOK";
            btOK.Size = new Size(94, 23);
            btOK.TabIndex = 1;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(112, 175);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 23);
            btCancel.TabIndex = 2;
            btCancel.Text = "Abbrechen";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(435, 175);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(113, 23);
            btDelete.TabIndex = 3;
            btDelete.Text = "Eintrag löschen";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // LoadConnectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 214);
            Controls.Add(btDelete);
            Controls.Add(btCancel);
            Controls.Add(btOK);
            Controls.Add(lbConnections);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadConnectionForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verbindung Laden";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbConnections;
        private Button btOK;
        private Button btCancel;
        private Button btDelete;
    }
}