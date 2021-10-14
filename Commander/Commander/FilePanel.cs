using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Commander
{
    public partial class FilePanel : UserControl
    {
        private const string NODE_PLACEHOLDER = "*_TREE_NODE_PLACEHOLDER_*";
        private readonly string SYSTEM_DRIVE = Environment.GetEnvironmentVariable("SystemDrive") + "\\";
        private const int LOCAL_DRIVE_ICON = 0;
        private const int EXTERNAL_DRIVE_ICON = 1;
        private const int CLOSED_FOLDER_ICON = 2;
        private const int OPENED_FOLDER_ICON = 3;
        private const int ERROR_ICON = 4;

        private readonly List<string> IMAGES = new List<string> { ".bmp", ".gif", ".jfif", ".jpg", ".jpeg", ".png" };

        private string _currentFolder;

        public string CurrentFolder
        {
            get => _currentFolder;
            set
            {
                _currentFolder = value;
                RefreshFileList();
            }
        }

        public FilePanel()
        {
            InitializeComponent();
            InitTvwFolders();
            CurrentFolder = SYSTEM_DRIVE;
        }

        private void InitTvwFolders()
        {
            tvwFolders.Nodes.Clear();

            var drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                int driveIcon = drive.DriveType == DriveType.Fixed ? LOCAL_DRIVE_ICON : EXTERNAL_DRIVE_ICON;
                TreeNode driveNode = new TreeNode { Text = drive.Name, Tag = drive.Name, ImageIndex = driveIcon, SelectedImageIndex = driveIcon };
                driveNode.Nodes.Add(new TreeNode(NODE_PLACEHOLDER));
                tvwFolders.Nodes.Add(driveNode);
            }
        }

        private void tvwFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;

            if(node.Nodes.Count == 1 && node.Nodes[0].Text == NODE_PLACEHOLDER)
            {
                node.Nodes.Clear();
                string path = node.Tag as string;
                try
                {
                    var folders = Directory.GetDirectories(path);

                    foreach (var folder in folders)
                    {
                        TreeNode folderNode = new TreeNode { Text = Path.GetFileName(folder), Tag = folder, ImageIndex = CLOSED_FOLDER_ICON, SelectedImageIndex = CLOSED_FOLDER_ICON };
                        folderNode.Nodes.Add(new TreeNode(NODE_PLACEHOLDER));
                        node.Nodes.Add(folderNode);
                    }
                }
                catch(Exception ignored)
                {
                    node.ImageIndex = ERROR_ICON;
                    node.SelectedImageIndex = ERROR_ICON;
                }
            }
        }

        private void tvwFolders_AfterExpand(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            if(node.ImageIndex == CLOSED_FOLDER_ICON)
            {
                node.ImageIndex = OPENED_FOLDER_ICON;
                node.SelectedImageIndex = OPENED_FOLDER_ICON;
            }
        }

        private void tvwFolders_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;

            if (node.ImageIndex == OPENED_FOLDER_ICON)
            {
                node.ImageIndex = CLOSED_FOLDER_ICON;
                node.SelectedImageIndex = CLOSED_FOLDER_ICON;
            }
        }

        private void tvwFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            e.Node.Expand();
            CurrentFolder = node.Tag as string;
        }

        private void RefreshFileList()
        {
            lvwFiles.Items.Clear();

            try
            {
                var files = Directory.GetFiles(CurrentFolder);

                foreach (var file in files)
                {
                    ListViewItem fileItem = new ListViewItem();
                    fileItem.Text = Path.GetFileName(file);
                    fileItem.Tag = file;

                    EnsureImageListHasIconFile(file);
                    fileItem.ImageKey = GetExtensionKey(file);

                    lvwFiles.Items.Add(fileItem);
                }
            }
            catch (Exception ignored)
            {
            }
        }

        private void EnsureImageListHasIconFile(string fileName)
        {
            string key = GetExtensionKey(fileName);
            if (!imgListFilesSmall.Images.ContainsKey(key))
            {
                Icon iconFile = Icon.ExtractAssociatedIcon(fileName);
                imgListFilesSmall.Images.Add(key, iconFile);
            }

            if (!imgListFilesLarge.Images.ContainsKey(key))
            {
                Icon iconFile = Icon.ExtractAssociatedIcon(fileName);
                imgListFilesLarge.Images.Add(key, iconFile);
            }
        }

        private string GetExtensionKey(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            if (!ext.StartsWith(".")) ext = "." + ext;
            return ext.ToLower();
        }

        private void lvwFiles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            List<string> selectedItems = new List<string>();

            foreach (object selectedItem in lvwFiles.SelectedItems)
            {
                ListViewItem lwi = selectedItem as ListViewItem;
                string path = lwi.Tag as string;
                selectedItems.Add(path);
            }

            string[] selectedItemsArray = selectedItems.ToArray();

            lvwFiles.DoDragDrop(selectedItemsArray, DragDropEffects.All);
        }

        private void lvwFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[]) e.Data.GetData(typeof(string[]));

            foreach (string fileName in fileNames)
            {
                string sourceFileName = fileName;
                string targetFileName = Path.Combine(CurrentFolder, Path.GetFileName(fileName));

                if(File.Exists(targetFileName))
                {
                    DialogResult dialogResult = MessageBox.Show(
                        $"File '{Path.GetFileName(targetFileName)}' already exists. Override with current file?",
                        "File already exists...",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2
                    );

                    if (dialogResult == DialogResult.No) continue;
                }

                File.Copy(sourceFileName, targetFileName);
            }

            RefreshFileList();
        }

        private void lvwFiles_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(string[])))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lvwFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control preview = null;

            if (lvwFiles.SelectedItems.Count == 1)
            {
                string selectedFile = lvwFiles.SelectedItems[0].Tag as string;
                string ext = GetExtensionKey(selectedFile);                

                if (IMAGES.Contains(ext)) preview = PreviewImage(selectedFile);
            }

            if (preview != null)
            {
                splitContainer2.Panel2.Controls.Clear();
                splitContainer2.Panel2.Controls.Add(preview);
                if (splitContainer2.Panel2Collapsed) splitContainer2.Panel2Collapsed = false;
            }
            else splitContainer2.Panel2Collapsed = true;
        }

        private Control PreviewImage(string selectedFile)
        {
            return new PictureBox {
                Image = Image.FromFile(selectedFile),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };
        }
        /*
        private Control PreviewText(string selectedFile)
        {
            return new TextBox {
                Text = File.ReadAllText(selectedFile),
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill
            };
        }*/
    }
}
