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
using System.Drawing.Text;
using static Histacom2.Engine.SaveSystem;
using Histacom2.OS.Win95;

namespace Histacom2.OS.Win95.Win95Apps._12padamsViruses
{
    public partial class StartRunner95 : UserControl
    {
        Point beginLocation;
        int taskbarLength;
        int xLocation;
        Timer moveStart = new Timer();
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        Windows95 w = new Windows95();
        public StartRunner95()
        {
            InitializeComponent();
            pfc.AddFontFile(DataDirectory + "\\LeviWindows.ttf");
            label2.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            beginLocation = w.startbutton.Location;
            moveStart.Interval = 300;
            moveStart.Tick += MoveStart_Tick;

        }

        private void MoveStart_Tick(object sender, EventArgs e)
        {
            int taskbarWidth = w.taskbar.Size.Width;
            Random random = new Random();
            xLocation = random.Next(1, taskbarWidth);
            w.startbutton.Location = new Point(xLocation, w.startbutton.Location.Y);
        }

        private void classicButton1_Click(object sender, EventArgs e)
        {
            moveStart.Start();
        }

        private void StartRunner95_Load(object sender, EventArgs e)
        {
            
        }

        private void classicButton2_Click(object sender, EventArgs e)
        {
            moveStart.Stop();
            w.startbutton.Location = beginLocation;
        }

        private void classicButton3_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
