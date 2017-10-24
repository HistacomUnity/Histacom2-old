using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.UI
{
    public class ClassicLabel : Control
    {
        public bool DropShadow { get; set; }

        public ClassicLabel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            TextChanged += (s, e) => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var gfx = e.Graphics;
            if (BackColor != Color.Transparent) gfx.Clear(BackColor);
            gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

            gfx.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
            Height = (int)gfx.MeasureString(Text, Font, ClientRectangle.Width).Height;
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (DropShadow) cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
