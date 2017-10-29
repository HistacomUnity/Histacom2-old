using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.WinXPBad
{
    public partial class VirusLabel : UserControl
    {
        private bool white = true;

        public VirusLabel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (white)
            {
                label1.ForeColor = Color.Black;
                white = false;
            }
            else
            {
                label1.ForeColor = Color.PaleGreen;
                white = true;
            }
        }
    }
}
