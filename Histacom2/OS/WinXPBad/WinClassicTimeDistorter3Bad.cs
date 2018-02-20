using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.WinXPBad
{
    public partial class WinClassicTimeDistorter3Bad : UserControl
    {
        public int secsLeft = 60;

        public WinClassicTimeDistorter3Bad()
        {
            InitializeComponent();
        }

        private void buttonXP1_Click(object sender, EventArgs e)
        {
            buttonXP1.Hide();
            buttonXP2.Hide();
            timer1.Start();
        }

        private void buttonXP2_Click(object sender, EventArgs e)
        {
            buttonXP1.Hide();
            buttonXP2.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = secsLeft--.ToString();
        }
    }
}
