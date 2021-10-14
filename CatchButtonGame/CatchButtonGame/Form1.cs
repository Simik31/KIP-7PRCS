using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchButtonGame
{
  public partial class Form1 : Form
  {
    private DateTime showTime;
    private bool isStarted = false;
    private TimeSpan bestTime = new TimeSpan(1, 0, 0);
    private TimeSpan worstTime;
        private List<TimeSpan> times = new List<TimeSpan>();
    
    // ukázka vytvoření listu:
    // private List<TimeSpan> previousResults = new List<TimeSpan>();
    // previousResults.Add(...)
    // foreach(TimeSpan ts in previousResults{...}

    // ukázka vytvoření pole:
    // private TimeSpan[] previousResultsArray = new TimeSpan[10];

    public Form1()
    {
      InitializeComponent();
    }

    private void btn_Click(object sender, EventArgs e)
    {
      HideButton(sender);
      if (this.isStarted)
        EvaluateTimeRequiredToClick();
      else { 
        this.isStarted = true;
        lblResult.Text = "Čeká se na první stisk tlačítka.";
      }
      ShowNewRandomButton();
    }

    private void EvaluateTimeRequiredToClick()
    {
      DateTime hideTime = DateTime.Now;
      TimeSpan delay = hideTime - this.showTime;
      times.Add(delay);
      lblResult.Text = string.Format("Aktuální čas: {0, 7:##0.000}s\nNejlepší čas: {1, 7:##0.000}s\nNejhorší čas: {2, 7:##0.000}s\nPrůměrný čas: {3, 7:##0.000}s", delay.TotalSeconds, times.Min().TotalSeconds, times.Max().TotalSeconds, new TimeSpan(Convert.ToInt64(times.Average(timeSpan => timeSpan.Ticks))).TotalSeconds);
    }

    private void ShowNewRandomButton()
    {
      Random random = new Random();
      int index = random.Next(9);
      Button btn;
      switch (index)
      {
        case 0:
          btn = btnA;
          break;
        case 1:
          btn = btnB;
          break;
        case 2:
          btn = btnC;
          break;
        case 3:
          btn = btnD;
          break;
        case 4:
          btn = btnE;
          break;
        case 5:
          btn = btnF;
          break;
        case 6:
            btn = btnG;
            break;
        case 7:
            btn = btnH;
            break;
        case 8:
            btn = btnI;
            break;
        default:
          throw new Exception("Nesprávná hodnota v index - " + index);
      }
      btn.Visible = true;
      this.showTime = DateTime.Now;
    }

    private void HideButton(object sender)
    {
      Button btn = (Button) sender;
      btn.Visible = false;
    }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
