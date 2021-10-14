using System.IO;
using System.Windows.Forms;

namespace SimpleTotalCommander
{
    class History
    {
        private ComboBox historyBox;
        private Button back;
        private Button forward;
        private ToolStripMenuItem delete_history;
        private Functions func;

        public int mode { get; set; }

        public History(ComboBox _historyBox, Button _historyButtonBack, Button _historyButtonForward, ToolStripMenuItem _delete_history, Functions _func)
        {
            historyBox = _historyBox;
            back = _historyButtonBack;
            forward = _historyButtonForward;
            delete_history = _delete_history;
            mode = 0;
            func = _func;
        }

        public void Add()
        {
            if (mode == 0)
            {
                while (historyBox.SelectedIndex > 0) historyBox.Items.RemoveAt(0);
                historyBox.Items.Insert(0, func.currentFolder);
                historyBox.SelectedIndex = 0;
            }
            else
            {
                if (mode == 2) historyBox.SelectedIndex++;
                else if (mode == 3) historyBox.SelectedIndex--;
                mode = 0;
            }

            if (historyBox.SelectedIndex < historyBox.Items.Count - 1) back.Enabled = true;
            else back.Enabled = false;

            if (historyBox.SelectedIndex > 0) forward.Enabled = true;
            else forward.Enabled = false;

            delete_history.Enabled = historyBox.Items.Count > 1;
        }

        public void HistoryBackByOne()
        {
            if (historyBox.Items.Count > 1)
            {
                mode = 2;
                historyBox.SelectedIndex++;
            }
            else
            {
                func.currentFolder = Path.GetDirectoryName(func.currentFolder);
                func.RefreshFolders();
            }
        }

        public void ForwardHistory()
        {
            mode = 3;
            historyBox.SelectedIndex--;
        }

        public void OpenFromHistory()
        {
            string folder = historyBox.SelectedItem.ToString();
            if (func.currentFolder != folder)
            {
                mode = 1;
                func.OpenFolderFromString(folder);
            }
        }

        public void ClearHistory()
        {
            historyBox.Items.Clear();
            Add();
        }
    }
}
