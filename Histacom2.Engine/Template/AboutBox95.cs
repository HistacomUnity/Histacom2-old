using System;
using System.Windows.Forms;

namespace Histacom2.Engine.Template
{
    public partial class AboutBox95 : UserControl
    {
        public AboutBox95()
        {
            InitializeComponent();
            this.textBox2.Text = "This product is licensed to:\r\n" + Environment.UserName + "\r\n";
        }

        private void classicButton1_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
