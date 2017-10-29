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
    public partial class WinClassicIE6Bad : UserControl
    {
        private bool light = true;

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
            else {
                label1.ForeColor = Color.PaleGreen;
                light = true;
            }
        }
    }
}
