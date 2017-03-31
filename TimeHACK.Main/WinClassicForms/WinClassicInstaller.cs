using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.WinClassicForms
{
    public partial class WinClassicInstaller : UserControl
    {
        public WinClassicInstaller()
        {
            InitializeComponent();
        }

        string programtoinstall;

        private void WinClassicInstaller_Load(object sender, EventArgs e)
        {
            welcome.Show();
            programtoinstall = installname.Text;
            installname.Hide();
            //programname.Text = (programtoinstall & " Setup")
            Label1.Text = ("Setup Wizard ");
            Label2.Text = ("Welcome To " + programtoinstall);
            Label3.Text = ("Click Next to continue");
            Label4.Text = ("This Wizard will guide you through the installation of " + programtoinstall);
            Label11.Text = ("C:\\Program Files\\ " + programtoinstall);
            Label12.Text = ("Ready to start installing " + programtoinstall);
            Label13.Text = ("Please wait while " + programtoinstall + " is being installed");
            Label14.Text = ("Installing " + programtoinstall);
            Label16.Text = (programtoinstall + " was successfully installed.");
            finishinstallimage.Image = installimage.Image;
            look.Start();
            licenceagreementinstallpic.Image = iconpic.Image;
            suminstallpic.Image = iconpic.Image;
            PictureBox2.Image = iconpic.Image;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Button3.Text == "Finish")
            {
                if (programtoinstall == "Web Chat 1998")
                {
                    TitleScreen.frm95.WebChatToolStripMenuItem.Visible = true;
                    ((Form)this.TopLevelControl).Close();
                }
                if (programtoinstall == "Guess The Number 2")
                {
                    ((Form)this.TopLevelControl).Close();
                    //Windows2000.GuessTheNumberToolStripMenuItem.Visible = true;
                }
                if (programtoinstall == "Start Runner 2000")
                {
                    ((Form)this.TopLevelControl).Close();
                    //Windows2000.StartRunnerToolStripMenuItem.Visible = true;
                }
                if (programtoinstall == "Error Blaster 2000")
                {
                    ((Form)this.TopLevelControl).Close();
                    //Windows2000.ErrorBlasterToolStripMenuItem.Visible = true;
                }
                if (programtoinstall == "Skindows 95")
                {
                    ((Windows95)this.ParentForm.ParentForm).SkindowsToolStripMenuItem.Visible = true;
                    ((Form)this.TopLevelControl).Close();
                }
                if (programtoinstall == "Web Chat 2000")
                {
                    ((Form)this.TopLevelControl).Close();
                    //Windows2000.WebChatToolStripMenuItem.Visible = true;
                }
                if (programtoinstall == "Time Distorter 0.3")
                {
                    ((Form)this.TopLevelControl).Close();
                    //Windows2000.TimeDistorter03ToolStripMenuItem.Visible = true;
                }
                if (programtoinstall == "Survive The Day")
                {
                    ((Form)this.TopLevelControl).Close();
                    //Windows2000.SurviveTheDayToolStripMenuItem.Visible = true;
                }
            }
            if (summary.Visible == true & licenseagreement.Visible == false)
            {
                summary.Hide();
                Button3.Hide();
                Timer1.Start();
            }
            if (licenseagreement.Visible == true & welcome.Visible == false)
            {
                licenseagreement.Hide();
            }
            if (welcome.Visible == true)
            {
                welcome.Hide();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar1.Value < 100)
            {
                ProgressBar1.Value = ProgressBar1.Value + 1;
            }
            if (ProgressBar1.Value == 100)
            {
                Button3.Show();
                installerproccess.Hide();
                Button3.Text = "Finish";
                Timer1.Stop();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton2.Checked == true){
                Button3.Enabled = false;
            }else{
                Button3.Enabled = true;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                Button3.Enabled = false;
            }else{
                Button3.Enabled = true;
            }
        }
    }
}
