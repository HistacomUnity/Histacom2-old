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
            button1.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            button2.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            button3.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);

            switch (type)
            {
                case InfoboxType.Info:
                    pictureBox1.Image = Properties.Resources.Win95Info;
                    SoundPlayer spa = new SoundPlayer(SaveSystem.currentTheme.asteriskSound);
                    spa.Play();
                    break;
                case InfoboxType.Question:
                    pictureBox1.Image = Properties.Resources.Win95Question;
                    SoundPlayer spq = new SoundPlayer(SaveSystem.currentTheme.questionSound);
                    spq.Play();
                    break;
                case InfoboxType.Warning:
                    pictureBox1.Image = Properties.Resources.Win95Warning;
                    SoundPlayer spw = new SoundPlayer(SaveSystem.currentTheme.exclamationSound);
                    spw.Play();
                    break;
                case InfoboxType.Error:
                    pictureBox1.Image = Properties.Resources.Win95Error;
                    SoundPlayer spe = new SoundPlayer(SaveSystem.currentTheme.critStopSound);
                    spe.Play();
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
