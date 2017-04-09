using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using TimeHACK.Engine;
using TimeHACK.OS.Win95.Win95Apps;
using TimeHACK.WinClassicForms;

namespace TimeHACK.OS.Win95
{
    public partial class Windows95 : Form
    {
        private SoundPlayer startsound;
        private SoundPlayer stopsound;
        public WindowManager wm = new WindowManager();

        public bool webchatInstalled = false;

        // Init the form
        public Windows95()
        {
            InitializeComponent();
        }

        //  When New Game is clicked in TitleScreen.cs
        private void Desktop_Load(object sender, EventArgs e)
        {
            // Make Font Mandatory
            fontLoad();

            // Play Windows 95 Start Sound
            Stream audio = Properties.Resources.Win95Start;
            startsound = new SoundPlayer(audio);
            startsound.Play();

            // Hide the Startmenu
            startmenu.Hide();

            // Check for and set VM Mode
            if (this.FormBorderStyle != FormBorderStyle.None)
            {
                this.Text = "TimeHACK - VM Mode";
            }

            // Start the ClockTimer
            clockTimer.Start();

            // Set the StartMenu seperator
            startmenuitems.Items.Insert(6, new ToolStripSeparator());

            this.SendToBack();
        }

        private void fontLoad()
        {
            this.taskbartime.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.ProgramsToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.DocumentsToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuspendToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutdownToolStripMenuItem.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopicons.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            Win95Notepad npad = new Win95Notepad();
            Engine.Template.WinClassic app = wm.startWin95(npad, "Notepad", Properties.Resources.Win95IconNotepad, true, true);
            app.BringToFront();
            startmenu.Hide();
        }
        private void windowManagerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestApp test = new TestApp();
            wm.startWin95(test, "TestApp", null, true, true);
        }

        private void downloaderTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinClassicDownloader opendownload = new WinClassicDownloader();
            wm.startWin95(opendownload, "Downloader", null, false, true);
            opendownload.appName.Text = "Downloading: Survive The Day";
        }

        private void installerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinClassicInstaller openinstaller = new WinClassicInstaller();
            wm.startWin95(openinstaller, "Installer", null, false, true);
        }

        private void InternetExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinClassicIE4 ie = new WinClassicIE4();
            Engine.Template.WinClassic app = wm.startWin95(ie, "Internet Explorer 4", null, true, true);
            app.BringToFront();
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
                        Engine.Template.WinClassic app = wm.startWin95(ie, "Internet Explorer 4", null, true, true);
                        app.BringToFront();
                        startmenu.Hide();
                    } else if (objListViewItem.Text == "Web Chat Setup")
                    {
                        WinClassicInstaller inst = new WinClassicInstaller();
                        inst.installname.Text = "Web Chat 1998";
                        Engine.Template.WinClassic app = wm.startWin95(inst, "Web Chat Setup", null, true, true);
                        app.BringToFront();
                        startmenu.Hide();
                    }
                }
            }
        }

        private void infoboxTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.startInfobox95("AShifter's Infobox", "This is the very first TimeHACK Infobox. It's really easy to call, too! \n Just use wm.startInfobox95(String title, String text, Image erroricon)!", Properties.Resources.Win95Info);
        }
        private void WebChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebChat1998 wc = new WebChat1998();
            Engine.Template.WinClassic app = wm.startWin95(wc, "Web Chat 1998", null, true, true);
            app.BringToFront();
            startmenu.Hide();
        }
    }
}

