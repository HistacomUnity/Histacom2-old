using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using TimeHACK.Engine;
using TimeHACK.WinClassicForms;

namespace TimeHACK
{
    public partial class Windows95 : Form
    {
        private SoundPlayer startsound;
        private SoundPlayer stopsound;

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
            startsound = new SoundPlayer(audio);
            startsound.Play();

            // Set the StartMenu seperator
            startmenuitems.Items.Insert(6, new ToolStripSeparator());
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
        }

        // Shutdown button
        private void ShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startsound.Stop();
            Stream audio = Properties.Resources.tada;
            stopsound = new SoundPlayer(audio);
            stopsound.Play();
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
            
        }
        private void windowManagerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            TestApp test = new TestApp();
            wm.startWinClassic(test, "TestApp", null, true, true);
        }

        private void downloaderTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinClassicDownloader opendownload = new WinClassicDownloader();
            WindowManager wm = new WindowManager();
            wm.startWinClassic(opendownload, "Downloader", null, false, true);
            opendownload.appName.Text = "Downloading: Survive The Day";
        }

        private void installerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinClassicInstaller openinstaller = new WinClassicInstaller();
            WindowManager wm = new WindowManager();
            wm.startWinClassic(openinstaller, "Installer", null, false, true);
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
            Point objDrawingPoint = desktopicons.PointToClient(Cursor.Position);
            ListViewItem objListViewItem;

            if (objDrawingPoint != null)
            {
                objListViewItem = desktopicons.GetItemAt(objDrawingPoint.X, objDrawingPoint.Y);
                if (objListViewItem != null)
                {
                    if (objListViewItem.Text == "Internet Explorer")
                    {
                        WinClassicIE4 ie = new WinClassicIE4();
                        WindowManager wm = new WindowManager();
                        wm.startWinClassic(ie, "Internet Explorer 4", null, true, true);
                        startmenu.Hide();
                    }
                }
            }
        }
    }
}

