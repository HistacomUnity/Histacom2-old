using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Histacom2.Engine.Template
{
    public partial class Infobox95 : UserControl
    {
        int btnStatus = 0;

        public Infobox95(InfoboxType type, InfoboxButtons btns)
        {
            InitializeComponent();
            this.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            this.programContent.BackColor = SaveSystem.currentTheme.threeDObjectsColor;

            switch (type)
            {
                case InfoboxType.Info:
                    pictureBox1.Image = Properties.Resources.Win95Info;
                    SoundPlayer spa = new SoundPlayer(SaveSystem.currentTheme.asteriskSound);
                    spa.Play();
                    spa.Stream.Position = 0;

                    break;
                case InfoboxType.Question:
                    pictureBox1.Image = Properties.Resources.Win95Question;
                    SoundPlayer spq = new SoundPlayer(SaveSystem.currentTheme.questionSound);
                    spq.Play();
                    spq.Stream.Position = 0;
                    break;
                case InfoboxType.Warning:
                    pictureBox1.Image = Properties.Resources.Win95Warning;
                    SoundPlayer spw = new SoundPlayer(SaveSystem.currentTheme.exclamationSound);
                    spw.Play();
                    spw.Stream.Position = 0;
                    break;
                case InfoboxType.Error:
                    pictureBox1.Image = Properties.Resources.Win95Error;
                    SoundPlayer spe = new SoundPlayer(SaveSystem.currentTheme.critStopSound);
                    spe.Play();
                    spe.Stream.Position = 0;
                    break;
            }

            btnStatus = (int)btns;
            switch (btns)
            {
                case InfoboxButtons.OK:
                    button1.Text = "OK";
                    button2.Hide();
                    button3.Hide();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnStatus == 0) this.ParentForm.Close();
        }

        private void programContent_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            this.programContent.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
        }
    }

    public enum InfoboxType
    {
        Info,
        Question,
        Warning,
        Error
    }

    public enum InfoboxButtons
    {
        OK,
        OKCancel,
        YesNo,
        YesNoCancel,
        AbortRetryFail
    }
}
