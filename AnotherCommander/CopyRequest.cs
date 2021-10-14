using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherCommander
{
  public class CopyRequest
  {
    public string SourceFileName { get; private set; }
    public string TargetFileName { get; private set; }

    public CopyRequest(string sourceFileName, string targetFileName)
    {
      if (sourceFileName == null || sourceFileName.Length == 0)
        throw new ArgumentException("SourceFileName is invalid.");
      if (string.IsNullOrWhiteSpace(targetFileName))
        throw new ArgumentException("TargetFileName is invalid.");

      this.SourceFileName = sourceFileName;
      this.TargetFileName = targetFileName;
    }
  }
}
