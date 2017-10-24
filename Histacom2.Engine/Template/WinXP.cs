using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Histacom2.Engine.Template
{
    public partial class WinXP : Form
    {
        public WinXP()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
        }

        public Font fnt;
        public ResizeOverlay resizer = new ResizeOverlay();
        public UserControl progContent;

        public bool resizable = true;
        public bool max = false;
        public bool closeDisabled = false;
        public bool isActive = true;
        public bool Resizing = false;
        public Bitmap ResizingBmp = null;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int HT_CAPTION = 0x2;

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        private void closebutton_Click(object sender, EventArgs e)
        {
            if (!closeDisabled) this.Close();
        }

        private void top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && max == false)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void WinXP_Load(object sender, EventArgs e)
        {

        }
    }
}
