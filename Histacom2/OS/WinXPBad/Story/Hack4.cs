using Histacom2.Engine;
using Histacom2.Engine.Template;
using Histacom2.GlobalPrograms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.WinXPBad.Story
{
    public class Hack4 : object
    {
        public static Win95.Win95Apps.WinClassicTerminal Console = new Win95.Win95Apps.WinClassicTerminal(true);
        static WindowManager wm = new WindowManager();
        public static bool Stop = false;
        static Random Rnd = new Random();

        public static async void StartObjective()
        {
            try {
                await Task.Delay(5000);
                WinXP app = wm.InitXP(Console, "Command Prompt", null, true, true);
                Console.WriteLine("telnet> 104.27.135.159 Connecting...");

                await Task.Delay(2500); Console.WriteLine("telnet> 104.27.135.159 Connected.");
                await Task.Delay(2500); Console.WriteLine("telnet> 104.27.135.159 set hostname to 'TheHiddenHacker'.");
                await Task.Delay(2500); Console.WriteLine("TheHiddenHacker> STOP!");
                await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> DON'T OPEN INTERNET EXPLORER!");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> the whole web is infected with a virus");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> and if you open internet explorer, your pc will get infected!");
                await Task.Delay(2500); Console.WriteLine("TheHiddenHacker> trust me");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> now i have a lot of things to tell you, so pay attention");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> the world is in chaos, and it all started back in 1999, right when you left");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> as you know, 12padams told me to let him know when you got to 2000");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> and he believed that you would get there without any problems");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> but, as you saw, you ended up travelling to 2002 instead of 2000");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> 2000 came and went, and when you never showed up");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> 12padams refused to believe that his program failed");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> and so he thought that you did make it to 2000 and i was hiding you");
                //                                         TheHiddenHacker> we called out jason for being extremely stupid, then he went ballistic,
                await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> and he lost complete trust in me");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> later, in march 2001, 12padams made viruses to try to infect my pc");
                await Task.Delay(4500); Console.WriteLine("TheHiddenHacker> not only because he lost trust in me, but i also had the latest version of the time distorter");
                await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> thankfully, i avoided those early viruses");
                await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> but then, he released something dastardly");
                await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> a virus that infected every single website, and people who visited infected websites got their computers infected and rendered unusable");
                await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> now, its 2002. every website is infected, and 12padams has disappeared...");
                await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> the only use for the internet now is telnet, which is how im talking to you");
                await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> and since the internet is destroyed, we have to fix it by going back in time");
                await Task.Delay(4500); Console.WriteLine("TheHiddenHacker> now as i said before, i have the version 0.3 of the time distorter, which 12padams gave to me in 2000.");
                await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> and it only allows travel to 2000 or 2001.");
                await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> this means we have 2 choices..");
                await Task.Delay(4500); Console.WriteLine("TheHiddenHacker> 1. we go to 2001 and try to stop 12padams from releasing the virus (kinda nervous bout this)");
                await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> or 2. you go to 2000 and pretend everything worked fine during time travel.");
                await Task.Delay(4500); Console.WriteLine("TheHiddenHacker> i cant go with you to 2000 because nothing would go wrong and it wouldnt make sense for me to be there");
                await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> okay, ill go ahead and send the time distorter your way");
                await Task.Delay(3000); Console.WriteLine("telnet> Transferring \"Time Distorter 0.3.exe\" from TheHiddenHacker.");

                await Task.Delay(1000);

                WinClassicDownloader opendownload = new WinClassicDownloader();
                wm.InitXP(opendownload, "Downloader", null, false, true);
                opendownload.appName.Text = "Downloading: Time Distorter 0.3";
                opendownload.amountToDL = 38;
                opendownload.BackColor = Color.OldLace;

                await Task.Delay(5000); Console.WriteLine("telnet> Transfer complete.");
                await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> now open up the time distorter and make a choice, ill wait");
            }
            catch (Exception e)
            {
                return;
            }
        }

        public static async void VirusDestruction(WinClassicIE6Bad ie)
        {
            LabelMaker();
            Console.ParentForm.Close();
            await Task.Delay(10000); ((WinXP)ie.ParentForm).maximizebutton.Image = ((WinXP)ie.ParentForm).closebutton.Image;
            await Task.Delay(1000); ((WinXP)ie.ParentForm).minimizebutton.Image = ((WinXP)ie.ParentForm).closebutton.Image;
            await Task.Delay(1000); ie.toolStripMenuItem8.Image = Properties.Resources.WinXPError;
            await Task.Delay(1000); ie.toolStripMenuItem7.Image = Properties.Resources.WinXPError;
            await Task.Delay(1000); ie.toolStripMenuItem5.Image = Properties.Resources.WinXPError;
            await Task.Delay(1000); ie.toolStripMenuItem4.Image = Properties.Resources.WinXPError;
            await Task.Delay(1000); ie.toolStripMenuItem3.Image = Properties.Resources.WinXPError;
            await Task.Delay(1000); ie.toolStripMenuItem2.Image = Properties.Resources.WinXPError;
            await Task.Delay(1000); ie.backToolStripMenuItem.Image = Properties.Resources.WinXPError;
            await Task.Delay(3000); ie.comboBox1.BackColor = Color.Lime;
            await Task.Delay(1000); ie.comboBox1.ForeColor = Color.Red;
            await Task.Delay(1000); ie.classicLabel1.Text = "Virus:"; ie.classicLabel1.ForeColor = Color.Red; ie.toolStripMenuItem8.BackColor = Color.Lime;
            await Task.Delay(1000); ie.toolStripMenuItem8.Image = null; ie.toolStripMenuItem8.BackColor = Color.Red; ie.toolStripMenuItem7.BackColor = Color.Lime; ie.panel2.BackColor = Color.Black;
            await Task.Delay(1000); ie.toolStripMenuItem7.Image = null; ie.toolStripMenuItem7.BackColor = Color.Red; ie.toolStripMenuItem5.BackColor = Color.Lime; ie.toolStripMenuItem8.Visible = false; ie.toolStripMenuItem6.Visible = false;
            await Task.Delay(1000); ie.toolStripMenuItem5.Image = null; ie.toolStripMenuItem5.BackColor = Color.Red; ie.toolStripMenuItem4.BackColor = Color.Lime; ie.toolStripMenuItem7.Visible = false; ie.comboBox1.BackColor = Color.Black;
            await Task.Delay(1000); ie.toolStripMenuItem4.Image = null; ie.toolStripMenuItem4.BackColor = Color.Red; ie.toolStripMenuItem3.BackColor = Color.Lime; ie.toolStripMenuItem5.Visible = false; ie.comboBox1.ForeColor = Color.Black;
            await Task.Delay(1000); ie.toolStripMenuItem3.Image = null; ie.toolStripMenuItem3.BackColor = Color.Red; ie.toolStripMenuItem2.BackColor = Color.Lime; ie.toolStripMenuItem4.Visible = false; ie.panel2.Hide();
            await Task.Delay(1000); ie.toolStripMenuItem2.Image = null; ie.toolStripMenuItem2.BackColor = Color.Red; ie.backToolStripMenuItem.BackColor = Color.Lime; ie.toolStripMenuItem3.Visible = false; ie.menuStrip1.Hide(); ie.panel1.BackColor = Color.White;
            await Task.Delay(1000); ie.backToolStripMenuItem.Image = null; ie.backToolStripMenuItem.BackColor = Color.Red; ie.toolStripMenuItem2.Visible = false; ie.panel1.BackColor = Color.Black;
            await Task.Delay(1000); ie.backToolStripMenuItem.Visible = false; ie.panel1.Hide(); ie.label1.BackColor = Color.Black;
            await Task.Delay(1000); ie.label1.BackColor = Color.White;
            await Task.Delay(1000); ie.ParentForm.Hide();
            await Task.Delay(1000); TitleScreen.frmBadXP.desktopicons.BackgroundImage = Properties.Resources.WinXPError; TitleScreen.frmBadXP.desktopicons.BackgroundImageTiled = true; TitleScreen.frmBadXP.BackgroundImage = null;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.Show();
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.Black; TitleScreen.frmBadXP.taskbartime.BackColor = Color.Red;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.White; TitleScreen.frmBadXP.taskbartime.Text = "infected";
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.Black; TitleScreen.frmBadXP.desktopicons.Hide();
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.White; TitleScreen.frmBadXP.BackColor = Color.Black;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.Black; TitleScreen.frmBadXP.startbutton.Image = Properties.Resources.WinXPClose;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.White; TitleScreen.frmBadXP.startbutton.Image = null;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.Black; TitleScreen.frmBadXP.startbutton.BackColor = Color.White;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.White; TitleScreen.frmBadXP.startbutton.BackColor = Color.Black; TitleScreen.frmBadXP.taskbar.BackgroundImage = Properties.Resources.WinXPClose;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.Black; TitleScreen.frmBadXP.taskbar.BackgroundImage = null; TitleScreen.frmBadXP.taskbar.BackColor = Color.White; TitleScreen.frmBadXP.startbutton.Hide(); TitleScreen.frmBadXP.clockPanel.BackgroundImage = Properties.Resources.WinXPClose;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.White; TitleScreen.frmBadXP.taskbar.BackColor = Color.Black; TitleScreen.frmBadXP.clockPanel.BackgroundImage = null; TitleScreen.frmBadXP.clockPanel.BackColor = Color.White;
            await Task.Delay(1000); TitleScreen.frmBadXP.classicLabel2.ForeColor = Color.Black; TitleScreen.frmBadXP.clockPanel.BackColor = Color.Black; TitleScreen.frmBadXP.clockPanel.Hide();
            Stop = true;
            await Task.Delay(10000);
            SaveSystem.SaveAchievement(1);
            new AchievementBox(1);
        }

        public static async void Travel2K(WinClassicTimeDistorter3Bad td)
        {
            await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> looks like youre going back to 2000");
            await Task.Delay(4500); Console.WriteLine("TheHiddenHacker> this means it would be like you never made it here");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> for you youve gone from 98 to 99");
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> then the time distorter glicthed and sent you to 2002");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> but since youre going to 2000, itll be like the distorter never glitched out");
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> so youll have to pretend you made it safely here");
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> oh and also, youll be the only one who knows about coming here");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> i wont remember because i wont be coming with you, youll be meeting with past me");
            await Task.Delay(6000); Console.WriteLine("TheHiddenHacker> also also im really glad you chose 2000, im not sure we could tell 12padams the story and make him believe it");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> looks like its almost time");
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> goodbye, and best of luck to you");
            await Task.Delay(3000); Console.WriteLine("telnet> 104.27.135.159 Disconnected.");

            await Task.Delay(td.secsLeft * 1000);
        }

        public static async void TravelME(WinClassicTimeDistorter3Bad td)
        {
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> so were going to 2001 it seems");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> this means we have to convince 12padams not to release the virus");
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> tbh im a bit nervous about doing this");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> like, how exactly can we explain whats going on, and why you never made it?");
            await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> but eh");
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> i guess we can figure it out when we get there");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> anyways, as i said before, im coming with you to 2001");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> and i activated my time distorter a little after you did");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> but as soon as i get to 2001, ill setup another telnet"); //40

        }

        public static async void LabelMaker()
        {
            while (!Stop)
            {
                await Task.Delay(1000);
                VirusLabel v = new VirusLabel();
                v.WindowState = FormWindowState.Maximized;
                v.label1.Location = new Point(Rnd.Next(Screen.PrimaryScreen.Bounds.Width), Rnd.Next(Screen.PrimaryScreen.Bounds.Height));
                v.Show();
                v.TopMost = true;
                v.BringToFront();
            }
        }
    }
}
