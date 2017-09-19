using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.OS.Win98.Win98Apps.IE4Sites;

namespace Histacom2.OS.Win98.Win98Apps
{
    public partial class WinClassicIE4 : UserControl
    {
        public static Panel browsingArea = new Panel();
        public static ComboBox addressbar = new ComboBox();

        public WinClassicIE4()
        {
            InitializeComponent();
            browsingArea = _browsingArea;
            addressbar = _addressbar;
        }

        public static async void GoToPage(string url)
        {
            UserControl uc = new UserControl();

            switch (url)
            {
                case "www.microsoft.com/windows/ie/default.htm":
                    uc = new IE4HomePage();
                    break;
                    /*
                case "www.google.com":
                    uc = new GoogleHome();
                    break;
                case "www.12padams.com":
                    uc = new _12padams1998();
                    break;*/
                default:
                    uc = new IENoPage();
                    break;
            }

            addressbar.Text = url;
            uc.Dock = DockStyle.Fill;

            await Task.Delay(new Random().Next(500, 1500));

            browsingArea.Controls.Clear();
            browsingArea.Controls.Add(uc);
        }

        private void TempIE4_Load(object sender, EventArgs e)
        {
            GoToPage("www.microsoft.com/windows/ie/default.htm");
            GoButton.Paint += (s, args) => Engine.Paintbrush.PaintClassicBorders(s, args, 2);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            GoToPage(addressbar.Text);
        }

        private void _addressbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoButton_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
                browsingArea.Focus();
            }
        }
    }
}
