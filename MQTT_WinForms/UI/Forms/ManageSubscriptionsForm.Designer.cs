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
            btSubscribe = new Button();
            btUnsubscribe = new Button();
            SuspendLayout();
            // 
            // lbSubscriptions
            // 
            lbSubscriptions.FormattingEnabled = true;
            lbSubscriptions.ItemHeight = 25;
            lbSubscriptions.Location = new Point(17, 18);
            lbSubscriptions.Margin = new Padding(4, 4, 4, 4);
            lbSubscriptions.Name = "lbSubscriptions";
            lbSubscriptions.Size = new Size(786, 304);
            lbSubscriptions.TabIndex = 0;
            lbSubscriptions.MouseDoubleClick += lbSubscriptions_DoubleClick;
            lbSubscriptions.DrawMode = DrawMode.OwnerDrawFixed;
            lbSubscriptions.DrawItem += LbSubscriptions_DrawItem;
            // 
            // btOK
            // 
            btOK.Location = new Point(679, 331);
            btOK.Margin = new Padding(4, 4, 4, 4);
            btOK.Name = "btOK";
            btOK.Size = new Size(124, 34);
            btOK.TabIndex = 1;
            btOK.Text = "Schließen";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(17, 332);
            btAdd.Margin = new Padding(4, 4, 4, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(124, 34);
            btAdd.TabIndex = 2;
            btAdd.Text = "Neu";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(283, 332);
            btRemove.Margin = new Padding(4, 4, 4, 4);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(124, 34);
            btRemove.TabIndex = 3;
            btRemove.Text = "Löschen";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(150, 332);
            btEdit.Margin = new Padding(4, 4, 4, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(124, 34);
            btEdit.TabIndex = 4;
            btEdit.Text = "Bearbeiten";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += BtEditClick;
            // 
            // btSubscribe
            // 
            btSubscribe.Location = new Point(415, 332);
            btSubscribe.Margin = new Padding(4);
            btSubscribe.Name = "btSubscribe";
            btSubscribe.Size = new Size(124, 34);
            btSubscribe.TabIndex = 5;
            btSubscribe.Text = "Subscribe";
            btSubscribe.UseVisualStyleBackColor = true;
            btSubscribe.Click += btSubscribe_Click;
            // 
            // btUnsubscribe
            // 
            btUnsubscribe.Location = new Point(547, 331);
            btUnsubscribe.Margin = new Padding(4);
            btUnsubscribe.Name = "btUnsubscribe";
            btUnsubscribe.Size = new Size(124, 34);
            btUnsubscribe.TabIndex = 6;
            btUnsubscribe.Text = "Unsubscribe";
            btUnsubscribe.UseVisualStyleBackColor = true;
            btUnsubscribe.Click += btUnsubscribe_Click;
            // 
            // ManageSubscriptionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 378);
            Controls.Add(btUnsubscribe);
            Controls.Add(btSubscribe);
            Controls.Add(btEdit);
            Controls.Add(btRemove);
            Controls.Add(btAdd);
            Controls.Add(btOK);
            Controls.Add(lbSubscriptions);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
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
        private Button btSubscribe;
        private Button btUnsubscribe;
    }
}