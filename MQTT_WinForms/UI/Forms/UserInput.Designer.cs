namespace MQTT_WinForms.UI.Forms
{
    partial class UserInput
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
            label1 = new Label();
            tbTopic = new TextBox();
            btOK = new Button();
            btCanel = new Button();
            tbQOS = new TrackBar();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbQOS).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 0;
            label1.Text = "Topic";
            // 
            // tbTopic
            // 
            tbTopic.Location = new Point(12, 38);
            tbTopic.Name = "tbTopic";
            tbTopic.Size = new Size(414, 25);
            tbTopic.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.Location = new Point(12, 151);
            btOK.Name = "btOK";
            btOK.Size = new Size(91, 23);
            btOK.TabIndex = 2;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            // 
            // btCanel
            // 
            btCanel.Location = new Point(109, 151);
            btCanel.Name = "btCanel";
            btCanel.Size = new Size(91, 23);
            btCanel.TabIndex = 3;
            btCanel.Text = "Abbrechen";
            btCanel.UseVisualStyleBackColor = true;
            // 
            // tbQOS
            // 
            tbQOS.LargeChange = 1;
            tbQOS.Location = new Point(12, 100);
            tbQOS.Maximum = 2;
            tbQOS.Name = "tbQOS";
            tbQOS.Size = new Size(414, 45);
            tbQOS.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 5;
            label2.Text = "Quality of Service";
            // 
            // UserInput
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 186);
            Controls.Add(label2);
            Controls.Add(tbQOS);
            Controls.Add(btCanel);
            Controls.Add(btOK);
            Controls.Add(tbTopic);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserInput";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)tbQOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTopic;
        private Button btOK;
        private Button btCanel;
        private TrackBar tbQOS;
        private Label label2;
    }
}