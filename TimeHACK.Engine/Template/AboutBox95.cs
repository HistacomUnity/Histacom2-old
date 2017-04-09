using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace TimeHACK.Engine.Template
{
    public partial class AboutBox95 : UserControl
    {
        public AboutBox95()
        {
            InitializeComponent();
            this.textBox2.Text = "This product is licensed to:\r\n" + Environment.UserName + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
