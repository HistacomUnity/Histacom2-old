using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.OS.Win95.Win95Apps.IE4Sites
{
    public partial class IE4Start : UserControl
    {
        public IE4Start()
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
