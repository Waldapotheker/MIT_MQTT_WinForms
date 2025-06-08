namespace MQTT_WinForms.UI.Forms
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
            toolStripSeparator5 = new ToolStripSeparator();
            btClear = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            buttonExport = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            mainTable = new TableLayoutPanel();
            logLayout = new TableLayoutPanel();
            textBoxInput = new TextBox();
            toolStripConnection = new ToolStrip();
            buttonSetTopic = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonSend = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            buttonSubscribe = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            messageLog = new MessageLogControl();
            connectionBoxesLayout = new TableLayoutPanel();
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
            logLayout.SuspendLayout();
            toolStripConnection.SuspendLayout();
            connectionBoxesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonConnect, toolStripSeparator2, toolStripButtonSave, toolStripSeparator5, btClear, toolStripSeparator6, buttonExport, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(881, 31);
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
            toolStripButtonConnect.Size = new Size(75, 28);
            toolStripButtonConnect.Text = "Connect";
            toolStripButtonConnect.Click += toolStripButtonConnect_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.BackColor = SystemColors.Control;
            toolStripButtonSave.Enabled = false;
            toolStripButtonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(147, 28);
            toolStripButtonSave.Text = "Verbindung speichern";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 31);
            // 
            // btClear
            // 
            btClear.Enabled = false;
            btClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btClear.Image = BASE.resources.Icon_Trash;
            btClear.ImageTransparentColor = Color.Magenta;
            btClear.Name = "btClear";
            btClear.Size = new Size(114, 28);
            btClear.Text = "Protokoll leeren";
            btClear.Click += btClear_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 31);
            // 
            // buttonExport
            // 
            buttonExport.Enabled = false;
            buttonExport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExport.Image = BASE.resources.Icon_OpenFolder;
            buttonExport.ImageTransparentColor = Color.Magenta;
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(142, 28);
            buttonExport.Text = "Protokoll exportieren";
            buttonExport.Click += buttonExport_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 31);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 13, 0);
            statusStrip1.Size = new Size(881, 24);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(41, 19);
            toolStripStatusLabel.Text = "Bereit";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(88, 18);
            // 
            // mainTable
            // 
            mainTable.ColumnCount = 1;
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTable.Controls.Add(logLayout, 0, 1);
            mainTable.Controls.Add(connectionBoxesLayout, 0, 0);
            mainTable.Dock = DockStyle.Fill;
            mainTable.Location = new Point(0, 31);
            mainTable.Margin = new Padding(2);
            mainTable.Name = "mainTable";
            mainTable.RowCount = 2;
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTable.Size = new Size(881, 394);
            mainTable.TabIndex = 15;
            // 
            // logLayout
            // 
            logLayout.ColumnCount = 1;
            logLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            logLayout.Controls.Add(textBoxInput, 0, 2);
            logLayout.Controls.Add(toolStripConnection, 0, 1);
            logLayout.Controls.Add(messageLog, 0, 0);
            logLayout.Dock = DockStyle.Fill;
            logLayout.Location = new Point(2, 199);
            logLayout.Margin = new Padding(2);
            logLayout.Name = "logLayout";
            logLayout.RowCount = 3;
            logLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 78.9473648F));
            logLayout.RowStyles.Add(new RowStyle());
            logLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            logLayout.Size = new Size(877, 193);
            logLayout.TabIndex = 16;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(3, 161);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(871, 29);
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
            toolStripConnection.Items.AddRange(new ToolStripItem[] { buttonSetTopic, toolStripSeparator1, toolStripButtonSend, toolStripSeparator3, buttonSubscribe, toolStripSeparator4 });
            toolStripConnection.Location = new Point(0, 127);
            toolStripConnection.Name = "toolStripConnection";
            toolStripConnection.Size = new Size(877, 31);
            toolStripConnection.TabIndex = 14;
            toolStripConnection.Text = "toolStrip";
            // 
            // buttonSetTopic
            // 
            buttonSetTopic.Image = BASE.resources.Icon_Zoom;
            buttonSetTopic.ImageTransparentColor = Color.Magenta;
            buttonSetTopic.Name = "buttonSetTopic";
            buttonSetTopic.Size = new Size(105, 28);
            buttonSetTopic.Text = "Topic wählen";
            buttonSetTopic.Click += buttonSetTopic_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripButtonSend
            // 
            toolStripButtonSend.BackColor = SystemColors.Control;
            toolStripButtonSend.Enabled = false;
            toolStripButtonSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toolStripButtonSend.Image = (Image)resources.GetObject("toolStripButtonSend.Image");
            toolStripButtonSend.ImageTransparentColor = Color.Magenta;
            toolStripButtonSend.Name = "toolStripButtonSend";
            toolStripButtonSend.Size = new Size(75, 28);
            toolStripButtonSend.Text = "Senden";
            toolStripButtonSend.Click += toolStripButtonSend_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = SystemColors.ControlDark;
            toolStripSeparator3.ForeColor = SystemColors.ControlDarkDark;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 31);
            // 
            // buttonSubscribe
            // 
            buttonSubscribe.Image = BASE.resources.Icon_Connect;
            buttonSubscribe.ImageTransparentColor = Color.Magenta;
            buttonSubscribe.Name = "buttonSubscribe";
            buttonSubscribe.Size = new Size(107, 28);
            buttonSubscribe.Text = "Subscriptions";
            buttonSubscribe.Click += ManageSubscriptions;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 31);
            // 
            // messageLog
            // 
            messageLog.Dock = DockStyle.Fill;
            messageLog.Location = new Point(3, 3);
            messageLog.Name = "messageLog";
            messageLog.Size = new Size(871, 121);
            messageLog.TabIndex = 15;
            // 
            // connectionBoxesLayout
            // 
            connectionBoxesLayout.ColumnCount = 2;
            connectionBoxesLayout.ColumnStyles.Add(new ColumnStyle());
            connectionBoxesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            connectionBoxesLayout.Controls.Add(tbPasswort, 1, 4);
            connectionBoxesLayout.Controls.Add(label5, 0, 4);
            connectionBoxesLayout.Controls.Add(label2, 0, 1);
            connectionBoxesLayout.Controls.Add(tbAdresse, 1, 0);
            connectionBoxesLayout.Controls.Add(tbUsername, 1, 3);
            connectionBoxesLayout.Controls.Add(nudPort, 1, 1);
            connectionBoxesLayout.Controls.Add(label4, 0, 3);
            connectionBoxesLayout.Controls.Add(tbClientId, 1, 2);
            connectionBoxesLayout.Controls.Add(label3, 0, 2);
            connectionBoxesLayout.Controls.Add(label1, 0, 0);
            connectionBoxesLayout.Dock = DockStyle.Fill;
            connectionBoxesLayout.Location = new Point(2, 2);
            connectionBoxesLayout.Margin = new Padding(2);
            connectionBoxesLayout.Name = "connectionBoxesLayout";
            connectionBoxesLayout.RowCount = 5;
            connectionBoxesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            connectionBoxesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            connectionBoxesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            connectionBoxesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            connectionBoxesLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            connectionBoxesLayout.Size = new Size(877, 193);
            connectionBoxesLayout.TabIndex = 17;
            // 
            // tbPasswort
            // 
            tbPasswort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPasswort.Location = new Point(112, 163);
            tbPasswort.Name = "tbPasswort";
            tbPasswort.PasswordChar = '*';
            tbPasswort.Size = new Size(762, 25);
            tbPasswort.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(3, 160);
            label5.MaximumSize = new Size(105, 40);
            label5.Name = "label5";
            label5.Size = new Size(103, 40);
            label5.TabIndex = 9;
            label5.Text = "Passwort";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(3, 40);
            label2.MaximumSize = new Size(105, 40);
            label2.Name = "label2";
            label2.Size = new Size(103, 40);
            label2.TabIndex = 6;
            label2.Text = "Port*";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbAdresse
            // 
            tbAdresse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAdresse.Location = new Point(112, 3);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(762, 25);
            tbAdresse.TabIndex = 0;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.Location = new Point(112, 123);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(762, 25);
            tbUsername.TabIndex = 3;
            // 
            // nudPort
            // 
            nudPort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudPort.Location = new Point(112, 43);
            nudPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(762, 25);
            nudPort.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(3, 120);
            label4.MaximumSize = new Size(105, 40);
            label4.Name = "label4";
            label4.Size = new Size(103, 40);
            label4.TabIndex = 8;
            label4.Text = "Username";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbClientId
            // 
            tbClientId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbClientId.Location = new Point(112, 83);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(762, 25);
            tbClientId.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(3, 80);
            label3.MaximumSize = new Size(105, 40);
            label3.Name = "label3";
            label3.Size = new Size(103, 40);
            label3.TabIndex = 7;
            label3.Text = "Client-ID*";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(3, 0);
            label1.MaximumSize = new Size(105, 40);
            label1.Name = "label1";
            label1.Size = new Size(103, 40);
            label1.TabIndex = 5;
            label1.Text = "Broker-Adresse*";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(mainTable);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "ConnectToBrokerControl";
            Size = new Size(881, 449);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainTable.ResumeLayout(false);
            logLayout.ResumeLayout(false);
            logLayout.PerformLayout();
            toolStripConnection.ResumeLayout(false);
            toolStripConnection.PerformLayout();
            connectionBoxesLayout.ResumeLayout(false);
            connectionBoxesLayout.PerformLayout();
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
        private TableLayoutPanel logLayout;
        private TextBox textBoxInput;
        private TableLayoutPanel connectionBoxesLayout;
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
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonSend;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private MessageLogControl messageLog;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btClear;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton buttonExport;
        private ToolStripSeparator toolStripSeparator7;
    }
}
