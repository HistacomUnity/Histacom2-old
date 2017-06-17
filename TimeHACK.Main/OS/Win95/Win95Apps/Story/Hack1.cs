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
        static WinClassicTerminal term = new WinClassicTerminal();
        static WindowManager wm = new WindowManager();
        static Boolean ended = false;
        static Thread soundThread = new Thread(dialup_sound_play);

        // This is the very first story script!
        public static void startObjective()
        {
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();

            wm.startWin95(term, "MS-DOS Prompt", null, true, true);
            term.WriteLine("192.168.0.1 Connecting...");

            term.Invalidate();
            Application.DoEvents();           

            tmr.Interval = 1;
            tmr.Tick += new EventHandler(CheckIfSoundFinished);

            soundThread.Start();

            tmr.Start();
        }

        public static void continueObjective()
        {
            term.WriteLine("192.168.0.1 Connected.");

            Application.DoEvents();
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
