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
    public partial class WinClassicWelcome : UserControl
    {
        public WinClassicWelcome()
        {
            InitializeComponent();

            btnTour.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnTour.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnOnline.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnOnline.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnClose.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnClose.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
