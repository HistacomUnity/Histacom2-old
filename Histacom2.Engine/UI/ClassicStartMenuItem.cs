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
        private ClassicStartMenuItemLayout layout;
        public ClassicStartMenuItemLayout LayoutStyle {
            get
            {
                return layout;
            }
            set
            {
                layout = value;
                Invalidate();
            }
        }

        private string subtext = "Subtitle";
        public string SubTitle
        {
            get
            {
                return subtext;
            }
            set
            {
                subtext = value;
                Invalidate();
            }
        }

        public bool DoBackColorAdapt { get; set; }

        public ClassicStartMenuItem()
        {
            AutoSize = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (SaveSystem.currentTheme != null && DoBackColorAdapt) e.Graphics.Clear(SaveSystem.currentTheme.threeDObjectsColor);
            else if (BackColor != Color.Transparent) e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            if (BackgroundImage != null)
            {
                if (BackgroundImageLayout == ImageLayout.Stretch) e.Graphics.DrawImage(BackgroundImage, new Rectangle(0, 0, Width, Height + 9));
            }

            int imgWidth = 0;
            if (Image != null)
            {
                if (Selected)
            {
                if (SaveSystem.currentTheme != null && DoBackColorAdapt) e.Graphics.FillRectangle(new SolidBrush(SaveSystem.currentTheme.selectedBackColor), new Rectangle(0, 0, Width, Image.Height));
                else e.Graphics.FillRectangle(Brushes.Navy, new Rectangle(0, 0, Width, Image.Height));
            }

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            e.Graphics.DrawImage(Image, 0 + Padding.Left - Padding.Right, 0); imgWidth = Image.Width;
            

             }
            //if (Image != null) if (Height != Image.Height) if (layout == ClassicStartMenuItemLayout.CloseTitleWithLightSubtitle && Height != Image.Height + 8) { Height = Image.Height; }
            StringFormat sf = new StringFormat();
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;

            if (!Selected) {
                switch (layout) {
                    case ClassicStartMenuItemLayout.DistancedTitle:
                        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), imgWidth + 6, getYForString(), sf);
                        break;
                    case ClassicStartMenuItemLayout.CloseTitle:
                        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), imgWidth + 2, getYForString(), sf);
                        break;
                    case ClassicStartMenuItemLayout.CloseTitleWithLightSubtitle:
                        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), imgWidth + 2, 3, sf);
                        e.Graphics.DrawString(subtext, new Font(Font, FontStyle.Regular), Brushes.Gray, imgWidth + 2, 16, sf);
                        //if (Image != null) if (Height != Image.Height + 8) Height = Image.Height + 8;
                        break;
                }

                if (DropDownItems.Count > 0)
                {
                    e.Graphics.DrawPolygon(new Pen(ForeColor), new Point[] { new Point(Width - 16, 11), new Point(Width - 13, 14), new Point(Width - 16, 17) });
                    e.Graphics.FillPolygon(new SolidBrush(ForeColor), new Point[] { new Point(Width - 16, 11), new Point(Width - 13, 14), new Point(Width - 16, 17) });
                }
            } else
            {
                if (SaveSystem.currentTheme != null)
                {
                    switch (layout)
                    {
                        case ClassicStartMenuItemLayout.DistancedTitle:
                            e.Graphics.DrawString(Text, Font, new SolidBrush(SaveSystem.currentTheme.selectedTextColor), imgWidth + 6, getYForString(), sf);
                            break;
                        case ClassicStartMenuItemLayout.CloseTitle:
                            e.Graphics.DrawString(Text, Font, new SolidBrush(SaveSystem.currentTheme.selectedTextColor), imgWidth + 2, getYForString(), sf);
                            break;
                        case ClassicStartMenuItemLayout.CloseTitleWithLightSubtitle:
                            e.Graphics.DrawString(Text, Font, new SolidBrush(SaveSystem.currentTheme.selectedTextColor), imgWidth + 2, 3, sf);
                            //if (Image != null) if (Height != Image.Height + 8) Height = Image.Height + 8;
                            break;
                    }

                    if (DropDownItems.Count > 0)
                    {
                        e.Graphics.DrawPolygon(new Pen(SaveSystem.currentTheme.selectedTextColor), new Point[] { new Point(121, 11), new Point(124, 14), new Point(121, 17) });
                        e.Graphics.FillPolygon(new SolidBrush(SaveSystem.currentTheme.selectedTextColor), new Point[] { new Point(121, 11), new Point(124, 14), new Point(121, 17) });
                    }
                }
            }
        }

        private int getYForString()
        {
            if (Image != null)
            {
                if (Image.Height == 32) return 9;
                if (Image.Height == 24) return 6;
            }
            return 0;
        }
    }
    public enum ClassicStartMenuItemLayout
    {
        DistancedTitle,
        CloseTitle,
        //CloseTitleWithTwoLines,
        CloseTitleWithLightSubtitle
    }
}
