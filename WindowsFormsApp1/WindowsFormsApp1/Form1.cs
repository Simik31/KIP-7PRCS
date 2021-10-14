using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        private List<Button> blocks = new List<Button>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = ImageProvider.GetRandomImage();
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.CoverImageByBlocks();
        }

        private const int BLOCK_SIDE_SIZE = 50;

        private void CoverImageByBlocks()
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            int counter = 1;

            for(int x = 0; x <= formWidth - BLOCK_SIDE_SIZE; x += BLOCK_SIDE_SIZE)
            { 
                for (int y = 0; y <= formHeight - BLOCK_SIDE_SIZE; y += BLOCK_SIDE_SIZE) 
                {
                    Button btn = CreateNewBlock(x, y, counter++);
                    this.Controls.Add(btn);
                    blocks.Add(btn);
                }
            }
        }

        private Button CreateNewBlock(int x, int y, int counter)
        {
            Button btn = new Button
            {
                Text = counter.ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(x, y),
                Size = new Size(BLOCK_SIDE_SIZE, BLOCK_SIDE_SIZE),
                Margin = new Padding(0),
                Padding = new Padding(0),
                Visible = true
            };

            btn.Click += btn_Click;

            return btn;
        }

        private void btn_Click(Object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
            HideAllBlocks();
        }

        private void HideAllBlocks()
        {
            this.blocks.ForEach(q => q.Visible = false);
        }
    }
}
