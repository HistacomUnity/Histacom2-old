using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimeHACK
{
    public partial class WinClassicIE4 : Form
    {
        public WinClassicIE4()
        {
            InitializeComponent();
        }
        private void WinClassicIE4_Load(object sender, EventArgs e)
        {
            TopMost = true;
            hidePrograms();
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
            this.Close();
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

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePrograms();
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }
    }
}
