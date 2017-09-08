using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.UI
{
    public class ClassicTextbox : Control
    {
        public ClassicTextbox() : base()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var textboxcolor = Color.Silver;
            if (SaveSystem.currentTheme != null) textboxcolor = SaveSystem.currentTheme.windowColor;

            if (SaveSystem.currentTheme != null) BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            else BackColor = Color.White;

            var _lightBack = Paintbrush.GetLightFromColor(textboxcolor);
            var _darkBack = Paintbrush.GetDarkFromColor(textboxcolor);

            var g = e.Graphics;
            g.Clear(BackColor);

            g.DrawLine(new Pen(_darkBack), 0, 0, Width - 2, 0);
            g.DrawLine(new Pen(_lightBack), Width - 1, 0, Width - 1, Height - 1);
            g.DrawLine(new Pen(_lightBack), 0, Height - 1, Width - 1, Height - 1);
            g.DrawLine(new Pen(_darkBack), 0, 0, 0, Height - 2);
            g.DrawLine(Pens.Black, 1, 1, Width - 3, 1);
            g.DrawLine(Pens.Black, 1, 1, 1, Height - 3);
            g.DrawLine(new Pen(textboxcolor), 1, Height - 2, Width - 2, Height - 2);
            g.DrawLine(new Pen(textboxcolor), Width - 2, Height - 2, Width - 2, 1);
        }
    }
}
