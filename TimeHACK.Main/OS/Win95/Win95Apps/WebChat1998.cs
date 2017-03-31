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
                wm.startInfobox95("test", "test");
            }
        }
    }
}
