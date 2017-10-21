using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.UI
{
    public class ClassicStartMenuItem : ToolStripMenuItem
    {
        public ClassicStartMenuItem()
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (SaveSystem.currentTheme != null) e.Graphics.Clear(SaveSystem.currentTheme.threeDObjectsColor);
            else e.Graphics.Clear(BackColor);
            if (Selected)
            {
                if (SaveSystem.currentTheme != null) e.Graphics.Clear(SaveSystem.currentTheme.selectedBackColor);
                else e.Graphics.Clear(Color.Navy);
            }

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

            StringFormat sf = new StringFormat();
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
            
            e.Graphics.DrawImage(Image, 0 + Padding.Left - Padding.Right, 0);
            if (!Selected) {
                if (SaveSystem.currentTheme != null) { e.Graphics.DrawString(Text, new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular), Brushes.Black, 38, 11, sf); }

                if (DropDownItems.Count > 0)
                {
                    e.Graphics.DrawPolygon(Pens.Black, new Point[] { new Point(121, 11), new Point(124, 14), new Point(121, 17) });
                    e.Graphics.FillPolygon(Brushes.Black, new Point[] { new Point(121, 11), new Point(124, 14), new Point(121, 17) });
                }
            } else
            {
                if (SaveSystem.currentTheme != null)
                {
                    e.Graphics.DrawString(Text, new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular), new SolidBrush(SaveSystem.currentTheme.selectedTextColor), 38, 11, sf);
                    if (DropDownItems.Count > 0)
                    {
                        e.Graphics.DrawPolygon(new Pen(SaveSystem.currentTheme.selectedTextColor), new Point[] { new Point(121, 11), new Point(124, 14), new Point(121, 17) });
                        e.Graphics.FillPolygon(new SolidBrush(SaveSystem.currentTheme.selectedTextColor), new Point[] { new Point(121, 11), new Point(124, 14), new Point(121, 17) });
                    }
                }
            }
        }
    }
}
