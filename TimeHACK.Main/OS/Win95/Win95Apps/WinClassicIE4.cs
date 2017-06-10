using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TimeHACK.Engine;
using TimeHACK.Engine.Template;
namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicIE4 : UserControl
    {
        public List<string> browsinghistory = new List<string>();
        public int historylocation = 0;

        public WinClassicIE4()
        {
            InitializeComponent();
        }

        private void WinClassicIE4_Load(object sender, EventArgs e)
        {
            browsinghistory.Capacity = 99;
            BringToFront();
            hidePrograms();
            browsinghistory.Add("www.microsoft.com/internetexplorer4/welcome");
            for (int i = 0; i < 99; i++) browsinghistory.Add(null);
            foreach (ToolStripMenuItem item in MenuStrip3.Items) item.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            foreach (Control ctrl in Panel1.Controls) ctrl.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
        }

        private void hidePrograms()
        {
            googlemain.Hide();
            googleprototype.Hide();
            googlealpha.Hide();
            padamsmain.Hide();
            hotmailmain.Hide();
            padamsbackgrounds.Hide();
            skindows95advertisment.Hide();
            secretwebsite.Hide();
            padamshidden.Hide();
            email1.Hide();
            email2.Hide();
            email3.Hide();
            hotmailpadams.Hide();
        }
        private void goToSite(string url, bool back)
        {
            switch (url)
            {
                case "www.google.com":
                    hidePrograms();
                    break;
                case "www.google.stanford.edu":
                    hidePrograms();
                    break;
                case "www.alpha.google.com":
                    hidePrograms();
                    googlealpha.Dock = DockStyle.Fill;
                    googlealpha.Show();
                    break;
                case "www.12padams.com":
                    Story.Hack1 startStory = new Story.Hack1();
                    startStory.startObjective();
                    hidePrograms();
                    break;
                case "www.microsoft.com/internetexplorer4/welcome":
                    hidePrograms();
                    break;
                case "www.???.com":
                    hidePrograms();
                    secretwebsite.Dock = DockStyle.Fill;
                    secretwebsite.Show();
                    break;
                case "www.12padams.com/???":
                    hidePrograms();
                    padamshidden.Dock = DockStyle.Fill;
                    padamshidden.Show();
                    break;
                default:
                    return;
            }

            if (!back)
            {
                if (historylocation >= 98) historylocation = 79;
                for (int i = historylocation + 1; i < browsinghistory.Count; i++)
                {
                    browsinghistory[i] = null;
                }
                int j = 0;
                for (int i = 1; i < browsinghistory.Count; i++)
                {
                    if (browsinghistory[i] != null && browsinghistory[i] != "") j++;
                }
                historylocation = j;
                browsinghistory[historylocation + 1] = url;
                historylocation++;
            }

            addressbar.Text = url;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!(historylocation <= 0))
            {
                goToSite(browsinghistory[historylocation - 1], true);
                historylocation--;
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if(browsinghistory[historylocation+1] != null) goToSite(browsinghistory[historylocation + 1], false);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            goToSite("www.microsoft.com/internetexplorer4/welcome", false);
        }

        private void WCDownloadButton_Click(object sender, HtmlElementEventArgs e)
        {
            WinClassicDownloader opendownload = new WinClassicDownloader();
            WindowManager wm = new WindowManager();
            wm.startWin95(opendownload, "Downloader", null, false, true);
            opendownload.appName.Text = "Downloading: Web Chat";
        } 

        private void GoButton_Click(object sender, EventArgs e)
        {
            goToSite(addressbar.Text, false);
        }
        
        //TODO: Add more websites
        //TODO: Relabel Buttons And Things
    }
}
