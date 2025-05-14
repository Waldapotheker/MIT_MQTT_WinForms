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
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbAdresse
            // 
            tbAdresse.Location = new Point(191, 52);
            tbAdresse.Margin = new Padding(4);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(780, 31);
            tbAdresse.TabIndex = 0;
            // 
            // nudPort
            // 
            nudPort.Location = new Point(191, 93);
            nudPort.Margin = new Padding(4);
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(781, 31);
            nudPort.TabIndex = 1;
            // 
            // tbClientId
            // 
            tbClientId.Location = new Point(191, 134);
            tbClientId.Margin = new Padding(4);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(780, 31);
            tbClientId.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(191, 175);
            tbUsername.Margin = new Padding(4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(780, 31);
            tbUsername.TabIndex = 3;
            // 
            // tbPasswort
            // 
            tbPasswort.Location = new Point(191, 216);
            tbPasswort.Margin = new Padding(4);
            tbPasswort.Name = "tbPasswort";
            tbPasswort.Size = new Size(780, 31);
            tbPasswort.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 5;
            label1.Text = "Broker-Adresse*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 6;
            label2.Text = "Port*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 7;
            label3.Text = "Client-ID*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 179);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 220);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
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
            toolStrip1.Size = new Size(1258, 45);
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
            toolStripButtonConnect.Size = new Size(36, 40);
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
            toolStripButtonView.Size = new Size(36, 40);
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
            toolStripButtonSave.Size = new Size(36, 40);
            toolStripButtonSave.Text = "Verbindung speichern";
            // 
            // richTextBoxAusgabe
            // 
            richTextBoxAusgabe.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxAusgabe.Location = new Point(4, 292);
            richTextBoxAusgabe.Margin = new Padding(8);
            richTextBoxAusgabe.Name = "richTextBoxAusgabe";
            richTextBoxAusgabe.Size = new Size(1246, 361);
            richTextBoxAusgabe.TabIndex = 11;
            richTextBoxAusgabe.Text = "";
            richTextBoxAusgabe.Visible = false;
            // 
            // ConnectToBrokerControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
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
            Margin = new Padding(4);
            Name = "ConnectToBrokerControl";
            Size = new Size(1258, 661);
            ((System.ComponentModel.ISupportInitialize)nudPort).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
    }
}
