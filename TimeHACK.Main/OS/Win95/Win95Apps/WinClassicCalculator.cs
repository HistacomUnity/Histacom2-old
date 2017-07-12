using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicCalculator : UserControl
    {
        public WinClassicCalculator()
        {
            InitializeComponent();
        }
        public double prevnum = 0;
        public bool iszero = true;
        public bool neg = false;
        public bool isdecimal = false;
        public string coperator;
        public void appendnum(string num)
        {
            if (iszero == true)
            {
                txtNumbers.Clear();
                txtNumbers.Text += (num);
                iszero = false;
            }
            else
            {
                if (iszero == false)
                {
                    txtNumbers.Text += (num);
                }
            }

        }
        private void Button6_Click(object sender, EventArgs e)
        {
            appendnum("1");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            appendnum("2");
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            appendnum("3");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            appendnum("4");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            appendnum("5");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            appendnum("6");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            appendnum("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            appendnum("8");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            appendnum("9");
        }

        private void Button16_Click(object sender, EventArgs e)
        {

            if (iszero == false)
            {
                txtNumbers.Text += (0);
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text != "0")
            {
                txtNumbers.Text = txtNumbers.Text.Remove(txtNumbers.Text.Length - 1);
            }
            if (txtNumbers.TextLength < 1)
            {
                txtNumbers.Text = "0";
            }

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (neg == false)
            {
                txtNumbers.Text = "-" + txtNumbers.Text;
                neg = true;
            }
            else
            {
                txtNumbers.Text = txtNumbers.Text.Replace("-", "");
                neg = false;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {

            if (isdecimal == false)
            {
                appendnum(".");
                isdecimal = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtNumbers.Text.Contains(".") == false)
            {
                isdecimal = false;
            }
            if (txtNumbers.Text == "0")
            {
                iszero = true;
            }
        }

        private void WinClassicCalculator_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AboutCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindowManager wm = new WindowManager();
            wm.StartAboutBox95("Calculator", null, Properties.Resources.WinClassicCalc);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            prevnum = 0;
            txtNumbers.Text = "0";
            isdecimal = false;
            iszero = true;
            neg = false;
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            txtNumbers.Text = "0";
            isdecimal = false;
            iszero = true;
            neg = false;
        }
        public void Calculate()
        {
            switch (coperator)
            {
                case "+":
                    txtNumbers.Text = (prevnum + double.Parse(txtNumbers.Text)).ToString();
                    prevnum = double.Parse(txtNumbers.Text);
                    break;
                case "-":
                    if (prevnum == 0)
                    {
                        break;
                    }
                    txtNumbers.Text = (prevnum - double.Parse(txtNumbers.Text)).ToString();
                    prevnum = double.Parse(txtNumbers.Text);
                    break;
                case "*":
                    if (prevnum == 0)
                    {
                        break;
                    }
                    txtNumbers.Text = (prevnum * double.Parse(txtNumbers.Text)).ToString();
                    prevnum = double.Parse(txtNumbers.Text);
                    break;
                case "/":
                    if (prevnum == 0)
                    {
                        break;
                    }
                    txtNumbers.Text = (prevnum / double.Parse(txtNumbers.Text)).ToString();
                    prevnum = double.Parse(txtNumbers.Text);
                    break;
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(txtNumbers.Text);
            txtNumbers.Text = Math.Sqrt(sq).ToString();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            coperator = "+";
            Calculate();
            prevnum = double.Parse(txtNumbers.Text);
            txtNumbers.Text = "0";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            coperator = "-";
            Calculate();
            prevnum = double.Parse(txtNumbers.Text);
            txtNumbers.Text = "0";
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            coperator = "*";
            Calculate();
            prevnum = double.Parse(txtNumbers.Text);
            txtNumbers.Text = "0";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            coperator = "/";
            Calculate();
            prevnum = double.Parse(txtNumbers.Text);
            txtNumbers.Text = "0";
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtNumbers.Text));
            txtNumbers.Text = Convert.ToString(a);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtNumbers.Text) / Convert.ToDouble(100);
            txtNumbers.Text = Convert.ToString(a);
        }

        private void Button12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
