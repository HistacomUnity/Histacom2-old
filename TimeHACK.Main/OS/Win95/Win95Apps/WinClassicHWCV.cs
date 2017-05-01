using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicHWCV : UserControl
    {
        public WinClassicHWCV()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "www.12padams.com")
            {
                Label3.Show();
                Label3.Text = "Hidden Content Found: Time Distorter";
                TitleScreen.frm95.hiddenpadamsFound = true;
                if (TitleScreen.frm95.ie != null && ((WinClassicIE4)TitleScreen.frm95.ie.programContent.Controls[0]).currentsite.Title == "12PADAMS") ((WinClassicIE4)TitleScreen.frm95.ie.programContent.Controls[0]).webBrowser1.Refresh();
            }
            else
            {
                Label3.Show();
                Label3.Text = "No Content Found";
            }
        }
    }
}
