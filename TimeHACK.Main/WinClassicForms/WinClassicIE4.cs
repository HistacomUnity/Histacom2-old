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
            BringToFront();
            hidePrograms();
            browsinghistory.Add("www.microsoft.com/internetexplorer4/welcome");
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
            hidePrograms();
            googlemain.Dock = DockStyle.Fill;
            googlemain.Show();
            addressbar.Text = "www.google.com";
        }

        private void LinkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePrograms();
            padamsmain.Dock = DockStyle.Fill;
            padamsmain.Show();
            addressbar.Text = "www.12padams.com";
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void googleprototypelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePrograms();
            googleprototype.Dock = DockStyle.Fill;
            googleprototype.Show();
            addressbar.Text = "www.google.stanford.edu";
        }

        private void googlebetalink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePrograms();
            googlealpha.Dock = DockStyle.Fill;
            googlealpha.Show();
            addressbar.Text = "www.alpha.google.com";
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
            this.ParentForm.Close();
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
            }

            addressbar.Text = url;
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
