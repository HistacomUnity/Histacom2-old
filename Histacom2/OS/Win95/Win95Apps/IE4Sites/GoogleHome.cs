using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.Win95.Win95Apps.IE4Sites
{
    public partial class GoogleHome : UserControl
    {
        public GoogleHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WinClassicIE3.GoToPage("www.google.stanford.edu");
        }
    }
}
