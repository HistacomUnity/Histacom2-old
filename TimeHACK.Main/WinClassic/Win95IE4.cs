using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.WinClassic
{
    public partial class Win95IE4 : UserControl
    {
        public Win95IE4()
        {
            InitializeComponent();
        }

        private void Win95IE4_Load(object sender, EventArgs e)
        {
            HidePrograms();
            welcomeinternetscreen.Show();
            welcomeinternetscreen.Dock = DockStyle.Fill;
        }

        private void HidePrograms()
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
            HidePrograms();
            googlemain.Dock = DockStyle.Fill;
            googlemain.Show();
            addressbar.Text = "www.google.com";
        }

        private void LinkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePrograms();
            padamsmain.Dock = DockStyle.Fill;
            padamsmain.Show();
            addressbar.Text = "www.12padams.com";
        }

        private void Googleprototypelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePrograms();
            googleprototype.Dock = DockStyle.Fill;
            googleprototype.Show();
            addressbar.Text = "www.google.stanford.edu";
        }

        private void Googlebetalink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePrograms();
            googlealpha.Dock = DockStyle.Fill;
            googlealpha.Show();
            addressbar.Text = "www.alpha.google.com";
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            HidePrograms();
            padamshidden.Dock = DockStyle.Fill;
            padamshidden.Show();
        }

        private void LinkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HidePrograms();
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Show();
        }

    }
}
