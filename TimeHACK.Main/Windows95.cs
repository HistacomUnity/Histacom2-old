using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
namespace TimeHACK
{
    public partial class Windows95 : Form
    {
        private SoundPlayer start;
        private SoundPlayer stop;

        // Init the form
        public Windows95()
        {
            InitializeComponent();
        }

        //  When New Game is clicked in TitleScreen.cs
        private void Desktop_Load(object sender, EventArgs e)
        {
            // Hide the Startmenu
            startmenu.Hide();

            // Check for and set VM Mode
            if (this.FormBorderStyle != FormBorderStyle.None)
            {
                this.Text = "TimeHACK - VM Mode";
            }

            // Start the ClockTimer
            clockTimer.Start();

            // Play Windows 95 Start Sound
            Stream audio = Properties.Resources.Win95Start;
            start = new SoundPlayer(audio);
            start.Play();

            // Set the StartMenu seperator
            startmenuitems.Items.Insert(6, new ToolStripSeparator());

            this.SendToBack();
        }

        #region StartMenu

        // Paint StartMenu
        private void startmenu_Paint(object sender, PaintEventArgs e)
        {
            // Paint the StartMenu
            ControlPaint.DrawBorder(e.Graphics, startmenu.ClientRectangle,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
        }

        // StartButton Click
        private void startbutton_Click(object sender, EventArgs e)
        {
            startmenu.Show();
            startmenu.BringToFront();
        }

        // Shutdown button
        private void ShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start.Stop();
            Stream audio = Properties.Resources.tada;
            stop = new SoundPlayer(audio);
            stop.Play();
            System.Threading.Thread.Sleep(1500);
            Application.Exit();
        }

        #endregion //Region

        // When add new folder is clicked
        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desktopicons.Items.Add("New Folder");
        }

        // Give Year Code - NYI
        private void taskbartime_Click(object sender, EventArgs e)
        {

        }

        // Set the Clock
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            taskbartime.Text = DateTime.Now.ToString("h:mm tt");
        }

        // On Desktop MouseDown
        private void desktop_mousedown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rightclickbackproperties.Show();
                rightclickbackproperties.BringToFront();
                rightclickbackproperties.Location = MousePosition;
                startmenu.Hide();
            }

            // If 
            else if (e.Button == MouseButtons.Left)
            {
                rightclickbackproperties.Hide();
                startmenu.Hide();
            }

            else if (e.Button == MouseButtons.Middle)
            {
                rightclickbackproperties.Hide();
            }
        }

        private void NotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinClassicNotepad notepad = new WinClassicNotepad();
            notepad.Show();
            notepad.BringToFront();
            startmenu.Hide();
        }

        private void desktopicons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InternetExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinClassicIE4 ie = new WinClassicIE4();
            ie.Show();
            ie.BringToFront();
            startmenu.Hide();
        }
        
        private void desktopicons_Click(object sender, EventArgs e)
        {
            if (desktopicons.SelectedItems.ContainsKey("Internet Explorer"))
            {
                WinClassicIE4 ie = new WinClassicIE4();
                ie.Show();
                ie.BringToFront();
                startmenu.Hide();
            }
        }
    }
}

