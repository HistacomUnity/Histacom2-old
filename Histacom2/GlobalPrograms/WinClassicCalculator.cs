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

namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class WinClassicCalculator : UserControl
    {
        double prevnum = 0;
        string operation = "";
        bool operation_pressed = false;
        public WinClassicCalculator()
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    c.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
                }
                else
                {
                    c.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
            txtNumbers.Paint += (sender, args) => Paintbrush.PaintClassicBordersIndented(sender, args, 2);
        }
        private void number_click(object sender, EventArgs e)
        {
            if (txtNumbers.Text.Contains("∞"))
                txtNumbers.Clear();
             if ((txtNumbers.Text == "0") || (operation_pressed))
                txtNumbers.Text = "";
            operation_pressed = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtNumbers.Text.Contains("."))
                    txtNumbers.Text = txtNumbers.Text + num.Text;
            }
            else
                txtNumbers.Text = txtNumbers.Text + num.Text;
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            txtNumbers.Text = "0";
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            prevnum = 0;
            operation = "";
            operation_pressed = false;
            txtNumbers.Text = "0";
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text.Length>0)
            {
                txtNumbers.Text = txtNumbers.Text.Remove(txtNumbers.Text.Length - 1, 1);
            }
            if (txtNumbers.Text =="")
            {
                txtNumbers.Text = "0";
            }
        }

        private void arithmitic_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtNumbers.Text.Contains("∞"))
                txtNumbers.Clear();
            if (prevnum != 0)
            {
                if (num.Text == "sqrt")
                    prevnum = Math.Sqrt(double.Parse(txtNumbers.Text));
                if (num.Text == "1/x")
                    prevnum = Convert.ToDouble(1.0 / Convert.ToDouble(txtNumbers.Text));
                if (num.Text == "%")
                    prevnum = Convert.ToDouble(txtNumbers.Text) / 100;
                Button21.PerformClick();
                operation = num.Text;
                operation_pressed = true;
            }
            else if (num.Text == "sqrt")
            {
                prevnum = Math.Sqrt(double.Parse(txtNumbers.Text));
                txtNumbers.Text = prevnum.ToString();
            }
            else if (num.Text == "1/x")
            {
                prevnum = Convert.ToDouble(1.0 / Convert.ToDouble(txtNumbers.Text));
                txtNumbers.Text = prevnum.ToString();
            }
            else if (num.Text == "%")
            {
                prevnum = Convert.ToDouble(txtNumbers.Text) / 100;
                txtNumbers.Text = prevnum.ToString();
            }
            else
            {
                operation = num.Text;
                prevnum = double.Parse(txtNumbers.Text);
                txtNumbers.Text = "0";
                operation_pressed = true;
            }
        }
         
        private void Button21_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text.Contains("∞"))
                txtNumbers.Clear();
            switch (operation)
            {
                case "+":
                    txtNumbers.Text = (prevnum + double.Parse(txtNumbers.Text)).ToString();
                    break;
                case "-":
                    txtNumbers.Text = (prevnum - double.Parse(txtNumbers.Text)).ToString();
                    break;
                case "*":
                    txtNumbers.Text = (prevnum * double.Parse(txtNumbers.Text)).ToString();
                    break;
                case "/":
                    txtNumbers.Text = (prevnum / double.Parse(txtNumbers.Text)).ToString();
                    break;
            }
            prevnum = Int32.Parse(txtNumbers.Text);
            operation = "";
        }

        private void AboutCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            wm.StartAboutBox95("Calculator", "Microsoft Calculator", Properties.Resources.WinClassicCalc);
        }

        private void Button15_Click(object sender, EventArgs e)
        {

        }

        private void CopyCtrlCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtNumbers.Copy();
        }

        private void PasteCtrlVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string pasteText = Clipboard.GetText();
            string strippedText = "";
            for (int i = 0; i < pasteText.Length; i++)
            {
                if (char.IsDigit(pasteText[i]))
                    strippedText += pasteText[i].ToString();
                MessageBox.Show("Test");
            }
            if (strippedText!=pasteText)
            {
                txtNumbers.Text = pasteText;
            }
        }

    }
}
