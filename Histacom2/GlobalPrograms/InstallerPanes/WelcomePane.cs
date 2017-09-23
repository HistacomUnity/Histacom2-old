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
    public partial class WelcomePane : UserControl
    {
        public WelcomePane()
        {
            InitializeComponent();
        }

        private void WelcomePane_Load(object sender, EventArgs e)
        {
            classicLabel1.Text = $"Welcome to the {((WinClassicInstaller)Parent.Parent).progName} Setup Wizard";
            classicLabel2.Text = $"This will install {((WinClassicInstaller)Parent.Parent).progName} on your computer.";
        }
    }
}
