using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.OS.Win95.Win95Apps.IE4Sites;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class TempIE4 : UserControl
    {
        public static Panel browsingArea = new Panel();

        public TempIE4()
        {
            InitializeComponent();
            browsingArea = _browsingArea;
        }

        public static void GoToPage(string url)
        {
            UserControl uc = new UserControl();

            switch (url)
            {
                case "www.google.com":
                    uc = new GoogleHome();
                    break;
                case "www.google.stanford.edu":
                    uc = new GooglePrototype();
                    break;
            }

            uc.Dock = DockStyle.Fill;
            browsingArea.Controls.Clear();
            browsingArea.Controls.Add(uc);
        }

        private void TempIE4_Load(object sender, EventArgs e)
        {
            GoToPage("www.google.com");
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            GoToPage(addressbar.Text);
        }
    }
}
