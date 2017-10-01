using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.GlobalPrograms.InstallerPanes
{
    public partial class CompletePane : UserControl
    {
        public CompletePane()
        {
            InitializeComponent();
        }

        private void CompletePane_Load(object sender, EventArgs e)
        {
            classicLabel1.Text = $"Completing the {((WinClassicInstaller)Parent.Parent).progName} Setup Wizard";
            classicLabel2.Text = $"Setup has finished installing {((WinClassicInstaller)Parent.Parent).progName} on your computer. The application may be launched by selecting the installed icons.";
        }
    }
}
