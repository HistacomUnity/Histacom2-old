using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TimeHACK.Engine;

namespace TimeHACK.OS.Win95.Win95Apps.Story
{
    class Hack1
    {
        WinClassicTerminal term = new WinClassicTerminal();
        WindowManager wm = new WindowManager();
        private SoundPlayer startsound;

        // This is the very first story script!
        public void startObjective()
        {
            
            wm.startWin95(term, "MS-DOS Prompt", null, true, true);
            term.WriteLine("192.168.0.1 Connecting...");
            
            // Play Dial-up Sound
            Stream audio = Properties.Resources.modem_dial;
            startsound = new SoundPlayer(audio);
            startsound.PlaySync();
            term.WriteLine("192.168.0.1 Connected.");
        }
    }
}
