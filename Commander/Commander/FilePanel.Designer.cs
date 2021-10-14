namespace Commander
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
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.imgListFilesLarge = new System.Windows.Forms.ImageList(this.components);
            this.imgListFilesSmall = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(851, 727);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // tvwFolders
            // 
            this.tvwFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwFolders.ImageIndex = 0;
            this.tvwFolders.ImageList = this.imgList;
            this.tvwFolders.Location = new System.Drawing.Point(0, 0);
            this.tvwFolders.Name = "tvwFolders";
            this.tvwFolders.SelectedImageIndex = 0;
            this.tvwFolders.Size = new System.Drawing.Size(282, 727);
            this.tvwFolders.TabIndex = 0;
            this.tvwFolders.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwFolders_BeforeCollapse);
            this.tvwFolders.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwFolders_BeforeExpand);
            this.tvwFolders.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterExpand);
            this.tvwFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Hard-Disk-icon.png");
            this.imgList.Images.SetKeyName(1, "CD-icon.png");
            this.imgList.Images.SetKeyName(2, "Folder-Close-icon.png");
            this.imgList.Images.SetKeyName(3, "Folder-Open-icon.png");
            this.imgList.Images.SetKeyName(4, "Block-icon.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwFiles);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(565, 727);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // lvwFiles
            // 
            this.lvwFiles.AllowDrop = true;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.LargeImageList = this.imgListFilesLarge;
            this.lvwFiles.Location = new System.Drawing.Point(0, 0);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(565, 727);
            this.lvwFiles.SmallImageList = this.imgListFilesSmall;
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.List;
            this.lvwFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvwFiles_ItemDrag);
            this.lvwFiles.SelectedIndexChanged += new System.EventHandler(this.lvwFiles_SelectedIndexChanged);
            this.lvwFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragDrop);
            this.lvwFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvwFiles_DragEnter);
            // 
            // imgListFilesLarge
            // 
            this.imgListFilesLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListFilesLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imgListFilesLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListFilesSmall
            // 
            this.imgListFilesSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListFilesSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListFilesSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "FilePanel";
            this.Size = new System.Drawing.Size(851, 727);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvwFolders;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ImageList imgListFilesLarge;
        private System.Windows.Forms.ImageList imgListFilesSmall;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}
