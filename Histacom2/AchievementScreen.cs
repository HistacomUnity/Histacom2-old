using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine;

namespace Histacom2
{
    public partial class AchievementScreen : Form
    {
        public AchievementScreen()
        {
            InitializeComponent();
        }

        private void AchievementScreen_Load(object sender, EventArgs e)
        {
            byte[] achieved = SaveSystem.GetAchievements();

            if (achieved[0] == 1)
            {
                listView1.Items[0].ImageIndex = 0;
                listView1.Items[0].Text = "Piracy Ending";
            }
            if (achieved[1] == 1)
            {
                listView1.Items[1].ImageIndex = 0;
                listView1.Items[1].Text = "Destruction Ending";
            }
            if (achieved[20] == 1) listView2.Items[0].ImageIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
