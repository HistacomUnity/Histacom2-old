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
        public enum BGStyle
        {
            NoChange,
            Silver,
            XP
        }

        public static void paintClassicBorders(object sender, PaintEventArgs e, int borderwidth, BGStyle bg)
        {
            ((Control)sender).BackColor = Color.Silver;
            ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, borderwidth, ButtonBorderStyle.Outset);
        }
    }
}
