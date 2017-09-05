using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.UI
{
    public class ClassicButton : Control
    {
        private Color _lightBack = Color.White;
        private Color _darkBack = Color.Gray;

        private bool _pressing = false;

        public ClassicButton() : base()
        {
            if (SaveSystem.currentTheme != null) BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            else BackColor = Color.Silver;
            _lightBack = ControlPaint.Light(BackColor, 50);
            _darkBack = ControlPaint.Dark(BackColor, 50);

            if (SaveSystem.currentTheme != null) ForeColor = SaveSystem.currentTheme.threeDObjectsTextColor;
            else ForeColor = Color.Black;

            MouseDown += (s, e) => { _pressing = true; Invalidate(); };
            MouseUp += (s, e) => { _pressing = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.Clear(BackColor);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            
            if (_pressing)
            {
                g.FillRectangle(new SolidBrush(_lightBack), new Rectangle(0, 0, Width, Height));
                g.FillRectangle(Brushes.Black, new Rectangle(0, 0, Width - 1, Height - 1));
                g.FillRectangle(new SolidBrush(_darkBack), new Rectangle(1, 1, Width - 2, Height - 2));
                g.FillRectangle(new SolidBrush(BackColor), new Rectangle(2, 2, Width - 3, Height - 3));

                g.DrawString(Text, Font, new SolidBrush(ForeColor), (Width / 2) - (g.MeasureString(Text, Font).Width / 2) + 1, (Height / 2) - (g.MeasureString(Text, Font).Height / 2) + 1);
            }
            else
            {
                g.FillRectangle(Brushes.Black, new Rectangle(0, 0, Width, Height));
                g.FillRectangle(new SolidBrush(_lightBack), new Rectangle(0, 0, Width - 1, Height - 1));
                g.FillRectangle(new SolidBrush(_darkBack), new Rectangle(1, 1, Width - 2, Height - 2));
                g.FillRectangle(new SolidBrush(BackColor), new Rectangle(1, 1, Width - 3, Height - 3));

                g.DrawString(Text, Font, new SolidBrush(ForeColor), (Width / 2) - (g.MeasureString(Text, Font).Width / 2), (Height / 2) - (g.MeasureString(Text, Font).Height / 2));
            }
        }
        
    }
}
