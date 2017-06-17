using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine.Template;

namespace TimeHACK.Engine
{
    public class BSODCreator
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();

        public enum BSODCauses
        {
            Testing,
            WimpEnding,
            PiracyEnding,
        }

        public Win9XBSOD throw9XBSOD(bool except, BSODCauses type)
        {
            pfc.AddFontFile(SaveSystem.GameDirectory + "\\Data\\windows_command_prompt.ttf");
            Win9XBSOD bsod = new Win9XBSOD();
            foreach (Control ctrl in bsod.Controls) {
                ctrl.Font = new System.Drawing.Font(pfc.Families[0], 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((0)));
            }
            bsod.TopMost = true;
            bsod.FormBorderStyle = FormBorderStyle.None;
            bsod.WindowState = FormWindowState.Maximized;
            switch (type)
            {
                case BSODCauses.Testing:
                    bsod.textBox1.Text = "This is the testing type of BSOD. Hurrah.";
                    break;
                case BSODCauses.WimpEnding:
                    bsod.textBox1.Text = "An unknown but fatal exception has occured in the program \"wchat98.exe\". The current processes will be terminated.";
                    break;
                case BSODCauses.PiracyEnding:
                    bsod.textBox1.Text = "Vital elements of Windows were removed, but recovered. However, your data has been lost.";
                    bsod.BackColor = System.Drawing.Color.Black;
                    foreach (Control ctrl in bsod.Controls) ctrl.ForeColor = System.Drawing.Color.Silver;
                    bsod.label1.BackColor = System.Drawing.Color.Silver;
                    bsod.label1.ForeColor = System.Drawing.Color.Black;
                    break;
                default:
                    break;
            }
            bsod.Show();
            return bsod;
        }
    }
}
