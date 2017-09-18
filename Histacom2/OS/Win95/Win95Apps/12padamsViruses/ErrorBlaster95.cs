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
using System.Drawing.Text;
using static Histacom2.Engine.SaveSystem;
    
namespace Histacom2.OS.Win95.Win95Apps._12padamViruses
{
    public partial class ErrorBlaster95 : UserControl
    {
        Timer messageGen = new Timer();
        Random messageChooser = new Random();
        WindowManager wm = new WindowManager();
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        public ErrorBlaster95()
        {
            InitializeComponent();
            messageGen.Interval = 3000;
            messageGen.Tick += MessageGen_Tick;
            pfc.AddFontFile(DataDirectory + "\\LeviWindows.ttf");
            label1.Font=new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void MessageGen_Tick(object sender, EventArgs e)
        {
            int messageRandomizer = messageChooser.Next(1, 3);
            switch (messageRandomizer)
            {
                case 1:
                    wm.StartInfobox95("Alert!", "A virus has been detected on your computer! Press OK to disinfect!", Engine.Template.InfoboxType.Error, Engine.Template.InfoboxButtons.OK);
                    messageGen.Interval -= 300;
                    break;

                case 2:
                    wm.StartInfobox95("Microsoft Security Alert", "Microsoft says to install UltraSurpremeAntiVirus1998 to get rid of any viruses!", Engine.Template.InfoboxType.Info, Engine.Template.InfoboxButtons.OK);
                    messageGen.Interval -= 300;
                    break;
                case 3:
                    wm.StartInfobox95("Error", "A BSOD.exe virus has been found on your computer!", Engine.Template.InfoboxType.Warning, Engine.Template.InfoboxButtons.OK);
                    messageGen.Interval -= 300;
                    break;
            }
            if (messageGen.Interval == 300)
            {
                messageGen.Stop();
                
                BSODCreator bs = new BSODCreator();
                
                bs.throw9XBSOD(true, BSODCreator.BSODCauses.Generic);
            }
        }

        private void classicButton3_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void classicButton1_Click(object sender, EventArgs e)
        {
            messageGen.Start();
        }

        private void classicButton2_Click(object sender, EventArgs e)
        {
            messageGen.Stop();
        }
    }
}
