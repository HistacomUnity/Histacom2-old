using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine
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

        /// <summary>
        /// Get a color lighter than the input color.
        /// </summary>
        /// <param name="basecolor">The color to lighten.</param>
        /// <returns></returns>
        public static Color GetLightFromColor(Color basecolor)
        {
            if (basecolor == Color.Silver) return Color.White;
            if (basecolor == Color.Green) return Color.FromArgb(64, 255, 64);
            if (basecolor == Color.NavajoWhite) return Color.FromArgb(255, 239, 215);
            if (basecolor == Color.FromArgb(112, 112, 112)) return Color.FromArgb(184, 184, 184);
            if (basecolor == Color.FromArgb(169, 200, 169)) return Color.FromArgb(218, 223, 218);
            if (basecolor == Color.FromArgb(184, 200, 184)) return Color.FromArgb(220, 228, 220);
            if (basecolor == Color.FromArgb(191, 165, 159)) return Color.FromArgb(223, 210, 208);
            if (basecolor == Color.FromArgb(104, 120, 104)) return Color.FromArgb(176, 192, 176);
            if (basecolor == Color.FromArgb(216, 192, 160)) return Color.FromArgb(240, 224, 208);
            if (basecolor == Color.FromArgb(131, 153, 177)) return Color.FromArgb(131, 153, 177);
            if (basecolor == Color.FromArgb(176, 224, 160)) return Color.FromArgb(192, 192, 192);
            if (basecolor == Color.FromArgb(208, 104, 216)) return Color.FromArgb(232, 184, 240);
            if (basecolor == Color.FromArgb(144, 128, 112)) return Color.FromArgb(200, 192, 184);
            return ControlPaint.Light(basecolor, 5);
        }

        public static Color GetDarkFromColor(Color basecolor)
        {
            if (basecolor == Color.Silver) return Color.Gray;
            if (basecolor == Color.Green) return Color.FromArgb(0, 83, 0);
            if (basecolor == Color.NavajoWhite) return Color.FromArgb(255, 164, 28);
            if (basecolor == Color.FromArgb(112, 112, 112)) return Color.FromArgb(72, 72, 72);
            if (basecolor == Color.FromArgb(169, 200, 169)) return Color.FromArgb(95, 153, 95);
            if (basecolor == Color.FromArgb(191, 165, 159)) return Color.FromArgb(139, 101, 192);
            if (basecolor == Color.FromArgb(104, 120, 104)) return Color.FromArgb(72, 80, 72);
            if (basecolor == Color.FromArgb(216, 192, 160)) return Color.FromArgb(176, 136, 72);
            if (basecolor == Color.FromArgb(131, 153, 177)) return Color.FromArgb(79, 101, 125);
            if (basecolor == Color.FromArgb(176, 224, 160)) return Color.FromArgb(104, 184, 72);
            if (basecolor == Color.FromArgb(208, 104, 216)) return Color.FromArgb(160, 48, 168);
            if (basecolor == Color.FromArgb(144, 128, 112)) return Color.FromArgb(96, 88, 72);
            return ControlPaint.Dark(basecolor, 5);
        }
    }
}
