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
            tabControl = new TabControl();
            toolStrip = new ToolStrip();
            button_New = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            button_Load = new ToolStripButton();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(20, 20);
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(61, 4);
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.HotTrack = true;
            tabControl.Location = new Point(0, 39);
            tabControl.Margin = new Padding(0);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(12, 4);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(799, 471);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 4;
            tabControl.HandleCreated += TabControlOnHandleCreated;
            tabControl.DrawItem += TabControl_DrawItem;
            tabControl.MouseDown += TabControl_MouseDown;
            // 
            // toolStrip
            // 
            toolStrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { button_New, toolStripSeparator1, button_Load });
            toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = ToolStripRenderMode.Professional;
            toolStrip.Size = new Size(799, 39);
            toolStrip.TabIndex = 3;
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
            button_New.Size = new Size(65, 36);
            button_New.Text = "Neu";
            button_New.Click += NewConnectionClick;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
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
            button_Load.Size = new Size(75, 36);
            button_Load.Text = "Laden";
            button_Load.Click += LoadConnectionClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 510);
            Controls.Add(tabControl);
            Controls.Add(toolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MQTT Client";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenu;
        public TabControl tabControl;
        private ToolStrip toolStrip;
        private ToolStripButton button_New;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton button_Load;
    }
}
