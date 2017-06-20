using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK.OS.Win95.Win95Apps.Story
{
    static class Hack1 : Object
    {
        static WinClassicTerminal Console = new WinClassicTerminal();
        static WindowManager wm = new WindowManager();
        static Boolean ended = false;
        static Thread soundThread = new Thread(dialup_sound_play);
        static Boolean devMode = true;

        // This is the very first story script!
        public static void startObjective()
        {
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();

            wm.startWin95(Console, "MS-DOS Prompt", null, true, true);
            Console.WriteLine("telnet> 104.27.135.159 Connecting...");          

            tmr.Interval = 1;
            tmr.Tick += new EventHandler(CheckIfSoundFinished);

            if (devMode == true)
            {
                continueObjective();
            }
            else
            {
                soundThread.Start();
                tmr.Start();
            }
        }

        public static void continueObjective()
        {
            Console.WriteLine("\ntelnet> 104.27.135.159 Connected.");
            Thread.Sleep(2500);
            Console.WriteLine("\ntelnet> 104.27.135.159 set hostname to 'TheHiddenHacker'.");
            Thread.Sleep(2500);
            Console.WriteLine("\nTheHiddenHacker> I see you have access to 12padams.com.");
            Thread.Sleep(4500);
            Console.WriteLine("\nTheHiddenHacker> Though it doesn't seem obvious, only a very limited amount of people can access the site.");
            Thread.Sleep(6000);
            Console.WriteLine("\nTheHiddenHacker> 12padams has a secret, and I need you to help me find it.");
            Thread.Sleep(3500);
            Console.WriteLine("\nTheHiddenHacker> I was snooping around his website, when he blacklisted my IP address.");
            Thread.Sleep(4000);
            Console.WriteLine("\nTheHiddenHacker> While I was serching, I noticed a file that I didn't have permission to download. I need you to get it for me.");
            Thread.Sleep(6500);
            Console.WriteLine("\nTheHiddenHacker> First, I'll need you to download an FTP client, avalible under the software section of 12padams' website.");
            Thread.Sleep(5000);
            Console.WriteLine("\nTheHiddenHacker> Once that's downloaded, You'll need to type in a Hostname, Username, and Password.");
            Thread.Sleep(4500);
            Console.WriteLine("\nTheHiddenHacker> The hostname is 172.68.119.42, and the username is most likely 12padams. I'm not too sure what the password is, however.");
            Thread.Sleep(3500);
            Console.WriteLine("\nTheHiddenHacker> You'll need to figure out where you can get the password. Try looking for any odd text on the website.");
        }
        
        public static void CheckIfSoundFinished(Object sender, EventArgs e)
        {
            if (soundThread.IsAlive == false)
            {
                // Continue from where we were
                System.Windows.Forms.Timer trm = sender as System.Windows.Forms.Timer;

                continueObjective();
                trm.Stop();
            }
        }

        public static void dialup_sound_play()
        {
            SoundPlayer dialup_sound;
            // Play Dial-up Sound
            Stream audio = Properties.Resources.modem_dial;
            dialup_sound = new SoundPlayer(audio);
            dialup_sound.PlaySync();
        }
    }
}
