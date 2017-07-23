using System;
using System.IO;
using System.Windows.Forms;
using static TimeHACK.Engine.SaveSystem;

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
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "Guess The Number Setup.exe"), "GuessTheNumber");
                }
                if (appName.Text == "Downloading: Start Runner")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "Start Runner Setup.exe"), "StartRunner");
                }
                if (appName.Text == "Downloading: Error Blaster")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "Error Blaster Setup.exe"), "ErrorBlaster");
                }
                if (appName.Text == "Downloading: Skindows 95")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "Skindows 95 Setup.exe"), "Skindows95Setup");
                }
                if (appName.Text == "Downloading: Web Chat")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "Web Chat Setup.exe"), "web chat setup");
                }
                if (appName.Text == "Downloading: hwcv.exe")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "hwcv.exe"), "hwcv");
                }
                if (appName.Text == "Downloading: Time Distorter")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "Time Distorter Setup.exe"), "time distorter setup");
                }
                if (appName.Text == "Downloading: FTP Client")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "FTP Client setup.exe"), "ftp client setup");
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
