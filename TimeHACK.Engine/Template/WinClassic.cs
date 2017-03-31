using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimeHACK.Engine.Template
{
    public partial class WinClassic : Form
    {
        public WinClassic()
        {
            InitializeComponent();
        }

        public System.Drawing.Font fnt;

        public bool closeDisabled = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Programtopbar_drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            if (!closeDisabled) this.Close();
        }

           public Boolean max = false;

        private void maximizebutton_Click(object sender, EventArgs e)
        {
            if (max == false)
            {
                this.right.Hide();
                this.left.Hide();
                this.bottom.Hide();
                this.top.Hide();
                this.bottomleftcorner.Hide();
                this.bottomrightcorner.Hide();
                this.topleftcorner.Hide();
                this.toprightcorner.Hide();
                this.Dock = DockStyle.Fill;
                this.WindowState = FormWindowState.Maximized;
                max = true;
                maximizebutton.Image = Engine.Properties.Resources.WinClassicRestore;
            }
            else
            {
                this.right.Show();
                this.left.Show();
                this.bottom.Show();
                this.top.Show();
                this.bottomleftcorner.Show();
                this.bottomrightcorner.Show();
                this.topleftcorner.Show();
                this.toprightcorner.Show();
                this.Dock = DockStyle.None;
                this.WindowState = FormWindowState.Normal;
                max = false;
                maximizebutton.Image = Engine.Properties.Resources.WinClassicMax;
            }
            
        }
    }
}
