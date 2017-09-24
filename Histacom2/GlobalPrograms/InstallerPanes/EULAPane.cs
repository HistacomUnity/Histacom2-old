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

namespace Histacom2.GlobalPrograms.InstallerPanes
{
    public partial class EULAPane : UserControl
    {
        public EULAPane()
        {
            InitializeComponent();
        }

        private void DirectoryPane_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular);
            radioButton1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular);
            radioButton2.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ((WinClassicInstaller)Parent.Parent).classicButton2.Enabled = true;
            else ((WinClassicInstaller)Parent.Parent).classicButton2.Enabled = false;
        }
    }
}
