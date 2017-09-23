using System;
using System.IO;
using System.Windows.Forms;
using static Histacom2.Engine.SaveSystem;

namespace Histacom2.GlobalPrograms
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

        public int amountToDL = 100;
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
                progressBar1.Value = amountToDL;
                amountLbl.Text = $"Downloaded {amountDLed} KB out of {amountToDL}";

                switch (appName.Text)
                {
                    case "Downloading: FTP Client":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "FTP Client Setup.exe", "ftp client setup", 11, 56291);
                        break;
                    case "Downloading: Web Chat 1998":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "Web Chat Setup.exe", "web chat setup", 11, 34846);
                        break;
                    case "Downloading: Time Distorter 0.1":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "Time Distorter Setup.exe", "time distorter setup", 11, 21583);
                        break;
                    case "Downloading: Guess The Number V1":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "Guess The Number V1 Setup.exe", "gtnv1 setup", 11, 16483);
                        break;
                    case "Downloading: Error Blaster 95":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "Error Blaster 95 Setup.exe", "eb95 setup", 11, 34846);
                        break;
                    case "Downloading: Start Runner 95":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "Start Runner Setup.exe", "sr95 setup", 11, 34846);
                        break;
                    case "Downloading: Web Chat 1999":
                        CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop"), "Web Chat Setup.exe", "web chat 99 setup", 11, 37048);
                        break;
                }
                /* if (appName.Text == "Downloading: Skindows 95")
                {
                    CreateWindowsFile(Path.Combine(ProfileWindowsDirectory, "Desktop", "Skindows 95 Setup.exe"), "Skindows95Setup");
                } */
                ((Form)this.TopLevelControl).Close();
                dlTimer.Stop();
            }
            else
            {
                progressBar1.Maximum = amountToDL;
                progressBar1.Value = amountDLed;
            }
            amountLbl.Text = $"Downloaded {amountDLed} KB out of {amountToDL}";
        }

        private void dlSpeed_Tick(object sender, EventArgs e)
        {
            transferLbl.Text = $"Transfer speed: {downloadSpeed()} KB/s";
        }
    }
}
