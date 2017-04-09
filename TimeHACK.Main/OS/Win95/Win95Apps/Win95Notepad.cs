using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class Win95Notepad : UserControl
    {
        public Win95Notepad()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                item.BackColor = Color.Silver;
                item.BackgroundImage = Properties.Resources.sliversilver;
                item.BackgroundImageLayout = ImageLayout.None;
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            wm.startAboutBox95("Notepad", "Microsoft Notepad", Properties.Resources.WinClassicNotepad);
        }
    }
}
