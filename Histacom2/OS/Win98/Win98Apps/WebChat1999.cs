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
using Histacom2.Engine;
using Histacom2.Engine.Template;

namespace Histacom2.OS.Win98.Win98Apps
{
    public partial class WebChat1999 : UserControl
    {
        WindowManager wm = new WindowManager();

        SoundPlayer join = new SoundPlayer(Properties.Resources.AIMbuddyjoin);
        SoundPlayer leave = new SoundPlayer(Properties.Resources.AIMbuddyleave);
        SoundPlayer send = new SoundPlayer(Properties.Resources.AIMmessagesent);
        SoundPlayer receive = new SoundPlayer(Properties.Resources.AIMmessagereceived);
        SoundPlayer file = new SoundPlayer(Properties.Resources.AIMfile);

        int chatStage = 0;

        public WebChat1999()
        {
            InitializeComponent();
        }

        private void WebChat1999_Load(object sender, EventArgs e)
        {
            button5.Hide();
            label5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtscreenname.Text == "") { wm.StartInfobox95("Invalid Username", "Your username cannot be blank.", InfoboxType.Warning, InfoboxButtons.OK); return; }
            if (txtscreenname.Text.Length > 12) { wm.StartInfobox95("Invalid Username", "Your username needs to be less than 12 characters.", InfoboxType.Warning, InfoboxButtons.OK); return; }
            if (txtscreenname.Text.Contains(" ")) { wm.StartInfobox95("Invalid Username", "Your username cannot contain spaces.", InfoboxType.Warning, InfoboxButtons.OK); return; }
            if (txtscreenname.Text == "SkyHigh" | txtscreenname.Text == "rain49" | txtscreenname.Text == "12padams") { wm.StartInfobox95("Invalid Username", "That username is already taken.", InfoboxType.Warning, InfoboxButtons.OK); return; }
            ParentForm.AcceptButton = button2;
            TitleScreen.username = txtscreenname.Text;
            login.Hide();
            listBox1.Items.Add(TitleScreen.username);
            listBox1.Items.Add("ThatDude");
            history.AppendText("System: " + TitleScreen.username + " has joined the chat." + Environment.NewLine); join.Play();
            chatScript1();
        }

        private async void chatScript1()
        {
            await Task.Delay(2000);
            history.AppendText("ThatDude: oh hello!" + Environment.NewLine); receive.Play();
            await Task.Delay(5500);
            history.AppendText("ThatDude: just wondering, are you that guy who travelled thru time with nothing but a computer?" + Environment.NewLine); receive.Play();
            await Task.Delay(250);
            chatStage = 1;
            await Task.Delay(7000);
            if (chatStage == 1) { chatStage = 4; chatScript2(); }
        }

        private async void chatScript2()
        {
            if (chatStage == 2)
            {
                await Task.Delay(3000);
                history.AppendText("ThatDude: omg really??" + Environment.NewLine); receive.Play();
                await Task.Delay(4000);
                history.AppendText("ThatDude: hold on, let me check your ip to make sure" + Environment.NewLine); receive.Play();
            }
            else if (chatStage == 3)
            {
                await Task.Delay(2800);
                history.AppendText("ThatDude: oh.." + Environment.NewLine); receive.Play();
                await Task.Delay(5500);
                history.AppendText("ThatDude: lemme just check your ip quick to find out who ya are tho" + Environment.NewLine); receive.Play();
            }
            else
            {
                await Task.Delay(3300);
                history.AppendText("ThatDude: hold on, let me  just check your ip real quick" + Environment.NewLine); receive.Play();
            }
            await Task.Delay(5000);
            history.AppendText("ThatDude: YES! ITS YOU!" + Environment.NewLine); receive.Play();
            await Task.Delay(3500);
            history.AppendText("ThatDude: hey just wait a sec here" + Environment.NewLine); receive.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = typechat.Text;
            if (typechat.Text != "") history.AppendText(TitleScreen.username + ": " + typechat.Text + Environment.NewLine);
            typechat.Text = ""; send.Play();

            switch (chatStage)
            {
                case 1: // td asks are you the time distorter guy
                    if (msg.Contains("yes") | msg.Contains("yea") | msg.Contains("yep") | msg.Contains("thats me") | msg.Contains("that's me")) chatStage = 2;
                    else if (msg.Contains("no") | msg.Contains("nope") | msg.Contains("not")) chatStage = 3;
                    else chatStage = 4;

                    chatScript2();
                    break;
            }
        }
    }
}
