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
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            newConnectionToolStripMenuItem = new ToolStripMenuItem();
            stripButtonCloseTab = new ToolStripButton();
            tabControl = new TabControl();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // toolStrip
            // 
            toolStrip.AutoSize = false;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, stripButtonCloseTab });
            toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = ToolStripRenderMode.Professional;
            toolStrip.Size = new Size(1142, 45);
            toolStrip.Stretch = true;
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { newConnectionToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(50, 40);
            toolStripDropDownButton1.Text = "Neu";
            // 
            // newConnectionToolStripMenuItem
            // 
            newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            newConnectionToolStripMenuItem.Size = new Size(270, 34);
            newConnectionToolStripMenuItem.Text = "Connect To Broker";
            newConnectionToolStripMenuItem.Click += NewConnectionToolStripMenuItem_Click;
            // 
            // stripButtonCloseTab
            // 
            stripButtonCloseTab.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stripButtonCloseTab.Image = (Image)resources.GetObject("stripButtonCloseTab.Image");
            stripButtonCloseTab.ImageScaling = ToolStripItemImageScaling.None;
            stripButtonCloseTab.ImageTransparentColor = Color.Magenta;
            stripButtonCloseTab.Name = "stripButtonCloseTab";
            stripButtonCloseTab.Size = new Size(36, 40);
            stripButtonCloseTab.Text = "Schließen";
            stripButtonCloseTab.Click += StripButtonCloseTab_Click;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 45);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1142, 705);
            tabControl.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(tabControl);
            Controls.Add(toolStrip);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MQTT Client";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem newConnectionToolStripMenuItem;
        private TabControl tabControl;
        private ToolStripButton stripButtonCloseTab;
    }
}
