using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.Engine
{
    public class Paintbrush
    {

        public static void PaintClassicBorders(object sender, PaintEventArgs e, int borderwidth)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                Color.White, borderwidth, ButtonBorderStyle.Solid,
                Color.White, borderwidth, ButtonBorderStyle.Solid,
                Color.Gray, borderwidth, ButtonBorderStyle.Solid,
                Color.Gray, borderwidth, ButtonBorderStyle.Solid);
        }

        public static void PaintClassicBordersIndented(object sender, PaintEventArgs e, int borderwidth)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                Color.Gray, borderwidth, ButtonBorderStyle.Solid,
                Color.Gray, borderwidth, ButtonBorderStyle.Solid,
                Color.White, borderwidth, ButtonBorderStyle.Solid,
                Color.White, borderwidth, ButtonBorderStyle.Solid);
        }
    }
}
