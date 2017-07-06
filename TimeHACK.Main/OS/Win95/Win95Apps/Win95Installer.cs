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
        public int installStage = 0;

        public Win95Installer()
        {
            InitializeComponent();
            label1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            checkBox1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cancelbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            nextbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            backbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
        }

        private void Win95Installer_Load(object sender, EventArgs e)
        {
            label1.Text.Replace("GenericName", installname.Text);
        }

        private void nextbutton1_Click(object sender, EventArgs e)
        {
            switch (installStage)
            {
                case 0:
                    label1.Hide();
                    panel1.Show();
                    backbutton1.Enabled = true;
                    nextbutton1.Enabled = false;
                    installStage = 1;
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) nextbutton1.Enabled = true;
            else nextbutton1.Enabled = false;
        }
    }
}
