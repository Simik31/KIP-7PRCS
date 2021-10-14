using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AnotherCommander
{
  public partial class FrmCopyProgress : Form
  {
    private Stopwatch sw = new Stopwatch();
    private int lastUpdate;

    public FrmCopyProgress()
    {
      InitializeComponent();
    }

    public void Init(FileCopyWorker fileCopyWorker)
    {
      fileCopyWorker.OnFilesProgress += UpdateFilesProgress;
      fileCopyWorker.OnBytesProgress += UpdateBytesProgress;
      fileCopyWorker.OnCopyCompleted += CopyCompleted;

      sw.Start();
      lastUpdate = 0;
    }

    private void CopyCompleted()
    {
      sw.Stop();
      if (this.InvokeRequired)
      {
        this.Invoke(
          (Action)
          (
          () => CopyCompleted())
          );
        return;
      }

      this.Close();
    }

    private void UpdateFilesProgress(string filePath, double completedPart)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(
          (Action)
          (
          () => UpdateFilesProgress(filePath, completedPart))
          );
        return;
      }

      lblFolder.Text = Path.GetDirectoryName(filePath);
      lblFile.Text = Path.GetFileName(filePath);
      prgFiles.Value = (int)(completedPart * 100);
      prgBytes.Value = 0;
      sw.Restart();
    }

    private void UpdateBytesProgress(double completedPart)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(
          (Action)
          (
          () => UpdateBytesProgress(completedPart))
          );
        return;
      }
      int part = (int)(completedPart * 100);
      if (part > 0 && part != lastUpdate)
      {
        lastUpdate = part;
        lblTime.Text = new TimeSpan(sw.ElapsedTicks * (100 - part) / part).ToString(@"hh\:mm\:ss");
      }
      prgBytes.Value = part;
    }
  }
}
