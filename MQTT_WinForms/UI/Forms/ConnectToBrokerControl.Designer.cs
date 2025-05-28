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
            toolStripProgressBar = new ToolStripProgressBar();
            textBoxInput = new TextBox();
            toolStripButtonSend = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbAdresse
            // 
            tbAdresse.Location = new Point(153, 43);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(625, 27);
            tbAdresse.TabIndex = 0;
            // 
            // nudPort
            // 
            nudPort.Location = new Point(153, 75);
            nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(625, 27);
            nudPort.TabIndex = 1;
            // 
            // tbClientId
            // 
            tbClientId.Location = new Point(153, 107);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(625, 27);
            tbClientId.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(153, 140);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(625, 27);
            tbUsername.TabIndex = 3;
            // 
            // tbPasswort
            // 
            tbPasswort.Location = new Point(153, 173);
            tbPasswort.Name = "tbPasswort";
            tbPasswort.PasswordChar = '*';
            tbPasswort.Size = new Size(625, 27);
            tbPasswort.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 5;
            label1.Text = "Broker-Adresse*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 76);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 6;
            label2.Text = "Port*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 109);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Client-ID*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 143);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 176);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "Passwort";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonConnect, toolStripButtonView, toolStripButtonSave, toolStripButtonSend });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1006, 36);
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
            toolStripButtonConnect.Size = new Size(36, 33);
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
            toolStripButtonView.Size = new Size(36, 33);
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
            toolStripButtonSave.Size = new Size(36, 33);
            toolStripButtonSave.Text = "Verbindung speichern";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // richTextBoxAusgabe
            // 
            richTextBoxAusgabe.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxAusgabe.Location = new Point(0, 209);
            richTextBoxAusgabe.Margin = new Padding(6, 5, 6, 5);
            richTextBoxAusgabe.Name = "richTextBoxAusgabe";
            richTextBoxAusgabe.ReadOnly = true;
            richTextBoxAusgabe.Size = new Size(1006, 219);
            richTextBoxAusgabe.TabIndex = 11;
            richTextBoxAusgabe.Text = "";
            richTextBoxAusgabe.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStrip1.Location = new Point(0, 503);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1006, 26);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(48, 20);
            toolStripStatusLabel.Text = "Bereit";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 18);
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Location = new Point(3, 436);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(1000, 64);
            textBoxInput.TabIndex = 13;
            textBoxInput.Visible = false;
            // 
            // toolStripButtonSend
            // 
            toolStripButtonSend.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSend.Image = (Image)resources.GetObject("toolStripButtonSend.Image");
            toolStripButtonSend.ImageTransparentColor = Color.Magenta;
            toolStripButtonSend.Name = "toolStripButtonSend";
            toolStripButtonSend.Size = new Size(29, 33);
            toolStripButtonSend.Text = "Senden";
            toolStripButtonSend.Click += toolStripButtonSend_Click;
            // 
            // ConnectToBrokerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(textBoxInput);
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
            Name = "ConnectToBrokerControl";
            Size = new Size(1006, 529);
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
        private ToolStripProgressBar toolStripProgressBar;
        private TextBox textBoxInput;
        private ToolStripButton toolStripButtonSend;
    }
}
