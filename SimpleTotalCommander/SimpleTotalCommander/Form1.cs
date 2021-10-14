using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleTotalCommander
{
    public partial class Form1 : Form
    {
        private readonly int[] byteDivisors = { 1024, 1000 };

        private Functions func;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            func = new Functions(cmbDrives, lstFolders, lstFiles, select_default_drive, pnlNavigate, historyBox, back, forward, delete_hisotry);
            ChangeByteDivisor(int.Parse(func.settings["View As"]));
            
            //backgroundWorker1.RunWorkerAsync();
        }

        public void ChangeByteDivisor(int newIndex)
        {
            func.byteDivisor = byteDivisors[newIndex];
            func.UpdateSettings("View As", newIndex);
            view_as_human.Checked = newIndex == 1;
            view_as_pc.Checked = newIndex == 0;
            func.RefreshDrives();
        }

        private void LstFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            func.OpenFile();
        }

        private void View_as_pc_Click(object sender, EventArgs e)
        {
            func.history.mode = 4;
            ChangeByteDivisor(0);
        }

        private void View_as_human_Click(object sender, EventArgs e)
        {
            func.history.mode = 4;
            ChangeByteDivisor(1);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs ev)
        {
            func.OpenFolder();
        }

        private void historyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            func.history.OpenFromHistory();
        }

        private void historyButtonBack_Click(object sender, EventArgs e)
        {
            func.history.HistoryBackByOne();
        }

        private void historyButtonForward_Click(object sender, EventArgs e)
        {
            func.history.ForwardHistory();
        }

        private void delete_hisotry_Click(object sender, EventArgs e)
        {
            func.history.ClearHistory();
        }

        private void cmbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            func.ChangeDrive();
        }

        private void lstFolders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            func.ChangeFolder();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true) if (!func.dli.Keys.SequenceEqual(DriveInfo.GetDrives().Select(d => d.Name).ToList())) Invoke(new MethodInvoker(delegate { func.RefreshDrives(); }));
        }
    }
}
