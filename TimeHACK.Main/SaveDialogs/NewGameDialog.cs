using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;
using Newtonsoft.Json;
using static TimeHACK.Engine.SaveSystem;
using System.IO;

namespace TimeHACK
{
    public partial class NewGameDialog : Form
    {
        public Boolean Successful = false;
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
            MessageBox.Show("The game's profiles are stored in your Documents /TimeHACK/Profiles - the rest is for you to figure out!");
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
                        if (DevMode == true)
                            if (Directory.Exists(ProfileDirectory))
                            {
                                Directory.Delete(ProfileDirectory, true);
                                Successful = true;
                                this.Close();
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
            } catch (Exception ex)
            {

            }
        }

        private void NewGameDialog_Load(object sender, EventArgs e)
        {
            if (DevMode == true)
            {
                btnDevMode.Show();
            }
        }

        private void btnDevMode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DevMode is a mode Designed for Development of the game, if you are seeing this that means it is activated! All DevMode does is if a Profile already exists then rather than asking you to choose a different name it just " +
                "deletes the old one! This means that you won't have 1 million profiles everytime you want to test something in the game!");
        }
    }
}
