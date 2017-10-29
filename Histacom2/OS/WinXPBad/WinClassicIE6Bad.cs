using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.OS.WinXPBad.Story;
using Histacom2.Engine.Template;

namespace Histacom2.OS.WinXPBad
{
    public partial class WinClassicIE6Bad : UserControl
    {
        private bool light = true;
        private Random r = new Random();
        private Random r2 = new Random();

        private int maxX;
        private int maxY;

        public WinClassicIE6Bad()
        {
            InitializeComponent();
        }

        private void originalTimer_Tick(object sender, EventArgs e)
        {
            if (light)
            {
                label1.ForeColor = Color.Black;
                light = false;
            }
            else
            {
                label1.ForeColor = Color.PaleGreen;
                light = true;
            }
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            VirusLabel v = new VirusLabel();
            v.Location = new Point(r.Next(0, maxX), r2.Next(0, maxY));
            v.Show();
            v.TopMost = true;
            v.BringToFront();
        }

        private void WinClassicIE6Bad_Load(object sender, EventArgs e)
        {
            maxX = Screen.PrimaryScreen.Bounds.Width;
            maxY = Screen.PrimaryScreen.Bounds.Height;
            Hack4.VirusDestruction(this);
            ((WinXP)ParentForm).closeDisabled = true;
        }
    }
}
