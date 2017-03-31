using TimeHACK.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TimeHACK
{
    public partial class TitleScreen : Form
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
        public static Windows95 frm95;

        public TitleScreen()
        {
            InitializeComponent();
           
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // When the TitleScreen Loads
        private void TitleScreen_Load(object sender, EventArgs e)
        {
            // Set GameVersion
            gameversion.Text = "TimeHACK " + Program.gameID + " by TimeHACKDevs";

            // Initialize Font
            pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\LeviWindows.ttf");

            // Start the VM Mode timer
            vmModeTimer.Start();
        }

        // The VM Mode timer / checker. Updates every 100ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check for VM mode
            if (vm_mode.Checked == true)
            {
                widthBox.Visible = true;
                charX.Visible = true;
                heightBox.Visible = true;
            }
            // If VM Mode is disabled
            else
            {
                widthBox.Visible = false;
                charX.Visible = false;
                heightBox.Visible = false;
            }
        }

        #region Menu Buttons

        #region NewGame

        // When NewGame is Clicked
        private void NewGame_Click(object sender, EventArgs e)
        {
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
                // Check VM Mode Resolutions
                int parsedWidth = 0;
                int parsedHeight = 0;
                if (!int.TryParse(widthBox.Text, out parsedWidth))
                {
                    MessageBox.Show("'" + widthBox.Text + "' is not a valid value.");
                    Application.Restart();
                }
                if (!int.TryParse(heightBox.Text, out parsedHeight))
                {
                    MessageBox.Show("'" + heightBox.Text + "' is not a valid value.");
                    Application.Restart();
                }
                // Generate desktop with size entered by user
                Windows95 frm = new Windows95();
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Size = new Size(parsedWidth, parsedHeight);
                frm.FormBorderStyle = FormBorderStyle.Fixed3D;
                frm.Show();
                Hide();
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
            gameversion.Text = "TimeHACK " + Program.gameID + " by TimeHACKDevs";
        }
    }
}
