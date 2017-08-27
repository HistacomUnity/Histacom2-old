using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine;

namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class WinClassicFTPClient : UserControl
    {
        public WinClassicFTPClient()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hostnameBox.Text == "172.68.119.42")
            {
                infoLabel.Hide();
                if (usernameBox.Text == "12padams")
                {
                    infoLabel.Hide();
                    if (passBox.Text == "projectDeath98")
                    {
                        infoLabel.Hide();
                        infoLabel.ForeColor = Color.Green;
                        infoLabel.Text = "[200] OK";
                        welcomeLabel.Hide();
                        infoLabel.Show();
                        ftpFiles.Show();
                    }
                    else
                    {
                        infoLabel.Text = "[430] Incorrect Password";
                        infoLabel.Show();
                    }
                }
                else
                {
                    infoLabel.Text = "[430] Incorrect Username";
                    infoLabel.Show();
                }
            }
            else
            {
                infoLabel.Text = "[404] Not Found";
                infoLabel.Show();
            }
        }

        private void ftpItems_Click(object sender, EventArgs e)
        {
            Point objDrawingPoint = ftpFiles.PointToClient(Cursor.Position);
            ListViewItem objListViewItem = new ListViewItem();
            if (objDrawingPoint != null)
            {
                objListViewItem = ftpFiles.GetItemAt(objDrawingPoint.X, objDrawingPoint.Y);
                if (objListViewItem.Text == "/software/")
                {
                    ftpFiles.Clear();
                    ListViewItem listViewItem1 = new ListViewItem(new string[] { "/downloads/" }, 0, Color.Black, Color.Empty, null);
                    ListViewItem listViewItem2 = new ListViewItem(new string[] { "skindows.html" }, 1, Color.Black, Color.Empty, null);
                    ftpFiles.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
                }
                else if (objListViewItem.Text == "/downloads/")
                {
                    ftpFiles.Clear();
                    ListViewItem listViewItem1 = new ListViewItem(new string[] { "/totallynotthetimedistorter/" }, 0, Color.Black, Color.Empty, null);
                    ListViewItem listViewItem2 = new ListViewItem(new string[] { "FTP Client Setup.exe" }, 2, Color.Black, Color.Empty, null);
                    ListViewItem listViewItem3 = new ListViewItem(new string[] { "Web Chat Setup.exe" }, 2, Color.Black, Color.Empty, null);
                    ListViewItem listViewItem4 = new ListViewItem(new string[] { "Guess The Number V1 Setup.exe" }, 2, Color.Black, Color.Empty, null);
                    ftpFiles.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
                }
                else if (objListViewItem.Text == "/totallynotthetimedistorter/")
                {
                    ftpFiles.Clear();
                    ListViewItem listViewItem1 = new ListViewItem(new string[] { "Time Distorter Setup.exe" }, 2, Color.Black, Color.Empty, null);
                    ftpFiles.Items.AddRange(new ListViewItem[] { listViewItem1 });
                }
                else if (objListViewItem.Text == "FTP Client Setup.exe")
                {
                    WinClassicDownloader opendownload = new WinClassicDownloader();
                    WindowManager wm = new WindowManager();
                    wm.StartWin95(opendownload, "Downloader", null, false, true);
                    opendownload.appName.Text = "Downloading: FTP Client";
                }
                else if (objListViewItem.Text == "Web Chat Setup.exe")
                {
                    WinClassicDownloader opendownload = new WinClassicDownloader();
                    WindowManager wm = new WindowManager();
                    wm.StartWin95(opendownload, "Downloader", null, false, true);
                    opendownload.appName.Text = "Downloading: Web Chat 1998";
                    opendownload.amountToDL = 35;
                }
                else if (objListViewItem.Text == "Time Distorter Setup.exe")
                {
                    WinClassicDownloader opendownload = new WinClassicDownloader();
                    WindowManager wm = new WindowManager();
                    wm.StartWin95(opendownload, "Downloader", null, false, true);
                    opendownload.appName.Text = "Downloading: Time Distorter 0.1";
                }
                else if (objListViewItem.Text == "Guess The Number V1 Setup.exe")
                {
                    WinClassicDownloader opendownload = new WinClassicDownloader();
                    WindowManager wm = new WindowManager();
                    wm.StartWin95(opendownload, "Downloader", null, false, true);
                    opendownload.appName.Text = "Downloading: Guess The Number V1";
                    opendownload.amountToDL = 16;
                }
            }
        }

        private void DoClassicButtons()
        {
            btnLogin.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnCancel.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void WinClassicFTPClient_Load(object sender, EventArgs e)
        {
            DoClassicButtons();
        }
    }
}
