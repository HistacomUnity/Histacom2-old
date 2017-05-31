using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicFTPClient : UserControl
    {
        public WinClassicFTPClient()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hostnameBox.Text == "172.68.119.42")
            {
                infoLabel.Hide();
                if (usernameBox.Text == "12padams")
                {
                    infoLabel.Hide();
                    if (passBox.Text == "projectDeath98")
                    {
                        infoLabel.Hide();
                        infoLabel.ForeColor = Color.Green;
                        infoLabel.Text = "[200] OK";
                        welcomeLabel.Hide();
                        infoLabel.Show();
                    }
                    else
                    {
                        infoLabel.Text = "[430] Incorrect Password";
                        infoLabel.Show();
                    }
                }
                else
                {
                    infoLabel.Text = "[430] Incorrect Username";
                    infoLabel.Show();
                }
            }
            else
            {
                infoLabel.Text = "[404] Not Found";
                infoLabel.Show();
            }
        }

        private void ftpItems_Click(object sender, EventArgs e)
        {
            Point objDrawingPoint = ftpFiles.PointToClient(Cursor.Position);
            ListViewItem objListViewItem = new ListViewItem();
            if (objListViewItem.Text == "/software/")
            {

            }
        }
    }
}
