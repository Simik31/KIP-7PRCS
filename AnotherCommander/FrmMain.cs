using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherCommander
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
      plnLeft.OnCopyRequest += FilePanel_OnCopyRequest;
      plnRight.OnCopyRequest += FilePanel_OnCopyRequest;
    }

    private FrmCopyOverview frmCopyOverview = null;

    private void FilePanel_OnCopyRequest(object sender, List<CopyRequest> copyRequests)
    {
      if (frmCopyOverview == null) { 
        frmCopyOverview = new FrmCopyOverview();        
      }

      frmCopyOverview.Add(copyRequests);
      frmCopyOverview.Show();
      frmCopyOverview.Focus();
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      //Application.Exit();
    }
  }
}
