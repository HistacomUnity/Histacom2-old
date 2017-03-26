using System;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK.WinClassicForms
{
    public partial class WinClassicDownloader : UserControl
    {
        public WinClassicDownloader()
        {
            InitializeComponent();
        }
        int amountToDL = 100;
        int downloadSpeed = 8;
        int amountDLed = 0;
        Windows95 Windows95 = new Windows95();


        private void WinClassicDownloader_Load(object sender, EventArgs e)
        {
            dlTimer.Start();
            transferLbl.Text = ("Transfer speed: " + downloadSpeed + " KB/s");
        }

        private void dlTimer_Tick(object sender, EventArgs e)
        {
            amountDLed = amountDLed + downloadSpeed;
            if(downloadSpeed > amountToDL - amountDLed){
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
                    Windows95.desktopicons.Items.Add("Web Chat Setup", imageIndex: 11);
                }
                if (appName.Text == "Downloading: hwcv.exe")
                {
                    Windows95.desktopicons.Items.Add("hwcv.exe", imageIndex: 11);
                }
                if (appName.Text == "Downloading: Time Distorter")
                {
                    Windows95.desktopicons.Items.Add("Time Distorter Setup", imageIndex: 13);
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
    }
}
