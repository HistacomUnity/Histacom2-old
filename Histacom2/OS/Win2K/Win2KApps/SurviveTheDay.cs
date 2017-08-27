using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace Histacom2.OS.Win2K.Win2KApps
{
    public partial class SurviveTheDay : UserControl
    {
        public SurviveTheDay()
        {
            InitializeComponent();
        }

        private void typer(string newtxt, string overtxt, bool over)
        {
            SoundPlayer beep = new SoundPlayer(Properties.Resources.std_beep);
            SoundPlayer overbeep = new SoundPlayer(Properties.Resources.std_gobeep);
            this.Invoke(new Action(() =>
            {
                words.Text = "";
                gameoverlbl.Text = "";
                gameoverlbl.Show();
            }));

            foreach (char c in newtxt)
            {
                this.Invoke(new Action(() =>
                {
                    words.Text += c;
                }));
                beep.Play();
                Thread.Sleep(40);
            }

            if (over)
            {
                Thread.Sleep(200);
                foreach (char c in overtxt)
                {
                    this.Invoke(new Action(() =>
                    {
                        gameoverlbl.Text += c;
                    }));
                    overbeep.Play();
                    Thread.Sleep(150);
                }
            }
            this.Invoke(new Action(() =>
            {
                if ((string)button1.Tag != "") button1.Show();
                if ((string)button2.Tag != "") button2.Show();
                if ((string)button3.Tag != "") button3.Show();
                if ((string)button4.Tag != "") button4.Show();
                if ((string)button5.Tag != "") button5.Show();
            }));
        }

        private void choice_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Tag == null | (string)btn.Tag == "") return;
            if ((string)btn.Tag == "quit")
            {
                this.ParentForm.Close();
                return;
            }

            JObject story = JObject.Parse(Properties.Resources.std_story);
            JToken path = story[(string)btn.Tag];

            button1.Text = (string)path["btn1txt"];
            button1.Tag = (string)path["btn1tag"];
            button1.Hide();
            button2.Text = (string)path["btn2txt"];
            button2.Tag = (string)path["btn2tag"];
            button2.Hide();
            button3.Text = (string)path["btn3txt"];
            button3.Tag = (string)path["btn3tag"];
            button3.Hide();
            button4.Text = (string)path["btn4txt"];
            button4.Tag = (string)path["btn4tag"];
            button4.Hide();
            button5.Text = (string)path["btn5txt"];
            button5.Tag = (string)path["btn5tag"];
            button5.Hide();

            time.Text = (string)path["time"];

            var t = new Thread(new ThreadStart(() =>
            {
                typer((string)path["txt"], (string)path["overtxt"], (bool)path["over"]);
            }));
            t.IsBackground = true;
            t.Start();
        }
    }
}
