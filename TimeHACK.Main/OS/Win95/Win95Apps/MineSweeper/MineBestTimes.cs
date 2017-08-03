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

namespace TimeHACK.OS.Win95.Win95Apps.MineSweeper
{
    public partial class MineBestTimes : UserControl
    {
        public MineBestTimes()
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    c.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
                }
                else
                {
                    c.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void MineBestTimes_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveSystem.CurrentSave.mineSweepE = 999;
            SaveSystem.CurrentSave.mineSweepI = 999;
            SaveSystem.CurrentSave.mineSweepH = 999;
            SaveSystem.SaveGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = (SaveSystem.CurrentSave.mineSweepE.ToString()) + " seconds";
            label5.Text = (SaveSystem.CurrentSave.mineSweepI.ToString()) + " seconds";
            label6.Text = (SaveSystem.CurrentSave.mineSweepH.ToString()) + " seconds";
            if(SaveSystem.CurrentSave.mineSweepE != 999)
            {
                label7.Text = SaveSystem.ProfileName;
            }
            if(SaveSystem.CurrentSave.mineSweepI != 999)
            {
                label8.Text = SaveSystem.ProfileName;
            };
            if(SaveSystem.CurrentSave.mineSweepH != 999)
            {
                label9.Text = SaveSystem.ProfileName;
            }
        }
    }
}
