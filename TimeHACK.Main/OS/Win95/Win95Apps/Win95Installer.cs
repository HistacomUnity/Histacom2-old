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
    public partial class Win95Installer : UserControl
    {
        public Win95Installer()
        {
            InitializeComponent();
            label1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cancelbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            nextbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            backbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
        }

        private void Win95Installer_Load(object sender, EventArgs e)
        {
            label1.Text.Replace("GenericName", installname.Text);
        }
    }
}
