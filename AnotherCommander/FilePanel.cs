using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AnotherCommander
{
  public partial class FilePanel : UserControl
  {

    private string _currentFolder = "C:\\";
    public string CurrentFolder
    {
      get => _currentFolder;
      set
      {
        _currentFolder = value;
        RefreshFilesList();
      }
    }

    public FilePanel()
    {
      InitializeComponent();
      InitTvwFolders();
    }

    private const string PLACEHOLDER_NODE_TEXT = "--placeholder--";
    private const int DRIVE_IMAGE_INDEX = 0;
    private const int FOLDER_CLOSED_IMAGE_INDEX = 1;
    private const int FOLDER_OPENED_IMAGE_INDEX = 2;
    private const int FOLDER_ERROR_IMAGE_INDEX = 3;


    private void InitTvwFolders()
    {
      tvwFolders.Nodes.Clear();

      var drives = System.IO.DriveInfo.GetDrives();

      foreach (var drive in drives)
      {
        TreeNode driveNode = new TreeNode();
        driveNode.Text = drive.Name;
        driveNode.Tag = drive.Name;
        driveNode.ImageIndex = DRIVE_IMAGE_INDEX;
        driveNode.SelectedImageIndex = DRIVE_IMAGE_INDEX;

        driveNode.Nodes.Add(new TreeNode(PLACEHOLDER_NODE_TEXT));

        tvwFolders.Nodes.Add(driveNode);
      }
    }

    private void tvwFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
      TreeNode node = e.Node;

      if (node.Nodes.Count == 1 && node.Nodes[0].Text == PLACEHOLDER_NODE_TEXT)
      {
        node.Nodes.Clear();
        string path = node.Tag as string;

        try
        {
          var folders = System.IO.Directory.GetDirectories(path);
          foreach (var folder in folders)
          {
            TreeNode folderNode = new TreeNode();
            folderNode.Text = System.IO.Path.GetFileName(folder);
            folderNode.Tag = folder;
            folderNode.ImageIndex = FOLDER_CLOSED_IMAGE_INDEX;
            folderNode.SelectedImageIndex = FOLDER_CLOSED_IMAGE_INDEX;
            folderNode.Nodes.Add(new TreeNode(PLACEHOLDER_NODE_TEXT));

            node.Nodes.Add(folderNode);
          }
        }
        catch (Exception ex)
        {
          node.ImageIndex = FOLDER_ERROR_IMAGE_INDEX;
          node.SelectedImageIndex = FOLDER_ERROR_IMAGE_INDEX;
        }
      }
    }

    private void tvwFolders_AfterExpand(object sender, TreeViewEventArgs e)
    {
      TreeNode node = e.Node;

      if (node.ImageIndex != DRIVE_IMAGE_INDEX)
      {
        node.ImageIndex = FOLDER_OPENED_IMAGE_INDEX;
        node.SelectedImageIndex = FOLDER_OPENED_IMAGE_INDEX;
      }
    }

    private void tvwFolders_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      TreeNode node = e.Node;

      if (node.ImageIndex != DRIVE_IMAGE_INDEX)
      {
        node.ImageIndex = FOLDER_CLOSED_IMAGE_INDEX;
        node.SelectedImageIndex = FOLDER_CLOSED_IMAGE_INDEX;
      }
    }

    private void tvwFolders_AfterSelect(object sender, TreeViewEventArgs e)
    {
      TreeNode node = e.Node;

      string path = node.Tag as string;

      CurrentFolder = path;
    }

    private void RefreshFilesList()
    {
      lvwFiles.Items.Clear();

      var files = System.IO.Directory.GetFiles(CurrentFolder);
      foreach (var file in files)
      {
        ListViewItem fileItem = new ListViewItem();
        fileItem.Text = System.IO.Path.GetFileName(file);
        fileItem.Tag = file;

        EnsureImageListHasIconForFile(file);
        fileItem.ImageKey = GetExtensionKey(file);

        lvwFiles.Items.Add(fileItem);
      }
    }

    private void EnsureImageListHasIconForFile(string fileName)
    {
      string key = GetExtensionKey(fileName);
      if (imlFilesSmall.Images.ContainsKey(key) == false)
      {
        Icon iconForFile = Icon.ExtractAssociatedIcon(fileName);
        imlFilesSmall.Images.Add(key, iconForFile);
        imlFilesLarge.Images.Add(key, iconForFile);
      }
    }

    private string GetExtensionKey(string fileName)
    {
      return "." + System.IO.Path.GetExtension(fileName);
    }

    private void lvwFiles_ItemDrag(object sender, ItemDragEventArgs e)
    {
      List<string> selectedFiles = new List<string>();
      foreach (object selectedItem in lvwFiles.SelectedItems)
      {
        ListViewItem lwi = (ListViewItem)selectedItem;
        string path = lwi.Tag as string;
        selectedFiles.Add(path);
      }
      string[] selectedFilesArray = selectedFiles.ToArray();

      lvwFiles.DoDragDrop(selectedFilesArray, DragDropEffects.All);
    }

    private void lvwFiles_DragDrop(object sender, DragEventArgs e)
    {
      List<CopyRequest> requests = new List<CopyRequest>();

      string[] fileNames = (string[]) e.Data.GetData(typeof(string[]));

      foreach (string fileName in fileNames)
      {
        string sourceFileName = fileName;
        string targetFileName = System.IO.Path.Combine(
          this.CurrentFolder,
          System.IO.Path.GetFileName(fileName));

        CopyRequest request = new CopyRequest(sourceFileName, targetFileName);
        requests.Add(request);

        //if (System.IO.File.Exists(targetFileName))
        //{
        //  DialogResult dialogResult = MessageBox.Show(
        //    $"Soubor '{System.IO.Path.GetFileName(targetFileName)}' již existuje, chcete jej přepsat?",
        //    "Soubor existuje...",
        //    MessageBoxButtons.YesNo,
        //    MessageBoxIcon.Exclamation,
        //    MessageBoxDefaultButton.Button2);

        //  if (dialogResult == DialogResult.No)
        //    continue;
        //}

        //System.IO.File.Copy(sourceFileName, targetFileName);
      }
      //RefreshFilesList();

      if (OnCopyRequest != null)
        OnCopyRequest(this, requests);
    }

    public delegate void CopyRequestDelegate(object sender, List<CopyRequest> copyRequests);
    public event CopyRequestDelegate OnCopyRequest;

    private void lvwFiles_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(typeof(string[])))
        e.Effect = DragDropEffects.Copy;
    }

    private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lvwFiles.View = View.LargeIcon;
    }

    private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lvwFiles.View = View.SmallIcon;
    }

    private void listToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lvwFiles.View = View.List;
    }

    private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lvwFiles.View = View.Details;
    }
  }
}
