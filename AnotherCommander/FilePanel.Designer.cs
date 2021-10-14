namespace AnotherCommander
{
  partial class FilePanel
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePanel));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tvwFolders = new System.Windows.Forms.TreeView();
      this.imlFolders = new System.Windows.Forms.ImageList(this.components);
      this.lvwFiles = new System.Windows.Forms.ListView();
      this.imlFilesLarge = new System.Windows.Forms.ImageList(this.components);
      this.imlFilesSmall = new System.Windows.Forms.ImageList(this.components);
      this.cmsLstFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.displayModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.cmsLstFiles.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tvwFolders);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.lvwFiles);
      this.splitContainer1.Size = new System.Drawing.Size(681, 657);
      this.splitContainer1.SplitterDistance = 239;
      this.splitContainer1.TabIndex = 0;
      // 
      // tvwFolders
      // 
      this.tvwFolders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tvwFolders.ImageIndex = 0;
      this.tvwFolders.ImageList = this.imlFolders;
      this.tvwFolders.Location = new System.Drawing.Point(0, 0);
      this.tvwFolders.Name = "tvwFolders";
      this.tvwFolders.SelectedImageIndex = 0;
      this.tvwFolders.Size = new System.Drawing.Size(239, 657);
      this.tvwFolders.TabIndex = 0;
      this.tvwFolders.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterCollapse);
      this.tvwFolders.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwFolders_BeforeExpand);
      this.tvwFolders.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterExpand);
      this.tvwFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterSelect);
      // 
      // imlFolders
      // 
      this.imlFolders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFolders.ImageStream")));
      this.imlFolders.TransparentColor = System.Drawing.Color.Transparent;
      this.imlFolders.Images.SetKeyName(0, "drive.png");
      this.imlFolders.Images.SetKeyName(1, "folder-closed.png");
      this.imlFolders.Images.SetKeyName(2, "folder-open.png");
      this.imlFolders.Images.SetKeyName(3, "folder-error.png");
      // 
      // lvwFiles
      // 
      this.lvwFiles.AllowDrop = true;
      this.lvwFiles.ContextMenuStrip = this.cmsLstFiles;
      this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvwFiles.HideSelection = false;
      this.lvwFiles.LargeImageList = this.imlFilesLarge;
      this.lvwFiles.Location = new System.Drawing.Point(0, 0);
      this.lvwFiles.Name = "lvwFiles";
      this.lvwFiles.Size = new System.Drawing.Size(438, 657);
      this.lvwFiles.SmallImageList = this.imlFilesSmall;
      this.lvwFiles.TabIndex = 0;
      this.lvwFiles.UseCompatibleStateImageBehavior = false;
      this.lvwFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvwFiles_ItemDrag);
      this.lvwFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragDrop);
      this.lvwFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragEnter);
      // 
      // imlFilesLarge
      // 
      this.imlFilesLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.imlFilesLarge.ImageSize = new System.Drawing.Size(32, 32);
      this.imlFilesLarge.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // imlFilesSmall
      // 
      this.imlFilesSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.imlFilesSmall.ImageSize = new System.Drawing.Size(16, 16);
      this.imlFilesSmall.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // cmsLstFiles
      // 
      this.cmsLstFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayModeToolStripMenuItem});
      this.cmsLstFiles.Name = "cmsLstFiles";
      this.cmsLstFiles.Size = new System.Drawing.Size(147, 26);
      // 
      // displayModeToolStripMenuItem
      // 
      this.displayModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem});
      this.displayModeToolStripMenuItem.Name = "displayModeToolStripMenuItem";
      this.displayModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.displayModeToolStripMenuItem.Text = "Display mode";
      // 
      // largeIconToolStripMenuItem
      // 
      this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
      this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.largeIconToolStripMenuItem.Text = "Large Icon";
      this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
      // 
      // smallIconToolStripMenuItem
      // 
      this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
      this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.smallIconToolStripMenuItem.Text = "Small Icon";
      this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
      // 
      // listToolStripMenuItem
      // 
      this.listToolStripMenuItem.Name = "listToolStripMenuItem";
      this.listToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.listToolStripMenuItem.Text = "List";
      this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
      // 
      // detailsToolStripMenuItem
      // 
      this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
      this.detailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.detailsToolStripMenuItem.Text = "Details";
      this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
      // 
      // FilePanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "FilePanel";
      this.Size = new System.Drawing.Size(681, 657);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.cmsLstFiles.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView tvwFolders;
    private System.Windows.Forms.ImageList imlFolders;
    private System.Windows.Forms.ListView lvwFiles;
    private System.Windows.Forms.ImageList imlFilesLarge;
    private System.Windows.Forms.ImageList imlFilesSmall;
    private System.Windows.Forms.ContextMenuStrip cmsLstFiles;
    private System.Windows.Forms.ToolStripMenuItem displayModeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
  }
}
