using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Dice : UserControl
    {
        #region delegates, events
        public delegate void OnRolled(Dice sender);
        public event OnRolled Rolled;
        #endregion

        #region enums
        public enum EState { disabled, one, two, three, four, five, six, DesigMode }
        #endregion

        #region variables
        private List<bool> map;
        private readonly List<float> dotX;
        private readonly List<float> dotY;
        private float dotSpacing;
        private float dotDiameter;
        private EState innerState;
        private Graphics diceGraphics;
        #endregion

        #region get, set
        public EState State
        {
            get => innerState;
            set
            {
                innerState = value;
                Invalidate();
            }
        }

        public int Value
        {
            set => State = (EState)value;
            get => (int)innerState;
        }

        public float DiceDotSpacing
        {
            get => dotSpacing;
            set => dotSpacing = value;
        }
        #endregion

        #region constructors
        public Dice()
        {
            InitializeComponent();
            map = new List<bool>();
            dotX = new List<float>();
            dotY = new List<float>();
            DiceDotSpacing = 0.03f;
            dotDiameter = -1;
        }
        #endregion

        #region Event methods
        private void Dice_Load(object sender, EventArgs e)
        {
            diceGraphics = CreateGraphics();
            CalculateDimensions();
        }

        private void Dice_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode) innerState = EState.DesigMode;
            DrawNumber(Value);
        }
        #endregion

        #region methods
        private void CalculateDimensions()
        {
            float size = diceGraphics.VisibleClipBounds.Width;
            dotDiameter = size / 3 * (1 - 4 * dotSpacing);
            float sds = size * dotSpacing;

            for (int i = 0; i < 3; i++)
            {
                dotX.Add(sds);
                dotY.Add(i * dotDiameter + (i + 1) * sds);
            }
            dotX.Add(dotDiameter + 2 * sds);
            dotY.Add(dotDiameter + 2 * sds);
            for (int i = 0; i < 3; i++)
            {
                dotX.Add(2 * dotDiameter + 3 * sds);
                dotY.Add(i * dotDiameter + (i + 1) * sds);
            }
        }

        private void DrawNumber(int value)
        {
            Clear();
            if (innerState != EState.disabled)
            {
                map = new List<bool>() { value != 1, value >= 6, value > 3, value % 2 == 1, value > 3, value >= 6, value != 1 };
                for (int i = 0; i < map.Count(); i++)
                    if (map[i]) diceGraphics.FillEllipse(new SolidBrush(Color.Black), new RectangleF(dotX[i], dotY[i], dotDiameter, dotDiameter));
            }
        }

        private void Clear()
        {
            diceGraphics.FillRectangle(new SolidBrush(Color.White), diceGraphics.VisibleClipBounds);
        }

        public void Roll()
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(7) + 9; i++)
            {
                Value = rand.Next(6) + 1;
                DrawNumber(Value);
                Thread.Sleep(75);
            }
            Rolled?.Invoke(this);
        }
        #endregion
    }
}