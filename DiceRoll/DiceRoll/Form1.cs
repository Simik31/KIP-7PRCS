using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {
        #region variables
        private readonly List<TextBox> labels;
        private List<Dice> history;
        private readonly List<int> rolled_counter;
        private float counter;
        private int previous_roll;
        #endregion

        #region constructors
        public Form1()
        {
            InitializeComponent();
            labels = new List<TextBox> { Label1, Label2, Label3, Label4, Label5, Label6 };
            history = new List<Dice> { history0, history1, history2, history3, history4, history5 };
            rolled_counter = new List<int> { 0, 0, 0, 0, 0, 0 };
            foreach (Dice d in history)
                d.Value = 0;
            counter = 0;
            previous_roll = -1;
            dice1.DiceDotSpacing = 0.025f;
            UpdateLabels(-1);
        }
        #endregion

        #region methods
        private void Dice1_Load(object sender, EventArgs e)
        {
            dice1.Value = 0;
            dice1.Rolled += Dice_Rolled;
        }

        private void Dice_Rolled(Dice sender)
        {
            rolled_counter[sender.Value - 1]++;
            counter++;
            UpdateLabels(sender.Value);
        }

        private void BtnRoll_Click(object sender, MouseEventArgs e)
        {
            dice1.Roll();
        }

        private void UpdateLabels(int roll)
        {
            if (previous_roll != -1)
            {
                for (int i = history.Count - 1; i > 0; i--)
                    history[i].Value = history[i - 1].Value;
                history[0].Value = previous_roll;
            }
            previous_roll = roll;
            for (int i = 0; i < 6; i++)
                labels[i].Text = string.Format("{0, 6:##,##0} ({1, 8:##0.000%})", rolled_counter[i], rolled_counter[i] / (counter > 0 ? counter : 1));
        }
        #endregion
    }
}