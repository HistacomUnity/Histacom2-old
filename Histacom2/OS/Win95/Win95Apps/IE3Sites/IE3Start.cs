using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.Win95.Win95Apps.IE3Sites
{
    public partial class IE3Start : UserControl
    {
        public IE3Start()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            WinClassicIE3.GoToPage("www.google.com");
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            WinClassicIE3.GoToPage("www.12padams.com");
        }
    }
}
