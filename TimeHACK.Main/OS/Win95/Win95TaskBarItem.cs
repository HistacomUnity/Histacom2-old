using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.Engine.Template.Taskbars
{
    public partial class Win95TaskBarItem : UserControl
    {
        public Win95TaskBarItem()
        {
            InitializeComponent();
            progName.Font = new Font(TitleScreen.pfc.Families[0], 16f, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            this.BackColor = Color.Silver;
        }

        private void Win95TaskBarItem_Load(object sender, EventArgs e)
        {
            progName.Text = (string)this.Tag;
            progPic.Image = this.BackgroundImage;
            this.BackgroundImage = null;
        }
    }
}
