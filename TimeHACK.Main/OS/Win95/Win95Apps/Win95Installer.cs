using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class Win95Installer : UserControl
    {
        public int installStage = 0;
        private Timer installbar = new Timer();

        public Win95Installer()
        {
            InitializeComponent();
            label1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label4.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label5.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            checkBox1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cancelbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            nextbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            backbutton1.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
        }

        private void Win95Installer_Load(object sender, EventArgs e)
        {
            label1.Text.Replace("GenericName", installname.Text);
            label3.Text.Replace("GenericName", installname.Text);
            label4.Text.Replace("GenericName", installname.Text);
            installbar.Tick += Installbar_Tick;
        }

        private void Installbar_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                panel3.Hide();
                panel4.Show();
                backbutton1.Hide();
                nextbutton1.Hide();
                cancelbutton1.Enabled = true;
                cancelbutton1.Text = "Finish";
                installbar.Stop();
            }
        }

        private void nextbutton1_Click(object sender, EventArgs e)
        {
            switch (installStage)
            {
                case 0:
                    label1.Hide();
                    panel1.Show();
                    backbutton1.Enabled = true;
                    if (!checkBox1.Checked) nextbutton1.Enabled = false;
                    installStage = 1;
                    break;
                case 1:
                    panel1.Hide();
                    panel2.Show();
                    installStage = 2;
                    break;
                case 2:
                    panel2.Hide();
                    panel3.Show();
                    backbutton1.Enabled = false;
                    nextbutton1.Enabled = false;
                    cancelbutton1.Enabled = false;
                    installbar.Start();
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) nextbutton1.Enabled = true;
            else nextbutton1.Enabled = false;
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            switch (installStage)
            {
                case 1:
                    panel1.Hide();
                    label1.Show();
                    backbutton1.Enabled = false;
                    nextbutton1.Enabled = true;
                    installStage = 0;
                    break;
                case 2:
                    panel2.Hide();
                    panel1.Show();
                    if (!checkBox1.Checked) nextbutton1.Enabled = false;
                    installStage = 1;
                    break;
            }
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
