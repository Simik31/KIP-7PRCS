using System;
using System.Drawing;
using System.Windows.Forms;

namespace SemaphoreLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblOrder.Text = "Dle vlastního uvážení...";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            semSemaphore.Mode = Semaphore.EMode.Off;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            semSemaphore.Mode = Semaphore.EMode.On;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            semSemaphore.OrderChanged += SemSemaphore_OrderChanged;
        }

        private void SemSemaphore_OrderChanged(Semaphore sender, Semaphore.EOrder order)
        {
            switch (order)
            {
                case Semaphore.EOrder.Go:
                    lblOrder.Text = "Jeď!";
                    lblOrder.ForeColor = Color.Green;
                    break;
                case Semaphore.EOrder.Stop:
                    lblOrder.Text = "Stůj!";
                    lblOrder.ForeColor = Color.Red;
                    break;
                case Semaphore.EOrder.Uncontrolled:
                    lblOrder.Text = "Dle vlastního uvážení...";
                    lblOrder.ForeColor = Color.Black;
                    break;
                default:
                    lblOrder.Text = "???";
                    lblOrder.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
