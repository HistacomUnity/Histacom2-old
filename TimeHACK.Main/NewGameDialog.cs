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

namespace TimeHACK
{
    public partial class NewGameDialog : Form
    {
        public NewGameDialog()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can choose a profile name - this will create a new profile! Whenever you want to Load a game, click 'Load Game' and then choose a profile (You can have as many prfiles as you want)");
        }

        private void btnCancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The game's profiles are stored in C:/TimeHACK/Profiles - the rest is for you to figure out!");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
