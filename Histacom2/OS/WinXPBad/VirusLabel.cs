using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.WinXPBad
{
    public partial class VirusLabel : Form
    {
        private bool light = true;

        public VirusLabel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
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
    }
}
