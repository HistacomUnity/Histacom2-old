using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class FRMWinClassicAddressBookNewContact : UserControl
    {
        public AddressBookContact toSet = new AddressBookContact();
        public FRMWinClassicAddressBookNewContact()
        {
            InitializeComponent();
            Program.AddressBookSelectedContact = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAdd.Show();
            pnlAdd.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text != "" && txtMiddle.Text != "" && txtLast.Text != "")
            {
                toSet.FirstName = txtFirst.Text;
                toSet.MiddleName = txtMiddle.Text;
                toSet.LastName = txtLast.Text;

                Program.AddressBookSelectedContact = toSet;
                ((Form)this.TopLevelControl).Close();
            } else {
                MessageBox.Show("Please fill out the First, Middle and Last name.");
            }           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emails.Items.Add(textBox1.Text);
            toSet.Emails.Add(textBox1.Text);
            emails.BringToFront();
        }

        private void FRMWinClassicAddressBookNewContact_Load(object sender, EventArgs e)
        {
            if (toSet != null)
            {
                txtFirst.Text = toSet.FirstName;
                txtMiddle.Text = toSet.MiddleName;
                txtLast.Text = toSet.LastName;
                if (toSet.Emails != null)
                {
                    foreach (string email in toSet.Emails)
                    {
                        emails.Items.Add(email);
                    }
                }
            } else
            {
                MessageBox.Show("NULL CONTACT!");
            }
        }
    }
}
