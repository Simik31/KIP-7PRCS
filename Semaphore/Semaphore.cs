using System;
using System.Drawing;
using System.Windows.Forms;

namespace SemaphoreLib
{
    public partial class Semaphore : UserControl
    {
        public delegate void OnOrderChanged(Semaphore sender, EOrder order);
        public event OnOrderChanged OrderChanged;

        public  enum EOrder         { Stop, Go, Uncontrolled }
        public  enum EMode          { Off, On }
        private enum EBlinkingState { Off, Left, Right, White }
        private enum EOnState       { LeftRed, RightRed, White, None }

        private const float    LIGHT_BORDER_PERCENTAGE = 0.065f;
        private const int      RED_TO_WHITE_INTERVAL   = 10;
        private const int      WHITE_TO_RED_INTERVAL   = 15;
        private const int      WHITE_BLINK_INTERVAL    = 750;
        private const int      RED_BLINK_INTERVAL      = 1000;
        private       EMode    _Mode                   = EMode.Off;
        private       EOnState onState                 = EOnState.LeftRed;
        private       int      CYCLE_COUNTER           = 0;
        private       float    BOX_HEIGHT              = -1;
        private       float    LIGHT_RADIUS            = -1;
        private       Brush    BRUSH_BLACK             = new SolidBrush(Color.Black);
        private       Brush    BRUSH_RED               = new SolidBrush(Color.Red);
        private       Brush    BRUSH_WHITE             = new SolidBrush(Color.White);

        public EMode Mode
        {
            get => _Mode;
            set
            {
                _Mode = value;
                switch (value)
                {
                    case EMode.Off:
                        tmrTimer.Enabled = false;
                        OrderChanged?.Invoke(this, EOrder.Uncontrolled);
                        break;
                    case EMode.On:
                        onState = EOnState.LeftRed;
                        tmrTimer.Interval = RED_BLINK_INTERVAL;
                        CYCLE_COUNTER = 0;
                        tmrTimer.Enabled = true;
                        OrderChanged?.Invoke(this, EOrder.Stop);
                        break;
                }

                Invalidate();
                Update();
            }
        }

        public Semaphore()
        {
            InitializeComponent();
        }

        private void Semaphore_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (BOX_HEIGHT == -1) BOX_HEIGHT = graphics.VisibleClipBounds.Height / 2f;
            if (LIGHT_RADIUS == -1) LIGHT_RADIUS = BOX_HEIGHT * (1 - 2 * LIGHT_BORDER_PERCENTAGE);

            if (DesignMode)
            {
                DrawBackground(graphics);
                DrawLeftRed(graphics);
                DrawRightRed(graphics);
                DrawWhite(graphics);
            }
            else
            {
                switch (Mode)
                {
                    case EMode.Off:
                        DrawModeOff(graphics);
                        break;
                    case EMode.On:
                        DrawModeOn(graphics);
                        break;
                    default:
                        throw new Exception("Unknow semaphore mode " + Mode);
                }
            }
        }

        private void DrawModeOff(Graphics graphics)
        {
            DrawBackground(graphics);
        }

        private void DrawModeOn(Graphics graphics)
        {
            DrawBackground(graphics);

            switch (onState)
            {
                case EOnState.LeftRed:
                    DrawLeftRed(graphics);
                    break;
                case EOnState.RightRed:
                    DrawRightRed(graphics);
                    break;
                case EOnState.White:
                    DrawWhite(graphics);
                    break;
                case EOnState.None:
                    break;
                default:
                    throw new Exception("Illegal on-semaphore state  " + onState);
            }
        }

        private void DrawBackground(Graphics graphics)
        {
            graphics.FillRectangle(
                BRUSH_BLACK,
                graphics.VisibleClipBounds
            ) ;
        }

        private void DrawLeftRed(Graphics graphics)
        {
            graphics.FillEllipse(
                BRUSH_RED,
                new RectangleF(
                    graphics.VisibleClipBounds.Width / 4f - LIGHT_RADIUS / 2f,
                    BOX_HEIGHT * LIGHT_BORDER_PERCENTAGE,
                    LIGHT_RADIUS,
                    LIGHT_RADIUS
                )
            );
        }

        private void DrawRightRed(Graphics graphics)
        {
            graphics.FillEllipse(
                BRUSH_RED,
                new RectangleF(
                    graphics.VisibleClipBounds.Width / 4f * 3 - LIGHT_RADIUS / 2f,
                    BOX_HEIGHT * LIGHT_BORDER_PERCENTAGE, 
                    LIGHT_RADIUS, 
                    LIGHT_RADIUS
                )
            );
        }

        private void DrawWhite(Graphics graphics)
        {
            graphics.FillEllipse(
                BRUSH_WHITE,
                new RectangleF(
                    graphics.VisibleClipBounds.Width / 2f - LIGHT_RADIUS / 2f,
                    BOX_HEIGHT + BOX_HEIGHT * LIGHT_BORDER_PERCENTAGE,
                    LIGHT_RADIUS,
                    LIGHT_RADIUS
                )
            );
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Enabled = false;

            if(Mode == EMode.On)
            {
                CYCLE_COUNTER++;
                switch (onState)
                {
                    case EOnState.LeftRed:
                        if (CYCLE_COUNTER <= RED_TO_WHITE_INTERVAL)
                        {
                            onState = EOnState.RightRed;
                            tmrTimer.Interval = RED_BLINK_INTERVAL;
                            OrderChanged?.Invoke(this, EOrder.Stop);
                        }
                        else
                        {
                            CYCLE_COUNTER = 0;
                            onState = EOnState.White;
                            tmrTimer.Interval = WHITE_BLINK_INTERVAL;
                            OrderChanged?.Invoke(this, EOrder.Go);
                        }
                        break;
                    case EOnState.RightRed:
                        onState = EOnState.LeftRed;
                        tmrTimer.Interval = RED_BLINK_INTERVAL;
                        OrderChanged?.Invoke(this, EOrder.Stop);
                        break;
                    case EOnState.White:
                        onState = EOnState.None;
                        tmrTimer.Interval = WHITE_BLINK_INTERVAL;
                        OrderChanged?.Invoke(this, EOrder.Go);
                        break;
                    case EOnState.None:
                        if (CYCLE_COUNTER <= WHITE_TO_RED_INTERVAL)
                        {
                            onState = EOnState.White;
                            tmrTimer.Interval = WHITE_BLINK_INTERVAL;
                            OrderChanged?.Invoke(this, EOrder.Go);
                        }
                        else
                        {
                            CYCLE_COUNTER = 0;
                            onState = EOnState.LeftRed;
                            tmrTimer.Interval = RED_BLINK_INTERVAL;
                            OrderChanged?.Invoke(this, EOrder.Stop);
                        }
                        break;
                }
                tmrTimer.Enabled = true;
            }

            Invalidate();
            Update();
        }
    }
}