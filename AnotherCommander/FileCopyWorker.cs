using System.Collections.Generic;
using System.IO;

namespace AnotherCommander
{
  public class FileCopyWorker
  {
    private List<CopyRequest> requests;

    public delegate void OnFilesProgressDelegate(string filePath, double completedPart);
    public event OnFilesProgressDelegate OnFilesProgress;
    public delegate void OnBytesProgressDelegate(double completedPart);
    public event OnBytesProgressDelegate OnBytesProgress;
    public delegate void OnCopyCompletedDelegate ();
    public event OnCopyCompletedDelegate OnCopyCompleted;

    public FileCopyWorker(List<CopyRequest> requests)
    {
      this.requests = requests;
    }

    public void Start()
    {
      CopyFiles(requests);

      if (OnCopyCompleted != null)
        OnCopyCompleted();
    }

    private void CopyFiles(List<CopyRequest> requests)
    {
      int counter = 0;
      foreach (CopyRequest request in requests)
      {
        if (OnFilesProgress != null)
          OnFilesProgress(request.SourceFileName, counter / (double)requests.Count);
        CopyFile(request);
        counter++;
      }
    }

    private void CopyFile(CopyRequest request)
    {
      FileStream sourceFileStream = new FileStream(request.SourceFileName, FileMode.Open);
      FileStream targetFileStream = new FileStream(request.TargetFileName, FileMode.Create);

      byte[] data = new byte[1024];
      int count = 0;
      long lengthBytes = new FileInfo(request.SourceFileName).Length;
      long processedBytes = 0;
      while (true)
      {
        count = sourceFileStream.Read(data, 0, data.Length);
        if (count == 0) break;
        targetFileStream.Write(data, 0, count);

        processedBytes += count;
        if (this.OnBytesProgress != null)
          this.OnBytesProgress(processedBytes / (double) lengthBytes);
      }

      sourceFileStream.Close();
      targetFileStream.Close();
    }
  }
}
