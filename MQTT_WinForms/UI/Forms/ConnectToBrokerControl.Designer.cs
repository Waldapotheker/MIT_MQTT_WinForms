namespace MQTT_WinForms.Forms
{
    partial class ConnectToBrokerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectToBrokerControl));
            tbAdresse = new TextBox();
            nudPort = new NumericUpDown();
            tbClientId = new TextBox();
            tbUsername = new TextBox();
            tbPasswort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButtonConnect = new ToolStripButton();
            toolStripButtonView = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            richTextBoxAusgabe = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbAdresse
            // 
            tbAdresse.Location = new Point(134, 32);
            tbAdresse.Margin = new Padding(3, 2, 3, 2);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(547, 23);
            tbAdresse.TabIndex = 0;
            // 
            // nudPort
            // 
            nudPort.Location = new Point(134, 56);
            nudPort.Margin = new Padding(3, 2, 3, 2);
            nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(547, 23);
            nudPort.TabIndex = 1;
            // 
            // tbClientId
            // 
            tbClientId.Location = new Point(134, 80);
            tbClientId.Margin = new Padding(3, 2, 3, 2);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(547, 23);
            tbClientId.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(134, 105);
            tbUsername.Margin = new Padding(3, 2, 3, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(547, 23);
            tbUsername.TabIndex = 3;
            // 
            // tbPasswort
            // 
            tbPasswort.Location = new Point(134, 130);
            tbPasswort.Margin = new Padding(3, 2, 3, 2);
            tbPasswort.Name = "tbPasswort";
            tbPasswort.PasswordChar = '*';
            tbPasswort.Size = new Size(547, 23);
            tbPasswort.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 5;
            label1.Text = "Broker-Adresse*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 6;
            label2.Text = "Port*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Client-ID*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 107);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "Passwort";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonConnect, toolStripButtonView, toolStripButtonSave });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(880, 27);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            toolStripButtonConnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonConnect.Image = (Image)resources.GetObject("toolStripButtonConnect.Image");
            toolStripButtonConnect.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonConnect.ImageTransparentColor = Color.Magenta;
            toolStripButtonConnect.Name = "toolStripButtonConnect";
            toolStripButtonConnect.Size = new Size(36, 24);
            toolStripButtonConnect.Text = "Connect";
            toolStripButtonConnect.Click += toolStripButtonConnect_Click;
            // 
            // toolStripButtonView
            // 
            toolStripButtonView.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonView.Image = (Image)resources.GetObject("toolStripButtonView.Image");
            toolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonView.ImageTransparentColor = Color.Magenta;
            toolStripButtonView.Name = "toolStripButtonView";
            toolStripButtonView.Size = new Size(36, 24);
            toolStripButtonView.Text = "View umschalten";
            toolStripButtonView.Click += toolStripButtonView_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(36, 24);
            toolStripButtonSave.Text = "Verbindung speichern";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // richTextBoxAusgabe
            // 
            richTextBoxAusgabe.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxAusgabe.Location = new Point(0, 157);
            richTextBoxAusgabe.Margin = new Padding(5, 4, 5, 4);
            richTextBoxAusgabe.Name = "richTextBoxAusgabe";
            richTextBoxAusgabe.ReadOnly = true;
            richTextBoxAusgabe.Size = new Size(881, 241);
            richTextBoxAusgabe.TabIndex = 11;
            richTextBoxAusgabe.Text = "";
            richTextBoxAusgabe.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 375);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(880, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(37, 17);
            toolStripStatusLabel.Text = "Bereit";
            // 
            // ConnectToBrokerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(statusStrip1);
            Controls.Add(richTextBoxAusgabe);
            Controls.Add(toolStrip1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPasswort);
            Controls.Add(tbUsername);
            Controls.Add(tbClientId);
            Controls.Add(nudPort);
            Controls.Add(tbAdresse);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ConnectToBrokerControl";
            Size = new Size(880, 397);
            ((System.ComponentModel.ISupportInitialize)nudPort).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAdresse;
        private NumericUpDown nudPort;
        private TextBox tbClientId;
        private TextBox tbUsername;
        private TextBox tbPasswort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonConnect;
        private ToolStripButton toolStripButtonView;
        private ToolStripButton toolStripButtonSave;
        private RichTextBox richTextBoxAusgabe;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}
