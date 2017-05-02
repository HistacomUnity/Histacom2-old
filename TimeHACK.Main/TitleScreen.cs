using TimeHACK.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TimeHACK.OS.Win95;
using TimeHACK.Engine;

namespace TimeHACK
{
    public partial class TitleScreen : Form
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
        public static Windows95 frm95;
        public static string username;
        public static string progress = "95";

        public static DirectoryInfo thfolder;
        public static DirectoryInfo datafolder;
        public static DirectoryInfo profilefolder;

        public TitleScreen()
        {
            InitializeComponent();
            if (!Directory.Exists("C:\\TimeHackData")) thfolder = Directory.CreateDirectory("C:\\TimeHackData");
            else thfolder = new DirectoryInfo("C:\\TimeHackData");
            datafolder = Directory.CreateDirectory(thfolder.FullName + "\\Data");
            Resources.google.Save(datafolder.FullName + "\\google.jpg");
            profilefolder = Directory.CreateDirectory(thfolder.FullName + "\\Profiles");
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

            // Set GameVersion
            gameversion.Text = "TimeHACK " + Program.gameID;

            // Initialize Font
            pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\LeviWindows.ttf");
            pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\windows_command_prompt.ttf");
            gameversion.Font = new Font(pfc.Families[0], 16F, FontStyle.Bold, GraphicsUnit.Point, (0));

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
            wm.startWin95(leet, "Thank You", null, true, true);
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
            if (Convert.ToInt32(VM_Width.Text) == 1337 && Convert.ToInt32(VM_Height.Text) == 1337)
            {
                leet();
            }
            else
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

        public void BSODRewind(object sender, EventArgs e)
        {
            if (progress == "95")
            {
                frm95.Close();
                frm95 = null;

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

        private void NewGame_MouseEnter(object sender, EventArgs e)
        {
            NewGame.Image = Resources.MSNewGame;
        }
        private void NewGame_MouseLeave(object sender, EventArgs e)
        {
            NewGame.Image = Resources.NewGame;
        }
        #endregion

        #region LoadGame
        private void LoadGame_Click(object sender, EventArgs e)
        {

        }
        private void LoadGame_Enter(object sender, EventArgs e)
        {
            LoadGame.Image = Resources.MSLoadGame;
        }
        private void LoadGame_Leave(object sender, EventArgs e)
        {
            LoadGame.Image = Resources.LoadGame;
        }
        #endregion

        #region ExitButton
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Exit_Enter(object sender, EventArgs e)
        {
            Exit.Image = Resources.MSExit;
        }
        private void Exit_Leave(object sender, EventArgs e)
        {
            Exit.Image = Resources.Exit;
        }
        #endregion

        #endregion

        private void gameversion_MouseHover(object sender, EventArgs e)
        {
            gameversion.Text = "There are no easter eggs here!";
        }

        private void gameversion_MouseLeave(object sender, EventArgs e)
        {
            gameversion.Text = "TimeHACK " + Program.gameID;
        }
    }
}
