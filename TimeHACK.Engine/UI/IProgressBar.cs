using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.UI
{
    public class ProgressBar : Control
    {
        private Color _pColor = Color.DarkBlue;
        private ProgressBarStyle _style = ProgressBarStyle.Continuous;

        private Timer RedrawTimer = null;

        public Color ProgressColor
        {
            get
            {
                return _pColor;
            }
            set
            {
                _pColor = value; Refresh();
            }
        }


        public ProgressBarStyle Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value; Refresh();
            }
        }


        private double _max = 100.0;
        private double _min = 0.0;

        public double Maximum
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value; Refresh();
            }
        }
        public double Minimum
        {
            get
            {
                return _min;
            }
            set
            {
                _min = value; Refresh();
            }
        }


        private int _blockWidth = 14;

        public int BlockWidth
        {
            get
            {
                return _blockWidth;
            }
            set
            {
                _blockWidth = value;
                Refresh();
            }
        }

        private int _blockSpacing = 2;

        public int BlockSpacing
        {
            get
            {
                return _blockSpacing;
            }
            set
            {
                _blockSpacing = value;
                Refresh();
            }
        }

        public ProgressBar() : base()
        {
            MarqueeWidth = 125;
            BlockWidth = 20;
            BlockSpacing = 5;
            Minimum = 0.00;
            Maximum = 100.0;
            Style = ProgressBarStyle.Continuous;
            ProgressColor = Color.DarkBlue;
            RedrawTimer = new Timer();
            RedrawTimer.Tick += (o, a) =>
            {
                if (this.Style == ProgressBarStyle.Marquee)
                {
                    if (_marqueePos >= this.Width)
                        _marqueePos = 0;
                    else
                        _marqueePos++;
                    this.Refresh();
                }
            };
            RedrawTimer.Interval = 50;
        }

        private double _value = 0.00;

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value < Minimum || value > Maximum)
                    throw new ArgumentOutOfRangeException("The value is outside the minimum and maximum range.");
                this.Refresh();
                _value = value;
            }
        }

        private int _marqueeWidth = 14;

        public int MarqueeWidth
        {
            get
            {
                return _marqueeWidth;
            }
            set
            {
                _marqueeWidth = value;
                Refresh();
            }
        }

        private bool _showText = false;

        public bool ShowText
        {
            get
            {
                return _showText;
            }
            set
            {
                _showText = value;
                Refresh();
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (Visible)
                RedrawTimer.Start();
            else
                RedrawTimer.Stop();
        }

        private int _marqueePos = 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.Clear(BackColor);
            //Stolen from the ShiftOS code :3
            switch (Style)
            {
                case ProgressBarStyle.Continuous:
                    double width = linear(this.Value, this.Minimum, this.Maximum, 0, this.Width);
                    g.FillRectangle(new SolidBrush(ProgressColor), new RectangleF(0, 0, (float)width, this.Height));
                    break;
                case ProgressBarStyle.Blocks:
                    int block_count = this.Width / (this.BlockWidth + this.BlockSpacing);
                    int blocks = (int)linear(this.Value, this.Minimum, this.Maximum, 0, block_count);
                    for (int i = 0; i < blocks - 1; i++)
                    {
                        int position = i * (BlockWidth + BlockSpacing);
                        g.FillRectangle(new SolidBrush(ProgressColor), new Rectangle(position, 0, BlockWidth, this.Height));
                    }
                    break;
                case ProgressBarStyle.Marquee:
                    g.FillRectangle(new SolidBrush(ProgressColor), new Rectangle(_marqueePos, 0, MarqueeWidth, this.Height));
                    break;
            }
            if (ShowText)
            {
                var f = this.Font;
                var t = this.Text;
                var size = g.MeasureString(t, f);
                var loc = new PointF(
                        (this.Width - size.Width) / 2,
                        (this.Height - size.Height) / 2
                    );
                var color = this.ForeColor;
                g.DrawString(t, f, new SolidBrush(color), loc);
            }

        }

        ///<summary>
        /// Simple linear interpolation algorithm. (http://stackoverflow.com/questions/12838007/c-sharp-linear-interpolation)
        /// </summary>
        private double linear(double x, double x0, double x1, double y0, double y1)
        {
            if ((x1 - x0) == 0)
            {
                return (y0 + y1) / 2;
            }
            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }
    }
}
