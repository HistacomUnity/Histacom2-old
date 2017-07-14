using System;
using System.Threading.Tasks;
using TimeHACK.Engine;
using TimeHACK.Engine.Template;

namespace TimeHACK.OS.Win95.Win95Apps.Story
{
    public class Hack2 : object
    {
        static WindowManager wm = new WindowManager();

        public static async void StartObjective()
        {
            WinClassicTerminal Console = new WinClassicTerminal(true);
            WinClassic app = wm.StartWin95(Console, "MS-DOS Prompt", null, true, true);
            
            Console.WriteLine("telnet> 185.152.46.51 Connecting...");
            await Task.Delay(2500);
            Console.WriteLine("telnet> 185.152.46.51 Connected.");
            await Task.Delay(2500);
            Console.WriteLine("telnet> 185.152.46.51 set hostname to '12padams'.");
            await Task.Delay(2000);
            Console.WriteLine("12padams> WHAT DO YOU THINK YOU'RE DOING??");
            await Task.Delay(3000);
            Console.WriteLine("12padams> First you hack my FTP server..");
            await Task.Delay(4500);
            Console.WriteLine("12padams> Then you download my secret Time Distorter program?");
            await Task.Delay(4000);
            Console.WriteLine("12padams> Oh, and I know you activated it.");
            await Task.Delay(4000);
            Console.WriteLine("12padams> I can see your screen right now..");
            await Task.Delay(5000);
            Console.WriteLine("12padams> Now, in about 2 minutes you think you're going to be able to travel to 1999.");
            await Task.Delay(3500);
            Console.WriteLine("12padams> Well, I am sorry but I just can't let you do that.");
            await Task.Delay(5000);
            Console.WriteLine("12padams> You see, I have LOTS of power over your computer.");
            await Task.Delay(3400);
            Console.WriteLine("12padams> Okay, let me show you how easy this is.");
            await Task.Delay(1500);
            Console.WriteLine("Command> Hide Start Button");
            TitleScreen.frm95.startbutton.Hide();
            await Task.Delay(3500);
            Console.WriteLine("12padams> See how easy that was?");
            await Task.Delay(3700);
            Console.WriteLine("12padams> Now watch this..");
            await Task.Delay(3000);
            TitleScreen.frm95.desktopicons.BackgroundImage = Properties.Resources.Win95Error;
            TitleScreen.frm95.BackgroundImage = null;
            await Task.Delay(3000);
            Console.WriteLine("12padams> Hahaha, having a few errors are we?");
            await Task.Delay(2500);
            Console.WriteLine("telnet> 104.27.135.159 Connecting...");
            await Task.Delay(2500);
            Console.WriteLine("telnet> 104.27.135.159 Connected.");
            await Task.Delay(2500);
            Console.WriteLine("telnet> 104.27.135.159 set hostname to 'TheHiddenHacker'.");
            await Task.Delay(3000);
            Console.WriteLine("The Hidden Hacker> Great, you found the software.");
            await Task.Delay(3700);
            Console.WriteLine("12padams> How dare you..");
            await Task.Delay(3500);
            Console.WriteLine($"The Hidden Hacker> Don't worry {SaveSystem.ProfileName}.");
            await Task.Delay(4500);
            Console.WriteLine("The Hidden Hacker> I have to say, good job for getting the Time Distorter.");
            await Task.Delay(4000);
            Console.WriteLine("12padams> The Hidden Hacker.. I thought my first punishment was enough to keep you away.");
            await Task.Delay(4500);
            Console.WriteLine("The Hidden Hacker> Well, now that I have uncovered your secret, I'm not just gonna go away.");
            await Task.Delay(3600);
            Console.WriteLine("12padams> If you don't go, I'll make you go!");
            await Task.Delay(3700);
            Console.WriteLine($"The Hidden Hacker> Hey {SaveSystem.ProfileName}, don't worry about 12padams. You're about to get away from all this.");
            await Task.Delay(3500);
            Console.WriteLine("The Hidden Hacker> Let me fix this..");
            await Task.Delay(2500);
            Console.WriteLine("Command> Show Start Button");
            TitleScreen.frm95.startbutton.Show();
            await Task.Delay(2900);
            Console.WriteLine("12padams> OKAY, NOW YOU'VE DONE IT!");
            await Task.Delay(2500);
            Console.WriteLine("Command> Stop Timer");
            TitleScreen.frm95.distort.lblCountDown.Hide();
            await Task.Delay(3000);
            Console.WriteLine("12padams> I bet you didn't see that one coming..");
            await Task.Delay(3700);
            Console.WriteLine("The Hidden Hacker> Oh but I did..");
            await Task.Delay(5000);
            Console.WriteLine("The Hidden Hacker> I converted the stop function to the hide function when I logged on..");
            await Task.Delay(4200);
            Console.WriteLine("12padams> NO! That's impossible!");
            await Task.Delay(3000);
            Console.WriteLine("The Hidden Hacker> Oh, is it? Well, watch this!");
            await Task.Delay(2500);
            Console.WriteLine("Command> Show Timer");
            TitleScreen.frm95.distort.lblCountDown.Show();
            await Task.Delay(3000);
            Console.WriteLine("The Hidden Hacker> And here's one more command for you to learn.");
            await Task.Delay(1700);
            Console.WriteLine("Command> Disconnect 12padams");
            await Task.Delay(2000);
            Console.WriteLine("telnet> 12padams Disconnected.");
            await Task.Delay(3000);
            Console.WriteLine($"The Hidden Hacker> Good luck {SaveSystem.ProfileName}! I'll see you in the future!");
            await Task.Delay(3500);
            app.Close();
        }
    }
}
