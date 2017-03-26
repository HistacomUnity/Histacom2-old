using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TimeHACK.Engine;


namespace TimeHACK.WinClassicForms
{
    public partial class WinClassicIE4Ported : UserControl
    {
        public WinClassicIE4Ported()
        {
            InitializeComponent();
        }

        #region Moving windows
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private void programtopbar_drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void WinClassicIE4Ported_Load(object sender, EventArgs e)
        {
            BringToFront();
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

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hidePrograms();
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }
    }
}
