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
using TimeHACK.Engine.Template;

namespace TimeHACK.OS.Win95.Win95Apps.Story
{
    static class Hack1 : Object
    {
        static WindowManager wm = new WindowManager();
        static bool ended = false;
        static Thread soundThread = new Thread(dialup_sound_play);
        static bool devMode = true;

        // This is the very first story script!
        public static void StartObjective()
        {
            if (!ended) {
                System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
                tmr.Interval = 1;
                tmr.Tick += new EventHandler(CheckIfSoundFinished);

                if (devMode == true) ContinueObjective();
                else
                {
                    soundThread.Start();
                    tmr.Start();
                }
            }
        }

        public static async void ContinueObjective()
        {
            WinClassicTerminal Console = new WinClassicTerminal(true);
            WinClassic app = wm.StartWin95(Console, "MS-DOS Prompt", null, true, true);

            Console.WriteLine("telnet> 104.27.135.159 Connecting...");
            await Task.Delay(2500);
            Console.WriteLine("telnet> 104.27.135.159 Connected.");
            await Task.Delay(2500);
            Console.WriteLine("telnet> 104.27.135.159 set hostname to 'TheHiddenHacker'.");
            await Task.Delay(2500);
            Console.WriteLine("TheHiddenHacker> I see you have access to 12padams.com.");
            await Task.Delay(4500);
            Console.WriteLine("TheHiddenHacker> Though it doesn't seem obvious, only a very limited amount of people can access the site.");
            await Task.Delay(6000);
            Console.WriteLine("TheHiddenHacker> 12padams has a secret, and I need you to help me find it.");
            await Task.Delay(3500);
            Console.WriteLine("TheHiddenHacker> I was snooping around his website, when he blacklisted my IP address.");
            await Task.Delay(4000);
            Console.WriteLine("TheHiddenHacker> While I was searching, I noticed a file that I didn't have permission to download. I need you to get it for me.");
            await Task.Delay(6500);
            Console.WriteLine("TheHiddenHacker> First, I'll need you to download an FTP client, available under the software section of 12padams' website.");
            await Task.Delay(5000);
            Console.WriteLine("TheHiddenHacker> Once that's downloaded, You'll need to type in a Hostname, Username, and Password.");
            await Task.Delay(4500);
            Console.WriteLine("TheHiddenHacker> The hostname is 172.68.119.42, and the username is most likely 12padams. I'm not too sure what the password is, however.");
            await Task.Delay(3500);
            Console.WriteLine("TheHiddenHacker> You'll need to figure out where you can get the password. Try looking for any odd text on the website.");
            await Task.Delay(3500);
            Console.WriteLine("TheHiddenHacker> I don't have much time to talk - I'd quickly copy down those details into Notepad before this Terminal gets closed.");

            await Task.Delay(36000);
            app.Close();
            ended = true;
        }
        
        public static void CheckIfSoundFinished(Object sender, EventArgs e)
        {
            if (soundThread.IsAlive == false)
            {
                // Continue from where we were
                System.Windows.Forms.Timer trm = sender as System.Windows.Forms.Timer;

                ContinueObjective();
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
