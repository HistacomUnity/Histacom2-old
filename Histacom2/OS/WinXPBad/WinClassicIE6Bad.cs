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
        private static readonly Random Rnd = new Random();

        private int maxX = Screen.PrimaryScreen.Bounds.Width;
        private int maxY = Screen.PrimaryScreen.Bounds.Height;

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

        private void WinClassicIE6Bad_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"{maxX}, {maxY}.");

            Hack4.VirusDestruction(this);
            ((WinXP)ParentForm).closeDisabled = true;
        }
    }
}
