using Histacom2.Engine;
using Histacom2.Engine.Template;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.Win98.Win98Apps.Story
{
    public class Hack3 : object
    {
        static WindowManager wm = new WindowManager();

        public static async void StartObjective()
        {
            Random r = new Random();

            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: it looks like the time distorter has been activated" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 116
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: so, in 2 minutes we see the results?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 113
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText($"12padams: wrong. 2 minutes for {SaveSystem.ProfileName}, and a year for us" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 109
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: oh great, not another year" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 106
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: hey, tests like these take time, be patient" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 102
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText($"HiddenHacker: ok.. {SaveSystem.ProfileName} you should feel lucky since you don't have to wait a whole year" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 97
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: still wish i couldve tested it tho" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 94
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("12padams: well for now we need to stop worrying about who wants to do what" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 89
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText($"12padams: instead we should focus on preparing for when {SaveSystem.ProfileName} makes it to 2000" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 84
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("12padams: hiddenhacker, the time distorter will send you a messgae via telnet when it reaches its destination" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 79
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: let me know when you get that message, and we will start another chat" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 75
            await Task.Delay(2000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: got it" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 73
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: btw, what exactly would go wrong with the y2k bug?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 69
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: well, im not entirely sure, thats why we are testing" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 65
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: \"not entirely\"? so do you have a little idea of what you think might happen?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 60
            await Task.Delay(6000); TitleScreen.frm98.webchat.history.AppendText($"12padams: yeah, i think there might be a slight chance that {SaveSystem.ProfileName} ends up travelling past 2000" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 54
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: well i hope that doesnt happen" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 50
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("12padams: me too" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 47
            await Task.Delay(6000); TitleScreen.frm98.webchat.history.AppendText($"HiddenHacker: this must be exciting for you, {SaveSystem.ProfileName}. travelling thru time, and all" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 41
            await Task.Delay(6000); TitleScreen.frm98.webchat.history.AppendText("12padams: and it looks like hes about to leave. anything you wanna say to him before he does?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 35
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: no, but i still really wish i could have tested it" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 30
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: hey, tell ya what" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 26
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText($"12padams: after {SaveSystem.ProfileName} gets to 2000, you can test the next version" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 21
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: oh cool thanks :)" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 16
            await Task.Delay(6000); TitleScreen.frm98.webchat.history.AppendText($"12padams: oh hey {SaveSystem.ProfileName}, make sure to keep an eye on the year in case something goes wrong" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 10
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: and have a safe trip!" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 6

            while (TitleScreen.frm98.distort.secsLeft != 0) { } // 0

            TitleScreen.frm98.distort.classicLabel4.Text = "Initiating Time Travel...";
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.webchat); 
            TitleScreen.frm98.webchat.ParentForm.Close();

            await Task.Delay(100); TitleScreen.frm98.taskbar.BackgroundImage = null; Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98.taskbar, false); 

            await Task.Delay(100); TitleScreen.frm98.taskbar.Hide();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Hide();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Show();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Hide();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Show();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Hide();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Show();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Hide();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Show();
            await Task.Delay(100); TitleScreen.frm98.desktopicons.Hide(); 

            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); Program.Invert(TitleScreen.frm98, false); 

            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false);
            await Task.Delay(100); TitleScreen.frm98.distort.ParentForm.Location = new Point(r.Next(TitleScreen.frm98.Width), r.Next(TitleScreen.frm98.Height)); Program.Invert(TitleScreen.frm98, false); // -5

            await Task.Delay(100);
            TitleScreen.frm98.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).BringToFront();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).maximizebutton.Enabled = false;
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).WindowState = FormWindowState.Maximized;
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).right.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).left.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).bottom.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).top.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).bottomleftcorner.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).bottomrightcorner.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).topleftcorner.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).toprightcorner.Hide();
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).Dock = DockStyle.Fill;
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).max = true;
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).maximizebutton.Image = Engine.Properties.Resources.WinClassicRestore;
            ((WinClassic)TitleScreen.frm98.distort.ParentForm).programtopbar.Hide();
            TitleScreen.frm98.distort.BackColor = Color.Black;
            foreach (Control c in TitleScreen.frm98.distort.Controls) { c.BackColor = Color.Black; c.Hide(); }
            TitleScreen.frm98.distort.classicLabel1.Show();
            TitleScreen.frm98.distort.classicLabel1.ForeColor = Color.Lime;
            TitleScreen.frm98.distort.classicLabel2.Text = "LOL NO";
            TitleScreen.frm98.distort.classicLabel2.ForeColor = Color.MidnightBlue;
            // 0

            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Text = "1999";
            await Task.Delay(500);
            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Text = "2000";
            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Text = "2000"; TitleScreen.frm98.distort.classicLabel2.Show();
            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Text = "2000"; TitleScreen.frm98.distort.classicLabel2.Hide();
            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Text = "1900"; // 1

            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Hide();
            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Show();
            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Text = "2000";
            await Task.Delay(100); TitleScreen.frm98.distort.classicLabel1.Text = "1900"; // 1.4

            for (int year = 1901; year < 2000; year++)
            {
                await Task.Delay(80);
                TitleScreen.frm98.distort.classicLabel1.Text = year.ToString();
            } // 9.32
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide(); // 9.4
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show(); 
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide(); 
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show();
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Text = "2000";
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide(); // 9.8
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show();
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide(); 
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show(); 
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Text = "2001"; 
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide(); // 10.2
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show();
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide();
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show();
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Text = "2002";
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide(); // 10.6
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show();
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Hide();
            await Task.Delay(80); TitleScreen.frm98.distort.classicLabel1.Show(); // 10.84
            await Task.Delay(3000);
            /*if (close_everything_.count2000 == -169)
                MyProject.Forms.Windowsxp2002damaged.Show();
            if (close_everything_.count2000 != -170)
                return;*/
        }
    }
}
