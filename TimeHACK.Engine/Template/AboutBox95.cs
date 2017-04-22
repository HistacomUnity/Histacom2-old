using System;
using System.Windows.Forms;

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
