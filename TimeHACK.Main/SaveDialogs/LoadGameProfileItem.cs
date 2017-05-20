using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeHACK.Engine.SaveSystem;
using System.IO;

namespace TimeHACK
{
    public partial class LoadGameProfileItem : UserControl, IMessageFilter
    {
        public Boolean OnceRemoveHeight = false;
        public Boolean OnceAddHeight = false;
        public Boolean RequestingNewName = false;
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
                if (OnceRemoveHeight == false)
                {
                    this.Height -= 28;
                    OnceRemoveHeight = true;
                    profileName.BackColor = Color.Gray;
                    sidebar.BackColor = Color.Gray;
                    pnlConfirm.BackColor = Color.Gray;
                }
                OnceAddHeight = false;
            } else
            {
                sidebar.Show();
                if (OnceAddHeight == false)
                {
                    this.Height += 28;
                    OnceAddHeight = true;
                    profileName.BackColor = Color.LightGray;
                    sidebar.BackColor = Color.LightGray;
                    pnlConfirm.BackColor = Color.LightGray;
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
                if (!RequestingNewName == false)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("New profile name cannot be empty!");
                    }
                    else
                    {
                        if (textBox1.Text.Length > 20)
                        {
                            MessageBox.Show("The profile name cannot be longer than 20 characters");
                        }
                        else
                        {
                            if (Directory.Exists(Path.Combine(AllProfilesDirectory, textBox1.Text)))
                            {
                                MessageBox.Show("That profile already exists");
                            }
                            else
                            {
                                Directory.Move(Path.Combine(AllProfilesDirectory, this.Tag.ToString()), Path.Combine(AllProfilesDirectory, textBox1.Text));
                                this.Tag = textBox1.Text;
                                this.Invalidate();
                            }
                        }
                    }
                }
                pnlConfirm.Hide();
            } catch (Exception ex)
            {
                
            }
        }

        private void exampleDelete_Click(object sender, EventArgs e)
        {
            label1.Text = "Are you really sure you want to delete this Profile?";
            button1.Show();
            textBox1.Hide();
            button2.Text = "No";
            RequestingNewName = false;
            pnlConfirm.Show();         
        }

        private void exampleNameBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter a new profile name: ";
            button1.Hide();
            textBox1.Show();
            button2.Text = "OK";
            RequestingNewName = true;
            pnlConfirm.Show();
        }
    }
}
