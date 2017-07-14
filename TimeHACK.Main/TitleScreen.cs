using TimeHACK.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TimeHACK.OS.Win95;
using TimeHACK.OS.Win98;
using TimeHACK.Engine;
using static TimeHACK.Engine.SaveSystem;
using TimeHACK.SaveDialogs;
using System.Runtime.InteropServices;
using System.Reflection;
using System.ComponentModel;

namespace TimeHACK
{
    public partial class TitleScreen : Form
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();

        public static Windows95 frm95;
        public static Windows98 frm98;
        public static string username;
        public static string progress = "95";

        public static DirectoryInfo thfolder;
        public static DirectoryInfo datafolder;
        public static DirectoryInfo profilefolder;
        public static NewGameDialog newGameBox;
        public static LoadGameDialog loadGameBox;

        // Border stuff

        public bool max = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public TitleScreen()
        {
            InitializeComponent();
            this.startmenu.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
        }

        public void StartGame()
        {
            //TODO: You may want to handle story stuff to decide what OS to boot here.
            if (Convert.ToInt32(VM_Width.Text) == 1337 && Convert.ToInt32(VM_Height.Text) == 1337)
            {
                leet();
            }
            else
            {
                // Time to decide which OS to start up!

                switch (CurrentSave.CurrentOS)
                {
                    case "95":
                        frm95 = new Windows95();
                        frm95.TopMost = true;
                        frm95.FormBorderStyle = FormBorderStyle.None;
                        frm95.WindowState = FormWindowState.Maximized;
                        //if (vm_mode.Checked == true)
                        //{
                        //    frm95.Size = new Size(Convert.ToInt32(VM_Width.Text), Convert.ToInt32(VM_Height.Text));
                        //    frm95.FormBorderStyle = FormBorderStyle.Fixed3D;
                        //}
                        frm95.Show();
                        Hide();

                        break;
                    case "98":
                        frm98 = new Windows98();
                        frm98.TopMost = true;
                        frm98.FormBorderStyle = FormBorderStyle.None;
                        frm98.WindowState = FormWindowState.Maximized;
                        //if (vm_mode.Checked == true)
                        //{
                        //    frm98.Size = new Size(Convert.ToInt32(VM_Width.Text), Convert.ToInt32(VM_Height.Text));
                        //    frm98.FormBorderStyle = FormBorderStyle.Fixed3D;
                        //}
                        frm98.Show();
                        Hide();

                        break;
                    default:
                        MessageBox.Show("WARNING! It looks like this save is corrupt!");
                        MessageBox.Show("We will now open the Save troubleshooter");

                        SaveFileTroubleShooter troubleshooter = new SaveFileTroubleShooter();

                        troubleshooter.ShowDialog();
                        break;
                }

            }
        }

        void closeButton(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VM_WidthHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // When the TitleScreen Loads
        private void TitleScreen_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(GameDirectory))
                Directory.CreateDirectory(GameDirectory);
            thfolder = new DirectoryInfo(GameDirectory);

            string Data = Path.Combine(thfolder.FullName, "Data");
            if (!Directory.Exists(Data))
                Directory.CreateDirectory(Data);

            string Profiles = Path.Combine(thfolder.FullName, "Profiles");
            if (!Directory.Exists(Profiles))
                Directory.CreateDirectory(Profiles);

            Resources.google.Save(Path.Combine(Data, "google.jpg"));
            profilefolder = Directory.CreateDirectory(Path.Combine(thfolder.FullName, "\\Profiles"));



            // Set GameVersion
            gameversion.Text = Program.gameID;

            // Initialize Font
            File.WriteAllBytes(Data + "\\LeviWindows.ttf", Resources.LeviWindows);
            File.WriteAllBytes(Data + "\\windows_command_prompt.ttf", Resources.windows_command_prompt);
            pfc.AddFontFile(Data + "\\LeviWindows.ttf");
            pfc.AddFontFile(Data + "\\windows_command_prompt.ttf");
            gameversion.Font = new Font(pfc.Families[0], 16F, FontStyle.Bold, GraphicsUnit.Point, (0));
            ProgramsToolStripMenuItem.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            DocumentsToolStripMenuItem.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            SettingsToolStripMenuItem.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            HelpToolStripMenuItem.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            ShutdownToolStripMenuItem.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // Start the VM Mode timer
            vmModeTimer.Start();
        }

        private static void leet()
        {
            WindowManager wm = new WindowManager();
            UserControl leet = new UserControl();
            leet.Width = 500;
            leet.Height = 500;
            Label label1 = new Label();
            label1.Parent = leet;
            label1.AutoSize = true;
            label1.Text = "Thank you for making TimeHACK possible.";
            wm.StartWin95(leet, "Thank You", null, true, true);
        }

        // The VM Mode timer / checker. Updates every 100ms
        private void vmModeTimer_Tick(object sender, EventArgs e)
        {
            // Check for VM mode
            if (vm_mode.Checked == true)
            {
                VM_Width.Visible = true;
                VM_Height.Visible = true;
            }
            // If VM Mode is disabled
            else
            {
                VM_Width.Visible = false;
                VM_Height.Visible = false;
            }
        }

        #region Menu Buttons

        #region NewGame

        // When NewGame is Clicked
        private void NewGame_Click(object sender, EventArgs e)
        {
            newGameBox = new NewGameDialog();
            newGameBox.ShowDialog();

            if (newGameBox.Successful == true)
            {
                NewGame();
                StartGame();
            }
        }

        public void BSODRewind(object sender, EventArgs e)
        {
            if (progress == "95")
            {
                frm95.Close();
                frm95 = null;

                try
                {
                    // Time to close all the game applications
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm.Tag.ToString() != "ignoreFormOnTaskbar")
                        {
                            frm.Close();
                        }
                    }
                } catch {

                }
                


                // If VM Mode is not enabled
                if (vm_mode.Checked != true)
                {
                    // Generate fullscreen desktop
                    frm95 = new Windows95();
                    frm95.TopMost = true;
                    frm95.FormBorderStyle = FormBorderStyle.None;
                    frm95.WindowState = FormWindowState.Maximized;
                    frm95.Show();
                    Hide();
                }
                // If VM Mode is enabled
                else
                {
                    // Generate desktop with size entered by user
                    frm95 = new Windows95();
                    frm95.FormBorderStyle = FormBorderStyle.None;
                    frm95.Size = new Size(Convert.ToInt32(VM_Width.Text), Convert.ToInt32(VM_Height.Text));
                    frm95.FormBorderStyle = FormBorderStyle.Fixed3D;
                    frm95.Show();
                    Hide();
                }
            }
        }
        #endregion

        #region LoadGame
        private void LoadGame_Click(object sender, EventArgs e)
        {
            loadGameBox = new LoadGameDialog();
            loadGameBox.ShowDialog();

            //var result = LoadSave();
            //if(result == false)
            //{
            //    MessageBox.Show(caption: "No save found.", text: "No save was found on your system. However, we have created a new one, and we will start it up for you.");
            //}
            if (loadGameBox.successful == true)
            {
                LoadSave();
                SetTheme();
                StartGame();
            }            
        }
        #endregion

        #region ExitButton
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #endregion

        private void gameversion_MouseHover(object sender, EventArgs e)
        {
            gameversion.Text = "There are no easter eggs here!";
        }

        private void gameversion_MouseLeave(object sender, EventArgs e)
        {
            gameversion.Text = Program.gameID;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            if (DevMode == true)
            {
                DevMode = false;
                gameversion.Text = "Developer Mode Deactivated";
            } else {
                DevMode = true;
                gameversion.Text = "Developer Mode Activated";
            }
            
        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateText_Tick(object sender, EventArgs e)
        {
            if (gameversion.Text != Program.gameID)
            {
                gameversion.Text = Program.gameID;
                updateText.Stop();
            }
        }
    }
}
