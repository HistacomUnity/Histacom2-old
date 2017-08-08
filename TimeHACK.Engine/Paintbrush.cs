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

        public static void ExtendedToolStripSeparator_Paint(object sender, PaintEventArgs e)
        {
            // Get the separator's width and height.
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width;
            int height = toolStripSeparator.Height;

            // Choose the colors for drawing.
            Color foreColor = Color.Gray;
            Color backColor = Color.Silver;

            // Fill the background.
            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);

            // Draw the line.
            e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 4, height / 2);
        }
    }
}
