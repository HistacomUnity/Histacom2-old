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
    public partial class ProgressPane : UserControl
    {
        public ProgressPane()
        {
            InitializeComponent();
        }

        private void DirectoryPane_Load(object sender, EventArgs e)
        {
            classicLabel2.Text = $"Please   wait   while   setup   installs   {((WinClassicInstaller)Parent.Parent).progName}   on   your   computer.         ";
            Timer t = new Timer();
            t.Interval = 200;
            t.Tick += (s, a) =>
            {
                if (progressBar1.Value == 100)
                {
                    ((WinClassicInstaller)Parent.Parent).classicButton2.PerformClick();
                    t.Stop();
                }
                progressBar1.Value += 4;
            };
            t.Start();
        }
    }
}
