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
using System.Threading;
using System.Media;
using System.IO;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WebChat1998 : UserControl
    {
        int chat_index = 0;
        WindowManager wm = new WindowManager();
        WCMessageParser wcmp = new WCMessageParser();
        bool correctname = false;
        bool guessing = false;

        SoundPlayer join = new SoundPlayer(Properties.Resources.AIMbuddyjoin);
        SoundPlayer leave = new SoundPlayer(Properties.Resources.AIMbuddyleave);
        SoundPlayer send = new SoundPlayer(Properties.Resources.AIMmessagesent);
        SoundPlayer receive = new SoundPlayer(Properties.Resources.AIMmessagereceived);

        public WebChat1998()
        {
            InitializeComponent();
        }
        private void WebChat1998_Load(object sender, EventArgs e)
        {
            button5.Hide();
            button4.Hide();
            button3.Hide();
            label5.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtscreenname.Text == "") { wm.startInfobox95("Invalid Username", "Your username cannot be blank.", Properties.Resources.Win95Warning); return; }
            if (txtscreenname.Text.Length > 12) { wm.startInfobox95("Invalid Username", "Your username needs to be less than 12 characters.", Properties.Resources.Win95Warning); return; }
            if (txtscreenname.Text.Contains(" ")) { wm.startInfobox95("Invalid Username", "Your username cannot contain spaces.", Properties.Resources.Win95Warning); return; }
            ParentForm.AcceptButton = button2;
            TitleScreen.username = txtscreenname.Text;
            login.Hide();
            listBox1.Items.Add(TitleScreen.username);
            history.Text = "System: " + TitleScreen.username + " has joined the chat." + Environment.NewLine;
            join.Play();
            Chat.Start();
        }

        private void Chat_Tick(object sender, EventArgs e)
        {
            if (!guessing)
            {
                history.Text += wcmp.ParseMessage(resources.GetString("convo"), chat_index, TitleScreen.username) + Environment.NewLine;
                switch (wcmp.GetSpecial(resources.GetString("convo"), chat_index))
                {
                    case "addsh":
                        listBox1.Items.Add("SkyHigh");
                        join.Play();
                        break;
                    case "nameguess":
                        typechat.Hide();
                        button2.Hide();
                        button3.Show();
                        button4.Show();
                        Chat.Stop();
                        guessing = true;
                        receive.Play();
                        break;
                    case "addrain":
                        listBox1.Items.Add("rain49");
                        join.Play();
                        break;
                    default:
                        receive.Play();
                        break;
                }
                Chat.Interval = wcmp.GetMessageDelay(resources.GetString("convo"), chat_index);
            }
            else
            {
                if (correctname)
                {
                    history.Text += "SkyHigh: yay you got it right!" + Environment.NewLine;
                }
                else
                {
                    history.Text += "SkyHigh: sorry, my name is actually bill" + Environment.NewLine;
                }
                guessing = false;
                receive.Play();
                Chat.Interval = wcmp.GetMessageDelay(resources.GetString("convo"), chat_index);
            }
            chat_index++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (typechat.Text != "") history.Text += TitleScreen.username + ": " + typechat.Text + Environment.NewLine;
            typechat.Text = "";
            send.Play();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            correctname = false;
            button2.Show();
            button3.Hide();
            button4.Hide();
            typechat.Show();
            Chat.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            correctname = true;
            button2.Show();
            button3.Hide();
            button4.Hide();
            typechat.Show();
            Chat.Start();
        }
    }
}
