using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine;

namespace Histacom2.OS.Win95.Win95Apps.MineSweeper
{
    public partial class CustomMinefield : UserControl
    {
        private WinClassicMinesweeper _wcm;
        private WindowManager wm;

        public CustomMinefield(WinClassicMinesweeper wcm)
        {
            InitializeComponent();
            _wcm = wcm;
            wm = new WindowManager();
            for (int i = 8; i < 31; i++) comboBox1.Items.Add(i);
            for (int i = 8; i < 25; i++) comboBox2.Items.Add(i);
            for (int i = 10; i < 668; i++) comboBox3.Items.Add(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)comboBox1.SelectedItem * (int)comboBox2.SelectedItem <= (int)comboBox3.SelectedItem) wm.StartInfobox95("Oops!", "Too many mines!", Engine.Template.InfoboxType.Warning, Engine.Template.InfoboxButtons.OK);
            else
            {
                _wcm.customwidth = (int)comboBox1.SelectedItem;
                _wcm.customheight = (int)comboBox2.SelectedItem;
                _wcm.custommines = (int)comboBox3.SelectedItem;
                _wcm.calculateFormSize((int)comboBox1.SelectedItem, (int)comboBox2.SelectedItem);
                this.ParentForm.Close();
            }
        }
    }
}
