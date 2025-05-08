
namespace KeepMachineAwake
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
            TrayIcon = new NotifyIcon(components);
            TrayIconContextMenu = new ContextMenuStrip(components);
            TrayIconActive = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            TrayIconExit = new ToolStripMenuItem();
            TrayIconContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TrayIcon
            // 
            TrayIcon.ContextMenuStrip = TrayIconContextMenu;
            TrayIcon.Text = "KeepMachineAwake";
            TrayIcon.Visible = true;
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;
            // 
            // TrayIconContextMenu
            // 
            TrayIconContextMenu.Items.AddRange(new ToolStripItem[] { TrayIconActive, toolStripSeparator1, TrayIconExit });
            TrayIconContextMenu.Name = "TrayIconContextMenu";
            TrayIconContextMenu.Size = new Size(108, 54);
            // 
            // TrayIconActive
            // 
            TrayIconActive.Name = "TrayIconActive";
            TrayIconActive.Size = new Size(107, 22);
            TrayIconActive.Text = "Active";
            TrayIconActive.Click += TrayIconActive_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(104, 6);
            // 
            // TrayIconExit
            // 
            TrayIconExit.Name = "TrayIconExit";
            TrayIconExit.Size = new Size(107, 22);
            TrayIconExit.Text = "Exit";
            TrayIconExit.Click += TrayIconCmExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "MainForm";
            ShowInTaskbar = false;
            Text = "MainForm";
            WindowState = FormWindowState.Minimized;
            Load += MainForm_Load;
            TrayIconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem TrayIconExit;
        private ToolStripMenuItem TrayIconActive;
        private ToolStripSeparator toolStripSeparator1;
    }
}
