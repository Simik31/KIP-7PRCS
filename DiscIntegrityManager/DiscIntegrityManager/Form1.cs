using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscIntegrityManager
{
    public partial class Form1 : Form
    {
        readonly List<string> exts = new List<string> { ".mkv", ".mp4", ".avi" };
        List<string> files = new List<string>();
        SortedDictionary<string, string> sumDict;
        long bytesProcessed;
        double per;
        int runingProcesses = 0;
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void GetFiles(string root, string searchPattern)
        {
            Stack<string> pending = new Stack<string>();
            pending.Push(root);
            while (pending.Count != 0)
            {
                var path = pending.Pop();
                List<string> next = new List<string>();
                try { next.AddRange(Directory.GetFiles(path, searchPattern)); }
                catch { }
                next.Where(f => exts.Contains(f.Substring(Math.Max(0, f.LastIndexOf("."))))).ToList().ForEach(f => files.Add(f));
                try { Directory.GetDirectories(path).ToList().ForEach(s => pending.Push(s)); }
                catch { }
            }
            pending.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new MethodInvoker(Prepare));

            sumDict = new SortedDictionary<string, string>();

            int coreCount = Environment.ProcessorCount;
            int packages = files.Count / coreCount + (files.Count % coreCount == 0 ? 0 : 1);

            List<List<string>> lists = new List<List<string>>();
            List<BackgroundWorker> workers = new List<BackgroundWorker>();
            for (int i = 0; i < packages; i++)
                lists.Add(new List<string>(files.GetRange(i * coreCount, ((i + 1) * coreCount > files.Count) ? files.Count - (i * coreCount) : coreCount)));
            files.Clear();

            for(int i = 0; i < coreCount; i++)
            { 
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += new DoWorkEventHandler(parallelWorker_DoWork);
                workers.Add(worker);
            }

            for (int i = 0; i < packages; i++)
            {
                for (int c = 0; c < lists[i].Count; c++)
                {
                    sumDict.Add(lists[i][c], null);
                    workers[c].RunWorkerAsync(lists[i][c]);
                }
                
                bool isBusy = true;

                while (isBusy)
                {
                    bool tmp = false;
                    foreach (BackgroundWorker worker in workers) tmp |= worker.IsBusy;
                    isBusy = tmp;
                }

                Invoke(new MethodInvoker(PrintData));
            }

            File.WriteAllLines(@"sums.md5", sumDict.Select(x => string.Format("{0} : {1}", x.Key, x.Value)).ToList());

            for (int i = 0; i < lists.Count; i++) lists[i].Clear();
            lists.Clear();
            workers.Clear();
            sumDict.Clear();
                        
            //backgroundWorker2.RunWorkerAsync();
        }

        private void parallelWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string f = e.Argument as string;
            runingProcesses++;
            sumDict[f] = BitConverter.ToString(MD5.Create().ComputeHash(File.ReadAllBytes(f))).Replace("-", "").ToLower();
            Debug.WriteLine("Count: " + sumDict.Count);
            bytesProcessed += new FileInfo(f).Length;
            runingProcesses--;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new MethodInvoker(Prepare));

            sumDict = new SortedDictionary<string, string>();

            Dictionary<string, string> fileSumDict = File.Exists(@"sums.md5") ? File.ReadAllLines(@"sums.md5").ToDictionary(l => l.Substring(0, l.IndexOf(" : ")), s => s.Substring(s.IndexOf(" : ") + 3)) : new Dictionary<string, string>();
            int coreCount = Environment.ProcessorCount;
            int packages = files.Count / coreCount + (files.Count % coreCount == 0 ? 0 : 1);

            List<List<string>> lists = new List<List<string>>();
            for (int i = 0; i < packages; i++)
                lists.Add(new List<string>(files.GetRange(i * coreCount, ((i + 1) * coreCount > files.Count) ? files.Count - (i * coreCount) : coreCount)));

            for (int i = 0; i < packages; i++)
            {
                Parallel.ForEach(lists[i], new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, f =>
                {
                    runingProcesses++;

                    if (fileSumDict.ContainsKey(f))
                    {
                        FileStream file = File.OpenRead(f);
                        if (fileSumDict[f] == BitConverter.ToString(MD5.Create().ComputeHash(new BufferedStream(file))).Replace("-", "").ToLower()) sumDict.Add(f, "OK");
                        else sumDict.Add(f, "FAILED");
                        file.Close();
                    }
                    else sumDict.Add(f, "MISSING");

                    bytesProcessed += new FileInfo(f).Length;

                    runingProcesses--;
                    return;
                });

                Invoke(new MethodInvoker(PrintData));
            }
        }

        private void Prepare()
        {
            if (files.Count == 0)
            {
                FolderBrowserDialog openFolder = new FolderBrowserDialog();
                openFolder.ShowDialog();

                GetFiles(openFolder.SelectedPath == "" ? "D:\\" : openFolder.SelectedPath, "*.*");
            }

            btnCheck.Enabled = false;
            btnGenerate.Enabled = false;

            bytesProcessed = 0;
            per = 0;

            lstFiles.Items.Clear();
            lstChecks.Items.Clear();

            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = files.Count;

            sw.Restart();
            sw.Start();

            timer1.Start();
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstChecks.SelectedIndex = lstFiles.SelectedIndex;
        }

        private void lstChecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFiles.SelectedIndex = lstChecks.SelectedIndex;
        }

        private void UpdateGui()
        {
            progressBar.Value = sumDict.Count;

            per = sumDict.Count * 100.0 / files.Count;

            lblPercent.Text = string.Format("{0} / {1} ({2, 5:##0.0}%)", sumDict.Count, files.Count, per); 
            lblSpeed.Text = string.Format("{0, 9:#,##0.000} MBps", bytesProcessed / (sw.ElapsedMilliseconds / 1000.0) / 1048576);
            lblTime.Text = string.Format("{0} / {1}", sw.Elapsed.ToString(@"hh\:mm\:ss"), new TimeSpan((long)(sw.ElapsedTicks * 100 / per)).ToString(@"hh\:mm\:ss"));
            lblTasks.Text = string.Format("{0}", runingProcesses);
        }

        private void PrintData()
        {
            lstFiles.Items.Clear();
            lstChecks.Items.Clear();

            Debug.WriteLine(sumDict.Count);

            lstFiles.Items.AddRange(sumDict.Keys.ToArray());
            lstChecks.Items.AddRange(sumDict.Values.ToArray());

            UpdateGui();
        }

        private void Done(object sender, RunWorkerCompletedEventArgs e)
        {
            Invoke(new MethodInvoker(Done_Reset));
        }

        private void Done_Reset()
        {
            timer1.Stop();
            progressBar.Value = 0;
            btnCheck.Enabled = true;
            btnGenerate.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(UpdateGui));
        }
    }
}
