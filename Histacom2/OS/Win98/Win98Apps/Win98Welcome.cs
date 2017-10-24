using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.Win98.Win98Apps
{
    public partial class Win98Welcome : UserControl
    {
        public Win98Welcome()
        {
            InitializeComponent();
        }

        private void classicButton1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
