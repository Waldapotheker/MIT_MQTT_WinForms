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
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, stripButtonCloseTab });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(914, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { newConnectionToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "Neu";
            // 
            // newConnectionToolStripMenuItem
            // 
            newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            newConnectionToolStripMenuItem.Size = new Size(224, 26);
            newConnectionToolStripMenuItem.Text = "Connect To Broker";
            newConnectionToolStripMenuItem.Click += NewConnectionToolStripMenuItem_Click;
            // 
            // stripButtonCloseTab
            // 
            stripButtonCloseTab.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stripButtonCloseTab.Image = (Image)resources.GetObject("stripButtonCloseTab.Image");
            stripButtonCloseTab.ImageTransparentColor = Color.Magenta;
            stripButtonCloseTab.Name = "stripButtonCloseTab";
            stripButtonCloseTab.Size = new Size(29, 24);
            stripButtonCloseTab.Text = "Schließen";
            stripButtonCloseTab.Click += StripButtonCloseTab_Click;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 27);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(914, 573);
            tabControl.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl);
            Controls.Add(toolStrip);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MQTT Client";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
