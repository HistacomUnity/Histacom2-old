using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine;
using Newtonsoft.Json;
using static Histacom2.Engine.SaveSystem;
using System.IO;

namespace Histacom2
{
    public partial class NewGameDialog : Form
    {
        public bool Successful = false;
        public NewGameDialog()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can choose a profile name - this will create a new profile! Whenever you want to Load a game, click 'Load Game' and then choose a profile (You can have as many profiles as you want)");
        }

        private void btnCancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The game's profiles are stored in your AppData /Histacom2/Profiles - the rest is for you to figure out!");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProfName.Text != "")
                {
                    if (!(txtProfName.Text.Length > 20))
                    {
                        ProfileName = txtProfName.Text;
                        if (DevMode)
                        {
                            if (Directory.Exists(ProfileDirectory))
                            {
                                Directory.Delete(ProfileDirectory, true);
                                Successful = true;
                                this.Close();
                            }
                        }

                        if (!Directory.Exists(ProfileDirectory))
                        {
                            Successful = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("That profile already exists! \n USEFUL INFO: Use 'Load Game' to manage your profiles - from there you can delete the profile!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The profile name cannot be longer than 20 characters");
                    }

                }
                else
                {
                    MessageBox.Show("You must enter a profile name!");
                }
            } catch
            {

            }
        }

        private void NewGameDialog_Load(object sender, EventArgs e)
        {
            if (DevMode)
            {
                btnDevMode.Show();
            }
        }

        private void btnDevMode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DevMode (Development Mode) is a special mode that lets you test features without having a large amount of accounts just to test a new feature. How it works is simple:" +
                "\n1. It checks for a profile of the same name.\n2. If so, it deletes the profile and starts a new game.\n3. If not, then it starts a new game.");
        }

        private void txtProfName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk_Click(null, null);
            }
        }
    }
}
