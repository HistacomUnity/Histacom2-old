using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK
{
    public partial class AchievementBox : Form
    {
        private bool stayOnScreen = false;

        public AchievementBox(int type)
        {
            InitializeComponent();
            this.BringToFront();
            this.Show();
            switch (type)
            {
                case 0: //Piracy Ending
                    BackgroundImage = Properties.Resources.EndingPiracy;
                    stayOnScreen = true;
                    break;
                case 20:
                    BackgroundImage = Properties.Resources.AchievementMines;
                    button1.Hide();
                    break;
            }
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 202, -102);
            while (this.Location.Y != 0)
            {
                Thread.Sleep(5);
                Location = new Point(Location.X, Location.Y + 1);
            }
            if (!stayOnScreen)
            {
                Thread.Sleep(3000);
                while (this.Location.Y != -102)
                {
                    Thread.Sleep(5);
                    Location = new Point(Location.X, Location.Y - 1);
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.title.Show();
            SaveSystem.CurrentSave = null;
            SaveSystem.currentTheme = null;
            foreach (Form f in Application.OpenForms) if (!(f is TitleScreen) && !(f is AchievementBox)) f.Close();
            this.Close();
        }
    }
}
