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
            ExitChat98Early
        }

        public Win9XBSOD throw9XBSOD(bool except, BSODCauses type)
        {
            pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\windows_command_prompt.ttf");
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
                case BSODCauses.ExitChat98Early:
                    bsod.textBox1.Text = "An unknown but fatal exception has occured has occured in the program \"wchat98.exe\". The current processes will be terminated.";
                    break;
                default:
                    break;
            }
            bsod.Show();
            return bsod;
        }
    }
}
