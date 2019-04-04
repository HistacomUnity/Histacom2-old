using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Histacom2.Engine.SaveSystem;
using System.IO;

namespace Histacom2
{
    public partial class LoadGameProfileItem : UserControl, IMessageFilter
    {
        public bool OnceRemoveHeight = false;
        public bool OnceAddHeight = false;
        public bool RequestingNewName = false;
        public LoadGameProfileItem()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        //private void LoadGameProfileItem_MouseHover(object sender, EventArgs e)
        //{
        //    exampleTop.Show();
        //    this.Height += 28;
        //    OnceRemoveHeight = false;
        //}

        public bool PreFilterMessage(ref Message m)
        {
            var mouseLocation = Cursor.Position;

            if (!ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                sidebar.Hide();
                if (!OnceRemoveHeight)
                {
                    profileName.Padding = new Padding(44, 44, 44, 44);
                    OnceRemoveHeight = true;
                    profileName.BackColor = Color.FromArgb(255, 51, 153, 255);
                    sidebar.BackColor = Color.FromArgb(255, 51, 153, 255);
                    pnlConfirm.BackColor = Color.FromArgb(255, 51, 153, 255);
                    pnlConfirm.Hide();
                }
                OnceAddHeight = false;
            } else
            {
                sidebar.Show();
                if (!OnceAddHeight)
                {
                    profileName.Padding = new Padding(3, 3, 3, 3);
                    OnceAddHeight = true;
                    profileName.BackColor = Color.FromArgb(255, 89, 172, 255);
                    sidebar.BackColor = Color.FromArgb(255, 89, 172, 255);
                    pnlConfirm.BackColor = Color.FromArgb(255, 89, 172, 255);
                }             
                OnceRemoveHeight = false;
            }

            if (m.Msg != 0x20a) // Scrolling Message
            {
                return false;//ignore message
            }
            return false;
        }

        private void LoadGameProfileItem_Paint(object sender, PaintEventArgs e)
        {
            profileName.Text = this.Tag.ToString();
        }

        private void exampleLoadProfile_Click(object sender, EventArgs e)
        {
            ((LoadGameDialog)this.TopLevelControl).ChooseProfile(this.Tag.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteProfile();
        }

        void DeleteProfile()
        {
            if (Directory.Exists(Path.Combine(AllProfilesDirectory, this.Tag.ToString())))
            {
                Directory.Delete(Path.Combine(AllProfilesDirectory, this.Tag.ToString()), true);
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!RequestingNewName)
                {
                    if (txtProfileName.Text == "")
                    {
                        MessageBox.Show("New profile name cannot be empty!");
                    }
                    else
                    {
                        if (txtProfileName.Text.Length > 20)
                        {
                            MessageBox.Show("The profile name cannot be longer than 20 characters");
                        }
                        else
                        {
                            if (Directory.Exists(Path.Combine(AllProfilesDirectory, txtProfileName.Text)))
                            {
                                MessageBox.Show("That profile already exists");
                            }
                            else
                            {
                                Directory.Move(Path.Combine(AllProfilesDirectory, this.Tag.ToString()), Path.Combine(AllProfilesDirectory, txtProfileName.Text));
                                this.Tag = txtProfileName.Text;
                                this.Invalidate();
                            }
                        }
                    }
                }
                pnlConfirm.Hide();
            } catch
            {
                
            }
        }

        private void exampleDelete_Click(object sender, EventArgs e)
        {
            lblProfile.Text = "Are you really sure you want to delete this profile?";
            btnYes.Show();
            txtProfileName.Hide();
            btnNo.Text = "No";
            RequestingNewName = false;
            pnlConfirm.Show();         
        }

        private void exampleNameBtn_Click(object sender, EventArgs e)
        {
            lblProfile.Text = "Enter a new profile name: ";
            btnYes.Hide();
            txtProfileName.Show();
            btnNo.Text = "OK";
            RequestingNewName = true;
            pnlConfirm.Show();
        }
    }
}
