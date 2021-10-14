using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SimpleTotalCommander
{
    class Functions
    {
        private ComboBox cmbDrives;
        private ListBox lstFolders;
        private ListBox lstFiles;
        private ComboBox historyBox;
        private FlowLayoutPanel pnlNavigate;
        private ToolStripMenuItem select_default_drive;
        
        public Dictionary<string, int> dli { get; }
        public Dictionary<string, string> settings { get; }
        public History history { get; }

        readonly private string[] ex = { "B", "kB", "MB", "GB", "TB", "PT", "EB" };
        private string defaultDrive;

        public string currentFolder { get; set; }
        public int byteDivisor { get; set; }

        public Functions(ComboBox _cmbDrives, ListBox _lstFolders, ListBox _lstFiles, ToolStripMenuItem _select_default_drive, FlowLayoutPanel _pnlNavigate, ComboBox _historyBox, Button historyButtonBack, Button historyButtonForward, ToolStripMenuItem _delete_history)
        {
            history = new History(_historyBox, historyButtonBack, historyButtonForward, _delete_history, this);
            settings = Settings.LoadSettings();
            dli = new Dictionary<string, int>();
            cmbDrives = _cmbDrives;
            lstFolders = _lstFolders;
            lstFiles = _lstFiles;
            pnlNavigate = _pnlNavigate;
            historyBox = _historyBox;
            select_default_drive = _select_default_drive;
            defaultDrive = settings["Default Drive"];
        }

        public void RefreshDrives()
        {
            int prevIndex = cmbDrives.SelectedIndex;

            dli.Clear();
            cmbDrives.Items.Clear();

            int i = 0;
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<ToolStripItem> drivesToSelect = new List<ToolStripItem>();
            foreach (DriveInfo drive in drives)
            {
                double total = drive.TotalSize;
                double used = total - drive.AvailableFreeSpace;
                int counter = 0;
                while (total > byteDivisor)
                {
                    total /= byteDivisor;
                    used /= byteDivisor;
                    counter++;
                }

                cmbDrives.Items.Add(string.Format("{0} [{1}, {2}] Used: {3:#,##0.00}/{4:#,##0.00}{5} ({6:##0.00}%)",
                    drive.Name, drive.VolumeLabel, drive.DriveType, used, total, ex[counter], used * 100 / total));
                dli.Add(drive.Name, i++);

                if (drive.DriveType == DriveType.Fixed)
                {
                    ToolStripMenuItem driveDropMenu = new ToolStripMenuItem { Name = drive.Name, Text = drive.Name, Checked = (drive.Name == defaultDrive) };
                    driveDropMenu.Click += new EventHandler(select_Drive);
                    drivesToSelect.Add(driveDropMenu);
                }
            }

            select_default_drive.DropDownItems.Clear();
            select_default_drive.DropDownItems.AddRange(drivesToSelect.ToArray());
            cmbDrives.SelectedIndex = prevIndex == -1 ? dli[defaultDrive] : prevIndex;
        }

        private void select_Drive(object sender, EventArgs e)
        {
            string newDefaultDrive = (sender as ToolStripMenuItem).Name;
            UpdateSettings("Default Drive", newDefaultDrive);
            defaultDrive = newDefaultDrive;
            foreach(ToolStripMenuItem drive in select_default_drive.DropDownItems) drive.Checked = (drive.Name == defaultDrive);
        }

        public void ChangeDrive()
        {
            string driveLetter = ((string)cmbDrives.SelectedItem).Substring(0, 3);
            if (driveLetter == null) cmbDrives.SelectedIndex = dli[defaultDrive];
            else if (currentFolder == null || currentFolder.Substring(0, 3) != driveLetter) currentFolder = driveLetter;
            RefreshFolders();
        }

        public void ChangeFolder()
        {
            string folder = (string)lstFolders.SelectedItem;
            if (folder != null)
            {
                if (folder == "..")
                {
                    string parrent = Path.GetDirectoryName(currentFolder);
                    if (historyBox.Items.Contains(parrent)) historyBox.SelectedIndex = historyBox.Items.IndexOf(parrent);
                    else
                    {
                        currentFolder = parrent;
                        RefreshFolders();
                    }
                }
                else
                {
                    currentFolder = Path.Combine(currentFolder, folder);
                    RefreshFolders();
                }
            }
        }

        public void RefreshFolders()
        {
            if (!CheckFolderPermissions(currentFolder))
            {
                currentFolder = Path.GetDirectoryName(currentFolder);
                history.OpenFromHistory();
            }
            else
            {
                if ((currentFolder.Length > 3) && (currentFolder.Substring(3, 1) == " " || currentFolder.Substring(3, 2) == "..")) currentFolder = currentFolder.Substring(0, 3);

                history.Add();

                lstFolders.Items.Clear();

                string[] folders;
                folders = Directory.GetDirectories(currentFolder);
                if (currentFolder.Length > 3) lstFolders.Items.Add("..");
                foreach (string folder in folders) if (!Path.GetFileName(folder).StartsWith("$")) lstFolders.Items.Add(Path.GetFileName(folder));

                string[] files = Directory.GetFiles(currentFolder);
                lstFiles.Items.Clear();
                foreach (string file in files) lstFiles.Items.Add(Path.GetFileName(file));

                pnlNavigate.Controls.Clear();
                string[] parts = currentFolder.Split('\\');
                string relativePath = null;
                foreach (string part in parts)
                {
                    if (part.Length > 0)
                    {
                        relativePath = relativePath == null ? part + "\\" : Path.Combine(relativePath, part);
                        Label lbl = new Label { Text = part + "\\", AutoSize = true, Tag = relativePath, Margin = new Padding(0) };
                        lbl.MouseClick += NavigatingLabel_Click;
                        pnlNavigate.Controls.Add(lbl);
                    }
                }
            }
        }

        private void NavigatingLabel_Click(object sender, EventArgs e)
        {
            string folder = (sender as Label).Tag.ToString();
            if (historyBox.Items.Contains(folder)) historyBox.SelectedIndex = historyBox.Items.IndexOf(folder);
            else
            {
                currentFolder = folder;
                RefreshFolders();
            }
        }

        private bool CheckFolderPermissions(string folderPath)
        {
            try
            {
                Directory.GetAccessControl(folderPath);
                Directory.GetDirectories(folderPath);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                Form error = new Form()
                {
                    Font = new Font("Consolas", 12.00F),
                    Width = 200,
                    Height = 110,
                    ControlBox = false,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = "Access denied!",
                    StartPosition = FormStartPosition.CenterParent
                };
                Label msg = new Label() { Height = 30, Width = 184, Text = "Access denied!", TextAlign = ContentAlignment.MiddleCenter };
                Button confirmation = new Button() { Text = "OK", Left = 45, Height = 30, Width = 100, Top = 35, DialogResult = DialogResult.OK };
                confirmation.Click += (s, e) => { error.Close(); };
                error.Load += ErrorForm_load;
                error.Controls.Add(msg);
                error.Controls.Add(confirmation);
                error.AcceptButton = confirmation;
                error.ShowDialog();
                return false;
            }
        }

        private void ErrorForm_load(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        public void OpenFolderFromString(string openFolder)
        {
            if (currentFolder != openFolder)
            {
                int currentIndex = cmbDrives.SelectedIndex;
                int driveIndex = dli[currentFolder.Substring(0, 3)];
                if (dli.ContainsKey(openFolder.Substring(0, 3).ToUpper())) currentFolder = openFolder.Substring(0, 1).ToUpper() + openFolder.Substring(1);
                else currentFolder = Path.Combine(currentFolder, openFolder);
                cmbDrives.SelectedIndex = driveIndex;
                if (driveIndex == currentIndex) RefreshFolders();
            }
        }

        public void OpenFolder()
        {
            Form prompt = new Form()
            {
                Font = new Font("Consolas", 12.00F),
                Width = 400,
                Height = 75,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen
            };

            TextBox textBox = new TextBox() { Left = 4, Top = 8, Height = 20, Width = 390, Text = currentFolder };
            Button open = new Button() { Text = "OPEN", Left = 80, Height = 30, Width = 100, Top = 38, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "CANCEL", Left = 220, Height = 30, Width = 100, Top = 38, DialogResult = DialogResult.Cancel };
            open.Click += (s, e) => { prompt.Close(); };
            cancel.Click += (s, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(open);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = open;
            prompt.CancelButton = cancel;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (textBox.Text.Length > 0) OpenFolderFromString(textBox.Text);
                else OpenFolder();
            }
        }

        public void OpenFile()
        {
            Process.Start(Path.Combine(currentFolder, lstFiles.SelectedItem as string)); 
        }

        public void UpdateSettings(string var, object val)
        {
            settings[var] = val.ToString();
            Settings.UpdateSettings(settings);
        }
    }
}
