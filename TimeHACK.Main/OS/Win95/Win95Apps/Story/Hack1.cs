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
        static Boolean devMode = false;

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
            Console.WriteLine("telnet> 104.27.135.159 Connected.");
            Thread.Sleep(2500);
            Console.WriteLine("telnet> 104.27.135.159 set hostname to 'TheHiddenHacker'.");
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
