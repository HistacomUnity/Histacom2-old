using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TimeHACK
{
    public partial class WinClassicNotepad : Form
    {
        public WinClassicNotepad()
        {
            InitializeComponent();
        }

        private void WinClassicNotepad_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void programtopbar_drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}


