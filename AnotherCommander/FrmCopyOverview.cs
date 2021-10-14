using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AnotherCommander
{
  public partial class FrmCopyOverview : Form
  {
    public FrmCopyOverview()
    {
      InitializeComponent();
    }

    public void Add(List<CopyRequest> copyRequests)
    {
      copyRequests.ForEach(q => this.Add(q));
    }

    public void Add(CopyRequest copyRequest)
    {
      this.copyRequests.Add(copyRequest);
      this.RefreshListView();
    }

    private void RefreshListView()
    {
      this.lvwRequests.Items.Clear();

      foreach (CopyRequest request in this.copyRequests)
      {
        ListViewItem item = new ListViewItem();
        item.Text = Path.GetFileName(request.SourceFileName);

        item.SubItems.Add(GetFileSizeString(request.SourceFileName));
        item.SubItems.Add(request.SourceFileName);
        item.SubItems.Add(request.TargetFileName);

        this.lvwRequests.Items.Add(item);
      }
    }

    private string GetFileSizeString(string sourceFileName)
    {
      FileInfo fileInfo = new FileInfo(sourceFileName);
      long size = fileInfo.Length;
      string ret;

      if (size < 1024)
        ret = size + " B";
      else if (size < (1024 * 1024))
        ret = (size / 1024d).ToString("N3") + " kB";
      else if (size < (1024 * 1024 * 1024))
        ret = (size / 1024d / 1024d).ToString("N3") + " MB";
      else if (size < (1024 * 1024 * 1024 * 1024L))
        ret = (size / 1024d / 1024d / 1024d).ToString("N3") + " GB";
      else
        ret = (size / 1024d / 1024d / 1024d / 1024d).ToString("N3") + " TB";

      return ret;

    }

    private List<CopyRequest> copyRequests = new List<CopyRequest>();

    private void btnLater_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      var dialogResult = MessageBox.Show(
        this, "Opravdu chcete smazat frontu souborů ke kopírování?", "Smazat frontu?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

      if (dialogResult == DialogResult.Yes)
      {
        this.copyRequests.Clear();
        this.RefreshListView();
        this.Hide();
      }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      FileCopyWorker worker = new FileCopyWorker(this.copyRequests);
      FrmCopyProgress frmCopyProgress = new FrmCopyProgress();
      frmCopyProgress.Init(worker);
      frmCopyProgress.Show();

      Thread thread = new Thread(worker.Start);
      thread.Start();

      this.Hide();
    }
  }
}
