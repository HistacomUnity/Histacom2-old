using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine;
using Histacom2.GlobalPrograms;

namespace Histacom2.OS.Win98.Win98Apps.IE4Sites
{
    public partial class _12padams1999 : UserControl
    {
        public _12padams1999()
        {
            InitializeComponent();
        }

        private void classicButton2_Click(object sender, EventArgs e)
        {
            WinClassicDownloader opendownload = new WinClassicDownloader();
            WindowManager wm = new WindowManager();
            wm.Init(opendownload, "Downloader", null, false, true);
            opendownload.appName.Text = "Downloading: Web Chat 1999";
            opendownload.amountToDL = 37;
        }

        private void classicButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
