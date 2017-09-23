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
        public ClassicLabel()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var gfx = e.Graphics;
            gfx.Clear(BackColor);
            gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

            gfx.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
            Height = (int)gfx.MeasureString(Text, Font, ClientRectangle.Width).Height;
        }
    }
}
