using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.GlobalPrograms
{
    public partial class WinClassicInstaller : UserControl
    {
        public string progName;
        public int state = 0;

        public WinClassicInstaller(string prog)
        {
            InitializeComponent();
            progName = prog;
        }

        private void WinClassicInstaller_Load(object sender, EventArgs e)
        {
            var welkom = new InstallerPanes.WelcomePane();
            welkom.Parent = panel1;
        }
    }
}
