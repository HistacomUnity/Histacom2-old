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
    public partial class DirectoryPane : UserControl
    {
        public DirectoryPane()
        {
            InitializeComponent();
        }

        private void DirectoryPane_Load(object sender, EventArgs e)
        {
            classicLabel3.Text = $"Setup will install {((WinClassicInstaller)Parent.Parent).progName} to the destination folder.";
            classicLabel5.Text = $"C:\\Program Files\\12padams\\{((WinClassicInstaller)Parent.Parent).progName}\\";

            groupBox1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular);
        }
    }
}
