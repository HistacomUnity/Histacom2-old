using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.OS.Win95.Win95Apps.AddressBook
{
    public partial class FRMWinClassicAddressBookNewFolder : UserControl
    {
        
        public FRMWinClassicAddressBookNewFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.AddressBookSelectedFolderName = textBox1.Text;
            ((Form)this.TopLevelControl).Close();
        }
    }
}
