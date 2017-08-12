using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK.OS.Win95.Win95Apps.IE4Sites
{
    public partial class _12padams1998 : UserControl
    {
        public _12padams1998()
        {
            InitializeComponent();
            button1.Paint += (s, args) => Paintbrush.PaintClassicBorders(s, args, 2);
            button2.Paint += (s, args) => Paintbrush.PaintClassicBorders(s, args, 2);
            button3.Paint += (s, args) => Paintbrush.PaintClassicBorders(s, args, 2);
            button4.Paint += (s, args) => Paintbrush.PaintClassicBorders(s, args, 2);
            button5.Paint += (s, args) => Paintbrush.PaintClassicBorders(s, args, 2);
            button6.Paint += (s, args) => Paintbrush.PaintClassicBorders(s, args, 2);
            button7.Paint += (s, args) => Paintbrush.PaintClassicBorders(s, args, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WinClassicDownloader opendownload = new WinClassicDownloader();
            WindowManager wm = new WindowManager();
            wm.StartWin95(opendownload, "Downloader", null, false, true);
            opendownload.appName.Text = "Downloading: FTP Client";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinClassicDownloader opendownload = new WinClassicDownloader();
            WindowManager wm = new WindowManager();
            wm.StartWin95(opendownload, "Downloader", null, false, true);
            opendownload.appName.Text = "Downloading: Web Chat";
        }
    }
}
