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

        private string downloadSpeed()
        {
            Random rnd = new Random();
            return rnd.Next(7, 9).ToString() + "." + rnd.Next(7, 9).ToString() + rnd.Next(7, 9).ToString();
        }

        int amountToDL = 100;
        int amountDLed = 0;

        private void WinClassicDownloader_Load(object sender, EventArgs e)
        {
            dlTimer.Start();
            dlSpeed.Start();
        }

        private void dlTimer_Tick(object sender, EventArgs e)
        {
            amountDLed = amountDLed + 8;
            if (8 > amountToDL - amountDLed)
            {
                progBar.Value = 100;
                amountLbl.Text = $"Downloaded {amountDLed} KB out of {amountToDL}";

                switch (appName.Text)
                {
                    case "Downloading: FTP Client":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "FTP Client Setup.exe", "ftp client setup", 11, 56291);
                        break;
                    case "Downloading: Web Chat 1998":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "Web Chat Setup.exe", "web chat setup", 11, 34846);
                        break;
                }
                /* if (appName.Text == "Downloading: Guess The Number")
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
                } */
                ((Form)this.TopLevelControl).Close();
                dlTimer.Stop();
            }
            else
            {
                progBar.Maximum = amountToDL;
                progBar.Value = amountDLed;
            }
            amountLbl.Text = $"Downloaded {amountDLed} KB out of {amountToDL}";
        }

        private void dlSpeed_Tick(object sender, EventArgs e)
        {
            transferLbl.Text = $"Transfer speed: {downloadSpeed()} KB/s";
        }
    }
}
