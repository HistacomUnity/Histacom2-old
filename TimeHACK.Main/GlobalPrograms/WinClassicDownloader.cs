using System;
using System.Windows.Forms;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicDownloader : UserControl
    {
        public WinClassicDownloader()
        {
            InitializeComponent();

        }

        private string DownloadSpeed(string str)
        {
            Random rnd = new Random();
            int dl1 = rnd.Next(7, 9);
            int dl2 = rnd.Next(1, 9);
            int dl3 = rnd.Next(1, 9);
            string speed = dl1.ToString() + "." + dl2.ToString() + dl3.ToString();
            return speed;
        }

        int amountToDL = 100;
        int amountDLed = 0;
        Windows95 Windows95 = new Windows95();


        private void WinClassicDownloader_Load(object sender, EventArgs e)
        {
            dlTimer.Start();
            dlSpeed.Start();
        }

        private void dlTimer_Tick(object sender, EventArgs e)
        {
            amountDLed = amountDLed + 8;
            if(8 > amountToDL - amountDLed){
                progBar.Value = 100;
                amountLbl.Text = ("Downloaded " + amountDLed + " KB out of " + amountToDL + " KB");

                if (appName.Text == "Downloading: Guess The Number")
                {
                    Windows95.desktopicons.Items.Add("Guess The Number Setup", imageIndex: 8);
                }
                if (appName.Text == "Downloading: Start Runner")
                {
                    Windows95.desktopicons.Items.Add("Start Runner Setup", imageIndex: 9);
                }
                if (appName.Text == "Downloading: Error Blaster")
                {
                    Windows95.desktopicons.Items.Add("Error Blaster Setup", imageIndex: 10);
                }
                if (appName.Text == "Downloading: Skindows 95")
                {
                    Windows95.desktopicons.Items.Add("Skindows 95 Setup", imageIndex: 12);
                }
                if (appName.Text == "Downloading: Web Chat")
                {
                    TitleScreen.frm95.desktopicons.Items.Add("Web Chat Setup", imageIndex: 11);
                }
                if (appName.Text == "Downloading: hwcv.exe")
                {
                    Windows95.desktopicons.Items.Add("hwcv.exe", imageIndex: 14);
                }
                if (appName.Text == "Downloading: Time Distorter")
                {
                    Windows95.desktopicons.Items.Add("Time Distorter Setup", imageIndex: 13);
                }
                if (appName.Text == "Downloading: FTP Client")
                {
                    TitleScreen.frm95.desktopicons.Items.Add("FTP Client Setup", imageIndex: 11);
                }
                ((Form)this.TopLevelControl).Close();
                dlTimer.Stop();
            }
            else
            {
                progBar.Maximum = amountToDL;
                progBar.Value = amountDLed;
            }
            amountLbl.Text = ("Downloaded " + amountDLed + " KB out of " + amountToDL);
        }

        private void dlSpeed_Tick(object sender, EventArgs e)
        {
            transferLbl.Text = ("Transfer speed: " + DownloadSpeed("") + " KB/s");
        }
    }
}
