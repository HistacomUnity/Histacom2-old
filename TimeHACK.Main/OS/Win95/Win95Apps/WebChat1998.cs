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

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WebChat1998 : UserControl
    {
        int chat_index = 0;
        WCMessageParser wcmp = new WCMessageParser();

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
            if (txtscreenname.Text == "")
            {
                WindowManager wm = new WindowManager();
                wm.startInfobox95("Invalid Username", "Your username cannot be blank.");
                return;
            }
            TitleScreen.username = txtscreenname.Text;
            login.Hide();
            listBox1.Items.Add(TitleScreen.username);
            history.Text = "System: " + TitleScreen.username + " has joined the chat." + Environment.NewLine;
            Chat.Start();
        }

        private void Chat_Tick(object sender, EventArgs e)
        {
            history.Text += wcmp.ParseMessage(resources.GetString("convo"), chat_index, TitleScreen.username) + Environment.NewLine;
            switch (wcmp.GetSpecial(resources.GetString("convo"), chat_index))
            {
                case "addsh":
                    listBox1.Items.Add("SkyHigh");
                    break;
                case "nameguess":
                    typechat.Hide();
                    button2.Hide();
                    button3.Show();
                    button4.Show();
                    Chat.Stop();
                    break;
                default:
                    break;
            }
            Chat.Interval = wcmp.GetMessageDelay(resources.GetString("convo"), chat_index);
            chat_index++;
        }
    }
}
