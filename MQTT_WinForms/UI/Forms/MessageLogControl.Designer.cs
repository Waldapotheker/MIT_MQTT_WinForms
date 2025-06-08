namespace MQTT_WinForms.UI.Forms
{
    partial class MessageLogControl
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
            dataGrid = new DataGridView();
            status = new DataGridViewTextBoxColumn();
            topic = new DataGridViewTextBoxColumn();
            qos = new DataGridViewTextBoxColumn();
            timestamp = new DataGridViewTextBoxColumn();
            payload = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = SystemColors.Control;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { status, topic, qos, timestamp, payload });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 0);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 40;
            dataGrid.ScrollBars = ScrollBars.Vertical;
            dataGrid.Size = new Size(854, 413);
            dataGrid.TabIndex = 0;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // topic
            // 
            topic.HeaderText = "Topic";
            topic.Name = "topic";
            topic.ReadOnly = true;
            // 
            // qos
            // 
            qos.HeaderText = "Quality of Service";
            qos.Name = "qos";
            qos.ReadOnly = true;
            // 
            // timestamp
            // 
            timestamp.HeaderText = "Timestamp";
            timestamp.Name = "timestamp";
            timestamp.ReadOnly = true;
            // 
            // payload
            // 
            payload.HeaderText = "Payload";
            payload.Name = "payload";
            payload.ReadOnly = true;
            // 
            // MessageLogControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGrid);
            Name = "MessageLogControl";
            Size = new Size(854, 413);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn topic;
        private DataGridViewTextBoxColumn qos;
        private DataGridViewTextBoxColumn timestamp;
        private DataGridViewTextBoxColumn payload;
    }
}
