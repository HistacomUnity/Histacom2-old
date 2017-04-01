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
            chatLoop();
        }

        private void chatLoop()
        {
            WCMessageParser wcmp = new WCMessageParser();
            Thread.Sleep(15000);
            for (int i = 0; i < 200; i++)
            {
                history.Text = wcmp.ParseMessage(resources.GetString("convo"), i, TitleScreen.username);
                switch (wcmp.GetSpecial(resources.GetString("convo"), i))
                {
                    default:
                        break;
                }
                Thread.Sleep(wcmp.GetMessageDelay(resources.GetString("convo"), i));
            }
        }
    }
}
