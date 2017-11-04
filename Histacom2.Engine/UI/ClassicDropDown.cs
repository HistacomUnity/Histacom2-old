using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine.Template;

namespace Histacom2.Engine.UI
{
    public partial class ClassicDropDown : UserControl
    {
        public DropDownOverlay thisOverlay = new DropDownOverlay();
        public bool UseSystemPasswordChar { get; set; }
        public bool dropDownShown;

        public static Color textboxcolor = Color.Black;

        public static Color _lightBack = Color.Silver;
        public static Color _darkBack = Color.Silver;

        public List<string> items = new List<string> { "TestItem" };

        public ClassicDropDown()
        {
            InitializeComponent();

            
            try
            {
                // Draw the border    

                this.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
                {
                    // Update a bunch of variables!
                    textBox1.Font = Font;

                    if (SaveSystem.currentTheme != null)
                    {
                        textBox1.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
                        BackColor = SaveSystem.currentTheme.threeDObjectsColor;

                        textboxcolor = SaveSystem.currentTheme.windowColor;

                        _lightBack = Paintbrush.GetLightFromColor(textboxcolor);
                        _darkBack = Paintbrush.GetDarkFromColor(textboxcolor);
                    }
                    else
                    {
                        textBox1.BackColor = Color.White;
                        BackColor = Color.White;
                    }
                });

                

                tborder.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
                {
                    e.Graphics.DrawLine(new Pen(_darkBack), 0, 0, tborder.Width, 0);
                    e.Graphics.DrawLine(Pens.Black, 0, 1, tborder.Width, 1);

                });

                lborder.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
                {
                    e.Graphics.DrawLine(new Pen(_darkBack), 0, 0, 0, Height);
                    e.Graphics.DrawLine(Pens.Black, 1, 0, 1, Height);
                });

                rborder.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
                {
                    e.Graphics.DrawLine(new Pen(_lightBack), 0, 0, 0, Height - 1);
                    e.Graphics.DrawLine(new Pen(textboxcolor), 1, 0, 1, Height - 1);
                });

                bborder.Paint += new PaintEventHandler((object sender, PaintEventArgs e) =>
                {
                    e.Graphics.DrawLine(new Pen(_lightBack), 0, 0, Width - 1, 0);
                    e.Graphics.DrawLine(new Pen(textboxcolor), 0, 1, Width - 2, 1);
                });

                tborder.Invalidate();
                lborder.Invalidate();
                rborder.Invalidate();
                bborder.Invalidate();
            }
            catch { }
        }

        public void ChooseItem(string str)
        {
            textBox1.Text = str;
            ShowHideDropDown();
        }

        public void ShowHideDropDown()
        {
            if (dropDownShown)
            {
                thisOverlay.Close();
                dropDownShown = false;
            } else {
                thisOverlay = new DropDownOverlay();
                int applyHeight = 0;
                foreach (string str in items)
                {
                    DropDownItem itm = new DropDownItem();
                    itm.ChangeText(str, Font);
                    itm.dpdw = this;
                    itm.Dock = DockStyle.Top;
                    applyHeight += itm.Height;
                    thisOverlay.outline.Controls.Add(itm);
                }
                thisOverlay.outline.Location = this.PointToScreen(Point.Empty);
                thisOverlay.outline.Top += this.Height;
                thisOverlay.outline.Size = new Size(this.Width, applyHeight);

                thisOverlay.Deactivate += (sender2, e2) => { thisOverlay.Close(); dropDownShown = false; };

                thisOverlay.Show();
                dropDownShown = true;
            }
        }

        private void dropDownSwitch_Click(object sender, EventArgs e)
        {
            ShowHideDropDown();
        }

        private void ClassicDropDown_Load(object sender, EventArgs e)
        {
            try
            {
                ((Form)this.TopLevelControl).FormClosed += (sender2, e2) => { thisOverlay.Close(); };
                ((Form)this.TopLevelControl).Resize += (sender2, e2) =>
                {
                    thisOverlay.outline.Location = this.PointToScreen(Point.Empty);
                    thisOverlay.outline.Top += this.Height;
                    thisOverlay.BringToFront();
                };

                ((Form)this.TopLevelControl).Move += (sender2, e2) =>
                {
                    thisOverlay.outline.Location = this.PointToScreen(Point.Empty);
                    thisOverlay.outline.Top += this.Height;
                    thisOverlay.BringToFront();
                };
            } catch { }
            
        }
    }
}
