using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Histacom2.Engine;
using Histacom2.Engine.Template;
using Histacom2.Engine.Template.Taskbars;
using Histacom2.OS.Win95.Win95Apps;
using Histacom2.OS.Win95.Win95Apps.Story;
using static Histacom2.Engine.SaveSystem;
using Histacom2.OS.Win98.Win98Apps;
using Histacom2.GlobalPrograms;
using Histacom2.OS.WinXPBad.Story;

namespace Histacom2.OS.WinXPBad
{
    public partial class WindowsXPBad : Form
    {
        private SoundPlayer startsound;
        public WindowManager wm = new WindowManager();

        public TaskBarController tb = new TaskBarController();

        public int currentappcount = 0;

        // Init the form
        public WindowsXPBad()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackgroundImage = currentTheme.defaultWallpaper;
        }

        //  When New Game is clicked in TitleScreen.cs
        private void Desktop_Load(object sender, EventArgs e)
        {
            if (currentTheme.defaultWallpaper != null) desktopicons.BackgroundImage = new Bitmap(currentTheme.defaultWallpaper, Width, Height);
            //Start Menu Color - Commented until it works reliably
            //startmenuitems.Renderer = new MyRenderer();
            //ProgramsToolStripMenuItem.DropDown.Renderer = new MyRenderer();

            // Make Font Mandatory
            fontLoad();

            // Play Start Sound
            Stream audio = currentTheme.startSound;
            startsound = new SoundPlayer(audio);
            startsound.Play();

            // Hide the Startmenu
            startmenu.Hide();

            // Check for and set VM Mode
            if (this.FormBorderStyle != FormBorderStyle.None) Text = "Histacom2 - VM Mode";

            // Start the ClockTimer
            clockTimer.Start();

            //nonimportantapps.Capacity = 100;
            this.SendToBack();

            // Update the taskbar
            UpdateTaskbar();

            // Bring to this the front
            this.BringToFront();

            // Update the desktop Icons!

            ListViewItem lv = new ListViewItem("Recycle Bin", 7);
            desktopicons.Items.Add(lv);
            lv.Position = new Point(20, 20);
            desktopicons.Invalidate();
            //DesktopController.RefreshDesktopIcons(new ListViewItem[] { new System.Windows.Forms.ListViewItem("Recycle Bin", 7) }, ref desktopicons, Path.Combine(ProfileWindowsDirectory, "Desktop"));

            Hack4.StartObjective();
        }

        private void fontLoad()
        {
            this.desktopicons.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        #region StartMenu

        // StartButton Click
        private void startbutton_Click(object sender, EventArgs e)
        {
            startmenu.Show();
            startmenu.BringToFront();
            if (taskbar.Visible) taskbar.BringToFront();
        }

        // Shutdown button
        private void ShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGame();
            Program.ShutdownApplication(currentTheme.stopSound);
        }

        #endregion //Region

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
            startmenu.Hide();
            if (e.Button == MouseButtons.Right)
            {
                // Check if an item is selected and if so show the Delete option

                if (desktopicons.FocusedItem != null)
                {
                    deleteToolStripMenuItem.Visible = true;
                }
                else
                {
                    deleteToolStripMenuItem.Visible = false;
                }

                desktopupdate_Tick(null, null); // Update the Desktop Icons

                rightclickbackproperties.Show();
                rightclickbackproperties.BringToFront();
                rightclickbackproperties.Location = MousePosition;
            }

            // If 
            else if (e.Button == MouseButtons.Left)
            {
                rightclickbackproperties.Hide();
            }

            else if (e.Button == MouseButtons.Middle)
            {
                rightclickbackproperties.Hide();
            }
        }

        private void desktopicons_DoubleClick(object sender, EventArgs e)
        {
            Point objDrawingPoint = desktopicons.PointToClient(Cursor.Position);
            ListViewItem objListViewItem;

            if (objDrawingPoint != null)
            {
                objListViewItem = desktopicons.GetItemAt(objDrawingPoint.X, objDrawingPoint.Y);
                if (objListViewItem != null)
                {
                    if (objListViewItem.Text == "Time Distorter 0.3")
                    {
                        wm.InitXP(new WinClassicTimeDistorter3Bad(), "Time Distorter 0.3", Properties.Resources.TimeDistorter3Icon, false, false, false, false);
                        /*if (ie != null) { wm.StartInfobox95("Error Opening Internet Explorer", "An instance of Internet Explorer 4 is already open.", InfoboxType.Warning, InfoboxButtons.OK); return; }
                        ie = wm.Init(new WinClassicIE4(), "Internet Explorer 4", Properties.Resources.Win95IconIE4, true, true);
                        AddTaskBarItem(ie, ie.Tag.ToString(), "Internet Explorer 4", Properties.Resources.Win95IconIE4);
                        ie.BringToFront();
                        ie.FormClosing += new FormClosingEventHandler(InternetExplorer4_Closing);*/
                        startmenu.Hide();
                    }
                    else if (objListViewItem.Text == "Recycle Bin")
                    {

                    }
                }
            }
        }

        public void AddTaskBarItem(Form Application, string ApplicationID, string ApplicationName, Image ApplicationIcon)
        {
            taskbarItems = tb.AddTaskbarItem95(ApplicationID, ApplicationName, ApplicationIcon, (UserControl)new Win95TaskBarItem(), taskbarItems);
            Application.FormClosed += new FormClosedEventHandler(UpdateTaskbarFromClosedApplication);
        }

        public void UpdateTaskbarFromClosedApplication(object sender, FormClosedEventArgs e)
        {
            UpdateTaskbar();
        }

        public void UpdateTaskbar()
        {
            // Clears out all the items on the taskbar
            taskbarItems.Controls.Clear();

            // Loops through all the Applications which are open

            foreach (Form form in tb.GetAllOpenApps())
            {
                // Calls that "AddToTaskbar" thing
                taskbarItems = tb.AddTaskbarItem95(form.Tag.ToString(), form.Text.ToString(), form.Icon.ToBitmap(), new Win95TaskBarItem(), taskbarItems);
            }
        }

        private void desktopupdate_Tick(object sender, EventArgs e)
        {
            //desktopicons.Items[0].Position = new Point(this.Width - 50, this.Height - 80);
            /*
            DesktopController.RefreshDesktopIcons(new ListViewItem[] { new System.Windows.Forms.ListViewItem("My Computer", 0),
            new System.Windows.Forms.ListViewItem("Network Neighborhood", 5),
            new System.Windows.Forms.ListViewItem("Inbox", 3),
            new System.Windows.Forms.ListViewItem("Recycle Bin", 7),
            new System.Windows.Forms.ListViewItem("Internet Explorer", 2),
            new System.Windows.Forms.ListViewItem("Online Services", 1),
            new System.Windows.Forms.ListViewItem("Set Up The Microsoft Network", 4),
            new System.Windows.Forms.ListViewItem("Outlook Express", 6) }, ref desktopicons, Path.Combine(ProfileWindowsDirectory, "Desktop"));
            */
        }

        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(ProfileWindowsDirectory, "Desktop", "New Folder")))
            {
                //wm.StartAboutBox95("Windows Explorer", "A folder called New Folder already exists - please rename it.", Properties.Resources.Win95Error);
            }
            else
            {
                SaveDirectoryInfo(Path.Combine(ProfileWindowsDirectory, "Desktop"), "New Folder", false, "New folder", true);
            }
        }

        private void TextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(ProfileWindowsDirectory, "Desktop", "New Text Document.txt")))
            {
                //wm.StartAboutBox95("Windows Explorer", "A folder called New Text Document already exists - please rename it.", Properties.Resources.Win95Error);
            }
            else
            {
                File.Create(Path.Combine(ProfileWindowsDirectory, "Desktop", "New Text Document.txt"));
            }

            desktopupdate_Tick(null, null); // Update the Desktop Icons
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point objDrawingPoint = desktopicons.PointToClient(Cursor.Position);
            ListViewItem objListViewItem;

            if (objDrawingPoint != null)
            {
                objListViewItem = desktopicons.GetItemAt(objDrawingPoint.X, objDrawingPoint.Y);
                if (objListViewItem != null)
                {
                    if (objListViewItem.Tag != null)
                    {
                        if (Directory.Exists(objListViewItem.Tag.ToString()))
                        {
                            Directory.Delete(objListViewItem.Tag.ToString(), true);
                            desktopupdate_Tick(null, null); // Update the desktop Icons
                        }
                        else
                        {
                            if (File.Exists(objListViewItem.Tag.ToString()))
                            {
                                File.Delete(objListViewItem.Tag.ToString());
                                desktopupdate_Tick(null, null); // Update the desktop Icons
                            }
                            else wm.StartInfobox95("Windows Explorer", "This object cannot be deleted.", InfoboxType.Error, InfoboxButtons.OK);
                        }
                    }
                    else wm.StartInfobox95("Windows Explorer", "This object cannot be deleted.", InfoboxType.Error, InfoboxButtons.OK);
                }
            }
        }

        private void classicStartMenuItem1_Click(object sender, EventArgs e)
        {
            wm.InitXP(new WinClassicIE6Bad(), "Internet Explorer 6", Properties.Resources.WinXPIE6Icon, true, true);
            startmenu.Hide();
            startbutton.Enabled = false;
            clockTimer.Enabled = false;
        }
    }
}

