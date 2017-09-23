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
    public partial class GuessTheNumber : UserControl
    {
        private Random rnd;
        private int num;

        public GuessTheNumber()
        {
            InitializeComponent();

            rnd = new Random();
            num = rnd.Next(0, 101);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = null;
            textBox1.Enabled = true;
            num = rnd.Next(0, 101);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try {
                int guess = int.Parse(textBox1.Text);

                if (guess < num) pictureBox2.BackgroundImage = Properties.Resources.GTN95_Higher;
                else if (guess > num) pictureBox2.BackgroundImage = Properties.Resources.GTN95_Lower;
                else if (guess == num)
                {
                    pictureBox2.BackgroundImage = Properties.Resources.GTN95_Correct;
                    textBox1.Enabled = false;
                }
            } catch
            {
                pictureBox2.BackgroundImage = Properties.Resources.GTN95_Error;
            }
        }
    }
}
