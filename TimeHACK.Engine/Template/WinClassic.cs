using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimeHACK.Engine.Template
{
    public partial class WinClassic : Form
    {
        public WinClassic()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public Font fnt;

        public bool closeDisabled = false;
        public bool isActive = true;

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

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Programtopbar_drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && max == false)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            if (!closeDisabled) this.Close();
        }

        private void WinClassic_Activated(object sender, EventArgs e)
        {
            isActive = true;
            programtopbar.BackColor = SaveSystem.currentTheme.activeTitleBarColor;
            Title.ForeColor = SaveSystem.currentTheme.activeTitleTextColor;
        }

        private void WinClassic_Deactivate(object sender, EventArgs e)
        {
            isActive = false;
            programtopbar.BackColor = SaveSystem.currentTheme.inactiveTitleBarColor;
            Title.ForeColor = SaveSystem.currentTheme.inactiveTitleTextColor;
        }

        private void right_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Size = new Size(MousePosition.X - this.Location.X, this.Size.Height);
            }
        }

        private void left_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Size = new Size(this.Size.Width + (this.Location.X - MousePosition.X), this.Size.Height);
                this.Location = new Point(MousePosition.X, this.Location.Y);
            }
        }

        private void bottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.Size = new Size(this.Size.Width, MousePosition.Y - this.Location.Y);
            }
        }

        public bool max = false;

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

        // The rest of this code will automatically style the buttons on the form!

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            if (e.Control.GetType() == typeof(Button))
            {
                e.Control.MouseEnter += button_MouseEnter;
                e.Control.MouseLeave += button_MouseLeave;

                ((Button)e.Control).FlatStyle = FlatStyle.Popup;
            }
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);

            if (e.Control.GetType() == typeof(Button))
            {
                e.Control.MouseEnter -= button_MouseEnter;
                e.Control.MouseLeave -= button_MouseLeave;
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            var c = (Button)sender;
            c.UseVisualStyleBackColor = false;
            c.BackColor = Color.GhostWhite;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var c = (Button)sender;
            c.UseVisualStyleBackColor = true;
        }

        private void border_MouseDown(object sender, EventArgs e)
        {
            var cursor = this.PointToClient(Cursor.Position);

            if (topleftcorner.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF004, 0);
            else if (toprightcorner.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF005, 0);
            else if (bottomleftcorner.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF007, 0);
            else if (bottomrightcorner.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF008, 0);

            else if (top.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF003, 0);
            else if (left.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF001, 0);
            else if (right.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF002, 0);
            else if (bottom.ClientRectangle.Contains(cursor)) SendMessage(Handle, WM_SYSCOMMAND, 0xF006, 0);
        }
    }
}
