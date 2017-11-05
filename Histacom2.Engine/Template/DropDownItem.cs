using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.Template
{
    public partial class DropDownItem : UserControl
    {
        public UI.ClassicDropDown dpdw;
        public DropDownItem()
        {
            InitializeComponent();
        }

        public void ChangeText(string newText, Font fnt)
        {
            label1.Font = fnt;
            label1.Text = newText;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dpdw.ChooseItem(label1.Text);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }
    }
}
