using System;
using System.Windows.Forms;

namespace Histacom2.GlobalPrograms
{
    public partial class WinClassicInstaller : UserControl
    {
        public string progName;
        public int state = 0;

        public event EventHandler InstallCompleted;

        protected void OnInstallCompleted(EventArgs e)
        {
            if (InstallCompleted != null) InstallCompleted(this, e);
        }

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

        private void classicButton2_Click(object sender, EventArgs e)
        {
            classicButton3.Show();

            panel1.Controls.Clear();

            if (state == 0)
            {
                var eula = new InstallerPanes.EULAPane();
                eula.Parent = panel1;
                state = 1;
                classicButton2.Enabled = false;
            }
            else if (state == 1)
            {
                var dir = new InstallerPanes.DirectoryPane();
                dir.Parent = panel1;
                state = 2;
            }
            else if (state == 2)
            {
                classicButton3.Hide();
                classicButton1.Enabled = false;
                var p = new InstallerPanes.ProgressPane();
                p.Parent = panel1;
                state = 3;
            }
            else if (state == 3)
            {
                OnInstallCompleted(EventArgs.Empty);
                var c = new InstallerPanes.CompletePane();
                c.Parent = panel1;
                classicButton3.Enabled = false;
                classicButton2.Text = "Finish";
                state = 4;
            }
            else ParentForm.Close();
        }
    }
}
