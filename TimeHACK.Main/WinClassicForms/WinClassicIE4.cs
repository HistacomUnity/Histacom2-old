using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimeHACK.WinClassicForms
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
            welcomeinternetscreen.Show();
            welcomeinternetscreen.Dock = DockStyle.Fill;
        }

        private void hidePrograms()
        {
            googlemain.Hide();
            welcomeinternetscreen.Hide();
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
            webBrowser1.Hide();
        }

        private void LinkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goToSite("www.google.com", false);
        }

        private void LinkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goToSite("www.12padams.com", false);
        }

        private void googleprototypelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goToSite("www.google.stanford.edu", false);
        }

        private void googlebetalink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goToSite("www.alpha.google.com", false);
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            hidePrograms();
            padamshidden.Dock = DockStyle.Fill;
            padamshidden.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void goToSite(string url, bool back)
        {
            hidePrograms();

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

            switch (url)
            {
                case "www.google.com":
                    googlemain.Dock = DockStyle.Fill;
                    googlemain.Show();
                    break;
                case "www.google.stanford.edu":
                    googleprototype.Dock = DockStyle.Fill;
                    googleprototype.Show();
                    break;
                case "www.alpha.google.com":
                    googlealpha.Dock = DockStyle.Fill;
                    googlealpha.Show();
                    break;
                case "www.12padams.com":
                    padamsmain.Dock = DockStyle.Fill;
                    padamsmain.Show();
                    break;
                case "www.microsoft.com/internetexplorer4/welcome":
                    welcomeinternetscreen.Dock = DockStyle.Fill;
                    welcomeinternetscreen.Show();
                    break;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(historylocation <= 0)) {
                goToSite(browsinghistory[historylocation - 1], true);
                historylocation--;
            }
        }
    }
}
