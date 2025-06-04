namespace MQTT_WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            contextMenu = new ContextMenuStrip(components);
            toolStrip = new ToolStrip();
            button_New = new ToolStripButton();
            button_Load = new ToolStripButton();
            tabControl = new TabControl();
            layoutPanel = new TableLayoutPanel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip.SuspendLayout();
            layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(20, 20);
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(61, 4);
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Fill;
            toolStrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { button_New, toolStripSeparator1, button_Load });
            toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = ToolStripRenderMode.Professional;
            toolStrip.Size = new Size(1142, 37);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // button_New
            // 
            button_New.BackColor = SystemColors.Control;
            button_New.BackgroundImageLayout = ImageLayout.None;
            button_New.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button_New.Image = (Image)resources.GetObject("button_New.Image");
            button_New.ImageScaling = ToolStripItemImageScaling.None;
            button_New.ImageTransparentColor = Color.Magenta;
            button_New.Name = "button_New";
            button_New.Size = new Size(83, 32);
            button_New.Text = "Neu";
            button_New.Click += NewConnectionClick;
            // 
            // button_Load
            // 
            button_Load.BackColor = SystemColors.Control;
            button_Load.BackgroundImageLayout = ImageLayout.None;
            button_Load.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button_Load.Image = (Image)resources.GetObject("button_Load.Image");
            button_Load.ImageScaling = ToolStripItemImageScaling.None;
            button_Load.ImageTransparentColor = Color.Magenta;
            button_Load.Name = "button_Load";
            button_Load.Size = new Size(98, 32);
            button_Load.Text = "Laden";
            button_Load.Click += LoadConnectionClick;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.HotTrack = true;
            tabControl.Location = new Point(0, 37);
            tabControl.Margin = new Padding(0);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(10, 3);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1142, 713);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 2;
            tabControl.DrawItem += TabControl_DrawItem;
            tabControl.MouseDown += TabControl_MouseDown;
            // 
            // layoutPanel
            // 
            layoutPanel.ColumnCount = 1;
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutPanel.Controls.Add(tabControl, 0, 1);
            layoutPanel.Controls.Add(toolStrip, 0, 0);
            layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.Location = new Point(0, 0);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.RowCount = 2;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            layoutPanel.Size = new Size(1142, 750);
            layoutPanel.TabIndex = 3;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(layoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MQTT Client";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            layoutPanel.ResumeLayout(false);
            layoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenu;
        private ToolStrip toolStrip;
        private ToolStripButton button_New;
        public TabControl tabControl;
        private ToolStripButton button_Load;
        private TableLayoutPanel layoutPanel;
        private ToolStripSeparator toolStripSeparator1;
    }
}
