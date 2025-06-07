namespace MQTT_WinForms.UI.Forms
{
    partial class ManageSubscriptionsForm
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
            lbSubscriptions = new ListBox();
            btOK = new Button();
            btAdd = new Button();
            btRemove = new Button();
            btEdit = new Button();
            SuspendLayout();
            // 
            // lbSubscriptions
            // 
            lbSubscriptions.FormattingEnabled = true;
            lbSubscriptions.ItemHeight = 17;
            lbSubscriptions.Location = new Point(12, 12);
            lbSubscriptions.Name = "lbSubscriptions";
            lbSubscriptions.Size = new Size(366, 208);
            lbSubscriptions.TabIndex = 0;
            lbSubscriptions.MouseDoubleClick += lbSubscriptions_DoubleClick;
            // 
            // btOK
            // 
            btOK.Location = new Point(291, 226);
            btOK.Name = "btOK";
            btOK.Size = new Size(87, 23);
            btOK.TabIndex = 1;
            btOK.Text = "Schließen";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(12, 226);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(87, 23);
            btAdd.TabIndex = 2;
            btAdd.Text = "Neu";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(198, 226);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(87, 23);
            btRemove.TabIndex = 3;
            btRemove.Text = "Löschen";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(105, 226);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(87, 23);
            btEdit.TabIndex = 4;
            btEdit.Text = "Bearbeiten";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += BtEditClick;
            // 
            // ManageSubscriptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 257);
            Controls.Add(btEdit);
            Controls.Add(btRemove);
            Controls.Add(btAdd);
            Controls.Add(btOK);
            Controls.Add(lbSubscriptions);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageSubscriptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subscriptions verwalten";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbSubscriptions;
        private Button btOK;
        private Button btAdd;
        private Button btRemove;
        private Button btEdit;
    }
}