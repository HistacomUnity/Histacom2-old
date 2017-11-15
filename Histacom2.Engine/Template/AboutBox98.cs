using System;
using System.Windows.Forms;

namespace Histacom2.Engine.Template
{
    public partial class AboutBox98 : UserControl
    {
        public AboutBox98()
        {
            InitializeComponent();
            this.textBox2.Text = "This product is licensed to:\r\n" + Environment.UserName + "\r\n";
            textBox1.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            textBox2.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            textBox3.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            textBox4.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
        }

        private void classicButton1_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
