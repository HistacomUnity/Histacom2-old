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

namespace Histacom2.Engine.Template.Taskbars
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (SaveSystem.currentTheme != null) BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            else BackColor = Color.Silver;

            var _lightBack = Paintbrush.GetLightFromColor(BackColor);
            var _darkBack = Paintbrush.GetDarkFromColor(BackColor);

            var g = e.Graphics;
            g.Clear(BackColor);

            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, Width, Height));
            g.FillRectangle(new SolidBrush(_lightBack), new Rectangle(0, 0, Width - 1, Height - 1));
            g.FillRectangle(new SolidBrush(_darkBack), new Rectangle(1, 1, Width - 2, Height - 2));
            g.FillRectangle(new SolidBrush(BackColor), new Rectangle(1, 1, Width - 3, Height - 3));
        }
    }
}
