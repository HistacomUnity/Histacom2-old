using System;
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
        }

        private void LinkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePrograms();
            googlemain.Show();
        }
    }
}
