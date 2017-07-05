using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicWelcome : UserControl
    {
        public WinClassicWelcome()
        {
            InitializeComponent();

            btnTour.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnOnline.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnClose.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
