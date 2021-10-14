using System.Windows.Forms;

namespace SimpleTotalCommander
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.ComboBox();
            this.pnlNavigate = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_as_pc = new System.Windows.Forms.ToolStripMenuItem();
            this.view_as_human = new System.Windows.Forms.ToolStripMenuItem();
            this.open_folder = new System.Windows.Forms.ToolStripButton();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_hisotry = new System.Windows.Forms.ToolStripMenuItem();
            this.select_default_drive = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstFolders);
            this.splitContainer1.Panel1.Controls.Add(this.cmbDrives);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstFiles);
            this.splitContainer1.Size = new System.Drawing.Size(1487, 884);
            this.splitContainer1.SplitterDistance = 738;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // lstFolders
            // 
            this.lstFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.IntegralHeight = false;
            this.lstFolders.ItemHeight = 24;
            this.lstFolders.Location = new System.Drawing.Point(0, 0);
            this.lstFolders.Margin = new System.Windows.Forms.Padding(4);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(738, 852);
            this.lstFolders.TabIndex = 1;
            this.lstFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFolders_MouseDoubleClick);
            // 
            // cmbDrives
            // 
            this.cmbDrives.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(0, 852);
            this.cmbDrives.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(738, 32);
            this.cmbDrives.TabIndex = 0;
            this.cmbDrives.SelectedIndexChanged += new System.EventHandler(this.cmbDrives_SelectedIndexChanged);
            // 
            // lstFiles
            // 
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.IntegralHeight = false;
            this.lstFiles.ItemHeight = 24;
            this.lstFiles.Location = new System.Drawing.Point(0, 0);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(4);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(741, 884);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstFiles_MouseDoubleClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.splitContainer2);
            this.pnlTop.Controls.Add(this.pnlNavigate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 24);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1487, 28);
            this.pnlTop.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(745, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.forward);
            this.splitContainer2.Panel1.Controls.Add(this.back);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.historyBox);
            this.splitContainer2.Size = new System.Drawing.Size(742, 28);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.TabIndex = 2;
            // 
            // forward
            // 
            this.forward.Dock = System.Windows.Forms.DockStyle.Right;
            this.forward.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.forward.Location = new System.Drawing.Point(41, 0);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(39, 28);
            this.forward.TabIndex = 1;
            this.forward.Text = "→";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.historyButtonForward_Click);
            // 
            // back
            // 
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(39, 28);
            this.back.TabIndex = 0;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.historyButtonBack_Click);
            // 
            // historyBox
            // 
            this.historyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.historyBox.FormattingEnabled = true;
            this.historyBox.ItemHeight = 24;
            this.historyBox.Location = new System.Drawing.Point(0, 0);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(658, 32);
            this.historyBox.TabIndex = 1;
            this.historyBox.SelectedIndexChanged += new System.EventHandler(this.historyBox_SelectedIndexChanged);
            // 
            // pnlNavigate
            // 
            this.pnlNavigate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigate.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigate.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavigate.Name = "pnlNavigate";
            this.pnlNavigate.Size = new System.Drawing.Size(738, 28);
            this.pnlNavigate.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.open_folder,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1487, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_as_pc,
            this.view_as_human});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // view_as_pc
            // 
            this.view_as_pc.Name = "view_as_pc";
            this.view_as_pc.Size = new System.Drawing.Size(219, 22);
            this.view_as_pc.Text = "As Computer (1kB = 1024B)";
            this.view_as_pc.Click += new System.EventHandler(this.View_as_pc_Click);
            // 
            // view_as_human
            // 
            this.view_as_human.Name = "view_as_human";
            this.view_as_human.Size = new System.Drawing.Size(219, 22);
            this.view_as_human.Text = "As Human (1kB = 1000B)";
            this.view_as_human.Click += new System.EventHandler(this.View_as_human_Click);
            // 
            // open_folder
            // 
            this.open_folder.Name = "open_folder";
            this.open_folder.Size = new System.Drawing.Size(76, 21);
            this.open_folder.Text = "Open Folder";
            this.open_folder.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_hisotry,
            this.select_default_drive});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // delete_hisotry
            // 
            this.delete_hisotry.Name = "delete_hisotry";
            this.delete_hisotry.Size = new System.Drawing.Size(176, 22);
            this.delete_hisotry.Text = "Clear Hisotry";
            this.delete_hisotry.Click += new System.EventHandler(this.delete_hisotry_Click);
            // 
            // select_default_drive
            // 
            this.select_default_drive.Name = "select_default_drive";
            this.select_default_drive.Size = new System.Drawing.Size(176, 22);
            this.select_default_drive.Text = "Select Default Drive";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 936);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Total Commander Clone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel pnlNavigate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_as_pc;
        private System.Windows.Forms.ToolStripMenuItem view_as_human;
        private System.Windows.Forms.ToolStripButton open_folder;
        private ComboBox historyBox;
        private SplitContainer splitContainer2;
        private Button back;
        private Button forward;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem delete_hisotry;
        private ToolStripMenuItem select_default_drive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

