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

namespace TimeHACK.Engine.Template.Taskbars
{
    public partial class Win95TaskBarItem : UserControl
    {
        TaskBarController tb = new TaskBarController();
        public string ApplicationID;
        public Win95TaskBarItem()
        {
            InitializeComponent();
            progName.Font = new Font(TitleScreen.pfc.Families[0], 16f, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            this.BackColor = Color.Silver;
        }

        private void Win95TaskBarItem_Load(object sender, EventArgs e)
        {
            progName.Text = (string)this.Tag;
            if (BackgroundImage == null)
            {
                progName.Location = new Point(4, 2);
                progPic.Hide();
            }
            else progPic.Image = this.BackgroundImage;
            ApplicationID = (TaskBarController.AvalibleApplicationID - 1).ToString();
            this.BackgroundImage = null;
        }

        private void Win95TaskBarItem_Click(object sender, EventArgs e)
        {
            tb.FocusAppFromID(ApplicationID);
        }
    }
}
