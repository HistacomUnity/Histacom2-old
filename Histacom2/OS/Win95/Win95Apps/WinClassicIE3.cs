using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.OS.Win95.Win95Apps.IE3Sites;

namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class WinClassicIE3 : UserControl
    {
        public static Panel browsingArea = new Panel();
        public static ComboBox addressbar = new ComboBox();

        public WinClassicIE3()
        {
            InitializeComponent();
            browsingArea = _browsingArea;
            addressbar = _addressbar;

            BackButton.MouseEnter += (s, e) => BackButton.BackgroundImage = Properties.Resources.IE3_BackHover;
            BackButton.MouseLeave += (s, e) => BackButton.BackgroundImage = Properties.Resources.IE3_Back;
            ForwardButton.MouseEnter += (s, e) => ForwardButton.BackgroundImage = Properties.Resources.IE3_ForwardHover;
            ForwardButton.MouseLeave += (s, e) => ForwardButton.BackgroundImage = Properties.Resources.IE3_Forward;
            StopButton.MouseEnter += (s, e) => StopButton.BackgroundImage = Properties.Resources.IE3_StopHover;
            StopButton.MouseLeave += (s, e) => StopButton.BackgroundImage = Properties.Resources.IE3_Stop;
            RefreshButton.MouseEnter += (s, e) => RefreshButton.BackgroundImage = Properties.Resources.IE3_RefreshHover;
            RefreshButton.MouseLeave += (s, e) => RefreshButton.BackgroundImage = Properties.Resources.IE3_Refresh;
        }

        public static async void GoToPage(string url)
        {
            string newURL = url;
            UserControl uc = new UserControl();

            switch (url)
            {
                case "www.microsoft.com/windows/ie/default.htm":
                    uc = new IE3Start();
                    break;
                case "www.google.com":
                    uc = new GoogleHome();
                    break;
                case "www.google.stanford.edu":
                    uc = new GooglePrototype();
                    break;
                case "www.12padams.com":
                    uc = new Website12padams1998();
                    break;
                case "12padams.com":
                    uc = new Website12padams1998();
                    newURL = "www.12padams.com";
                    break;
                case "google.com":
                    uc = new GoogleHome();
                    newURL = "www.google.com";
                    break;
                case "google.stanford.edu":
                    uc = new GooglePrototype();
                    newURL = "www.google.stanford.edu";
                    break;
                default:
                    uc = new IENoPage();
                    break;
            }

            addressbar.Text = newURL;
            uc.Dock = DockStyle.Fill;

            await Task.Delay(new Random().Next(500, 1500));

            browsingArea.Controls.Clear();
            browsingArea.Controls.Add(uc);

            if (url == "www.12padams.com") Story.Hack1.StartObjective();
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
