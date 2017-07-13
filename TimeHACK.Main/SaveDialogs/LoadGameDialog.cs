using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static TimeHACK.Engine.SaveSystem;

namespace TimeHACK
{
    public partial class LoadGameDialog : Form
    {
        public bool successful = false;
        public LoadGameDialog()
        {
            InitializeComponent();
        }

        public void ChooseProfile(string SelectedProfile)
        {
            ProfileName = SelectedProfile;
            successful = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can control all your profiles! Use can open a profile by hovering over it and clicking 'Load Profile!'");
        }

        private void LoadGameDialog_Load(object sender, EventArgs e)
        {
            foreach (string dir in Directory.GetDirectories(AllProfilesDirectory))
            {
                LoadGameProfileItem newItem = new LoadGameProfileItem();
                newItem.Tag = Path.GetFileName(dir);
                newItem.Dock = DockStyle.Top;
                Profiles.Controls.Add(newItem);
                newItem.Show();
            }
        }
    }
}
