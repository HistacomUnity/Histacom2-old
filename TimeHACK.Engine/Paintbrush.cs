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
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset);
        }

        public static void PaintClassicBordersIndented(object sender, PaintEventArgs e, int borderwidth)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                SystemColors.ControlDarkDark, borderwidth, ButtonBorderStyle.Inset,
                SystemColors.ControlDarkDark, borderwidth, ButtonBorderStyle.Inset,
                SystemColors.ControlDarkDark, borderwidth, ButtonBorderStyle.Inset,
                SystemColors.ControlDarkDark, borderwidth, ButtonBorderStyle.Inset);
        }
    }
}
