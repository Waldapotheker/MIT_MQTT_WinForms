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
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)nudPort).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbAdresse
            // 
            tbAdresse.Location = new Point(195, 110);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(269, 27);
            tbAdresse.TabIndex = 0;
            // 
            // nudPort
            // 
            nudPort.Location = new Point(195, 143);
            nudPort.Name = "nudPort";
            nudPort.Size = new Size(269, 27);
            nudPort.TabIndex = 1;
            // 
            // tbClientId
            // 
            tbClientId.Location = new Point(195, 176);
            tbClientId.Name = "tbClientId";
            tbClientId.Size = new Size(269, 27);
            tbClientId.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(195, 209);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(269, 27);
            tbUsername.TabIndex = 3;
            // 
            // tbPasswort
            // 
            tbPasswort.Location = new Point(195, 242);
            tbPasswort.Name = "tbPasswort";
            tbPasswort.Size = new Size(269, 27);
            tbPasswort.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 113);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 5;
            label1.Text = "Broker-Adresse*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 145);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 6;
            label2.Text = "Port*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 179);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Client-ID*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 212);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 245);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "Passwort";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonConnect });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1006, 27);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            toolStripButtonConnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonConnect.Image = (Image)resources.GetObject("toolStripButtonConnect.Image");
            toolStripButtonConnect.ImageTransparentColor = Color.Magenta;
            toolStripButtonConnect.Name = "toolStripButtonConnect";
            toolStripButtonConnect.Size = new Size(29, 24);
            toolStripButtonConnect.Text = "Connect";
            toolStripButtonConnect.Click += toolStripButtonConnect_Click;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Right;
            listView1.Location = new Point(470, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(536, 502);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ConnectToBrokerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(listView1);
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
        private ListView listView1;
    }
}
