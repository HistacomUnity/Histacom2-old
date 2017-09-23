using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.Win98.Win98Apps.IE4Sites
{
    public partial class IE4HomePage : UserControl
    {
        public IE4HomePage()
        {
            InitializeComponent();
        }

        private void IE4HomePage_SizeChanged(object sender, EventArgs e)
        {
            classicLabel1.Invalidate();
            classicLabel2.Invalidate();
            classicLabel3.Invalidate();
            classicLabel4.Invalidate();
            classicLabel5.Invalidate();
            classicLabel6.Invalidate();
            classicLabel7.Invalidate();
            classicLabel8.Invalidate();
            classicLabel9.Invalidate();
            classicLabel15.Invalidate();
            classicLabel25.Invalidate();
            classicLabel26.Invalidate();
        }

        private void classicLabel22_Click(object sender, EventArgs e)
        {
            WinClassicIE4.GoToPage("www.12padams.com");
        }
    }
}
