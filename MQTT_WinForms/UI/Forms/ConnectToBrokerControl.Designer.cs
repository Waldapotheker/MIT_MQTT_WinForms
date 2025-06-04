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
            toolStrip1 = new ToolStrip();
            toolStripButtonConnect = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonSave = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            mainTable = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            richTextBoxAusgabe = new RichTextBox();
            textBoxInput = new TextBox();
            toolStripConnection = new ToolStrip();
            buttonSetTopic = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonSend = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            buttonSubscribe = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            buttonUnsubscribe = new ToolStripButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            tbPasswort = new TextBox();
            label5 = new Label();
            label2 = new Label();
            tbAdresse = new TextBox();
            tbUsername = new TextBox();
            nudPort = new NumericUpDown();
            label4 = new Label();
            tbClientId = new TextBox();
            label3 = new Label();
            label1 = new Label();
            miniToolStrip = new ToolStrip();
            toolStrip2 = new ToolStrip();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainTable.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            toolStripConnection.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonConnect, toolStripSeparator2, toolStripButtonSave });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1258, 45);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            toolStripButtonConnect.BackColor = SystemColors.Control;
            toolStripButtonConnect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripButtonConnect.Image = (Image)resources.GetObject("toolStripButtonConnect.Image");
            toolStripButtonConnect.ImageTransparentColor = Color.Magenta;
            toolStripButtonConnect.Name = "toolStripButtonConnect";
            toolStripButtonConnect.Size = new Size(105, 40);
            toolStripButtonConnect.Text = "Connect";
            toolStripButtonConnect.Click += toolStripButtonConnect_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.BackColor = SystemColors.Control;
            toolStripButtonSave.Enabled = false;
            toolStripButtonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(220, 40);
            toolStripButtonSave.Text = "Verbindung speichern";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStrip1.Location = new Point(0, 629);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1258, 32);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(56, 25);
            toolStripStatusLabel.Text = "Bereit";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(125, 24);
            // 
            // mainTable
            // 
            mainTable.ColumnCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTable.Controls.Add(tableLayoutPanel2, 0, 1);
            mainTable.Controls.Add(tableLayoutPanel3, 0, 0);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 45);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 2;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTable.Size = new Size(1258, 584);
            mainTable.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(richTextBoxAusgabe, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxInput, 0, 2);
            tableLayoutPanel2.Controls.Add(toolStripConnection, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 295);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1252, 286);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // richTextBoxAusgabe
            // 
            richTextBoxAusgabe.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxAusgabe.Dock = DockStyle.Fill;
            richTextBoxAusgabe.Location = new Point(8, 6);
            richTextBoxAusgabe.Margin = new Padding(8, 6, 8, 6);
            richTextBoxAusgabe.Name = "richTextBoxAusgabe";
            richTextBoxAusgabe.ReadOnly = true;
            richTextBoxAusgabe.Size = new Size(1236, 202);
            richTextBoxAusgabe.TabIndex = 11;
            richTextBoxAusgabe.Text = "";
            richTextBoxAusgabe.Visible = false;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(4, 232);
            textBoxInput.Margin = new Padding(4);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(1244, 50);
            textBoxInput.TabIndex = 13;
            textBoxInput.Visible = false;
            textBoxInput.KeyDown += textBoxInput_KeyDown;
            // 
            // toolStripConnection
            // 
            toolStripConnection.Dock = DockStyle.Fill;
            toolStripConnection.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripConnection.GripStyle = ToolStripGripStyle.Hidden;
            toolStripConnection.ImageScalingSize = new Size(24, 24);
            toolStripConnection.Items.AddRange(new ToolStripItem[] { buttonSetTopic, toolStripSeparator1, toolStripButtonSend, toolStripSeparator3, buttonSubscribe, toolStripSeparator4, buttonUnsubscribe });
            toolStripConnection.Location = new Point(0, 214);
            toolStripConnection.Name = "toolStripConnection";
            toolStripConnection.Size = new Size(1252, 14);
            toolStripConnection.TabIndex = 14;
            toolStripConnection.Text = "toolStrip";
            // 
            // buttonSetTopic
            // 
            buttonSetTopic.Image = BASE.resources.Icon_Zoom;
            buttonSetTopic.ImageTransparentColor = Color.Magenta;
            buttonSetTopic.Name = "buttonSetTopic";
            buttonSetTopic.Size = new Size(144, 9);
            buttonSetTopic.Text = "Topic Setzen";
            buttonSetTopic.Click += buttonSetTopic_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 14);
            // 
            // toolStripButtonSend
            // 
            toolStripButtonSend.BackColor = SystemColors.Control;
            toolStripButtonSend.Enabled = false;
            toolStripButtonSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripButtonSend.Image = (Image)resources.GetObject("toolStripButtonSend.Image");
            toolStripButtonSend.ImageTransparentColor = Color.Magenta;
            toolStripButtonSend.Name = "toolStripButtonSend";
            toolStripButtonSend.Size = new Size(103, 9);
            toolStripButtonSend.Text = "Senden";
            toolStripButtonSend.Click += toolStripButtonSend_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = SystemColors.ControlDark;
            toolStripSeparator3.ForeColor = SystemColors.ControlDarkDark;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 14);
            // 
            // buttonSubscribe
            // 
            buttonSubscribe.Image = BASE.resources.Icon_Refresh;
            buttonSubscribe.ImageTransparentColor = Color.Magenta;
            buttonSubscribe.Name = "buttonSubscribe";
            buttonSubscribe.Size = new Size(121, 9);
            buttonSubscribe.Text = "Subscribe";
            buttonSubscribe.Click += buttonSubscribeClick;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 14);
            // 
            // buttonUnsubscribe
            // 
            buttonUnsubscribe.Image = BASE.resources.Icon_Close;
            buttonUnsubscribe.ImageTransparentColor = Color.Magenta;
            buttonUnsubscribe.Name = "buttonUnsubscribe";
            buttonUnsubscribe.Size = new Size(143, 9);
            buttonUnsubscribe.Text = "Unsubscribe";
            buttonUnsubscribe.Click += buttonUnsubscribeClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8178911F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.182106F));
            tableLayoutPanel3.Controls.Add(tbPasswort, 1, 4);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(tbAdresse, 1, 0);
            tableLayoutPanel3.Controls.Add(tbUsername, 1, 3);
            tableLayoutPanel3.Controls.Add(nudPort, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(tbClientId, 1, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(1252, 286);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // tbPasswort
            // 
            tbPasswort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPasswort.Location = new Point(177, 241);
            tbPasswort.Margin = new Padding(4);
            tbPasswort.Name = "tbPasswort";
            tbPasswort.PasswordChar = '*';
            tbPasswort.Size = new Size(1071, 31);
            tbPasswort.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(4, 228);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 58);
            label5.TabIndex = 9;
            label5.Text = "Passwort";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(4, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 57);
            label2.TabIndex = 6;
            label2.Text = "Port*";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbAdresse
            // 
            tbAdresse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbAdresse.Location = new Point(177, 13);
            tbAdresse.Margin = new Padding(4);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(1071, 31);
            tbAdresse.TabIndex = 0;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.Location = new Point(177, 184);
            tbUsername.Margin = new Padding(4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(1071, 31);
            tbUsername.TabIndex = 3;
            // 
            // nudPort
            // 
            nudPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudPort.Location = new Point(177, 70);
            nudPort.Margin = new Padding(4);
            nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(1071, 31);
            nudPort.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(4, 171);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 57);
            label4.TabIndex = 8;
            label4.Text = "Username";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbClientId
            // 
            tbClientId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbClientId.Location = new Point(177, 127);
            tbClientId.Margin = new Padding(4);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(1071, 31);
            tbClientId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(4, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 57);
            label3.TabIndex = 7;
            label3.Text = "Client-ID*";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 57);
            label1.TabIndex = 5;
            label1.Text = "Broker-Adresse*";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Neue Elementauswahl";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.ImageScalingSize = new Size(24, 24);
            miniToolStrip.Location = new Point(14, 0);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(1252, 25);
            miniToolStrip.TabIndex = 14;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Location = new Point(0, 133);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1252, 25);
            toolStrip2.TabIndex = 14;
            toolStrip2.Text = "toolStrip2";
            // 
            // ConnectToBrokerControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(mainTable);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Margin = new Padding(4);
            Name = "ConnectToBrokerControl";
            Size = new Size(1258, 661);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainTable.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            toolStripConnection.ResumeLayout(false);
            toolStripConnection.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonConnect;
        private ToolStripButton toolStripButtonSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private TableLayoutPanel mainTable;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox richTextBoxAusgabe;
        private TextBox textBoxInput;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tbPasswort;
        private Label label1;
        private Label label5;
        private Label label2;
        private TextBox tbAdresse;
        private TextBox tbUsername;
        private NumericUpDown nudPort;
        private Label label4;
        private TextBox tbClientId;
        private Label label3;
        private ToolStrip miniToolStrip;
        private ToolStrip toolStrip2;
        private ToolStrip toolStripConnection;
        private ToolStripButton buttonSetTopic;
        private ToolStripButton buttonSubscribe;
        private ToolStripButton buttonUnsubscribe;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonSend;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
    }
}
