using Histacom2.Engine;
using Histacom2.Engine.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histacom2.OS.WinXPBad.Story
{
    public class Hack4 : object
    {
        static WindowManager wm = new WindowManager();

        public static async void StartObjective()
        {
            await Task.Delay(6000);
            Win95.Win95Apps.WinClassicTerminal Console = new Win95.Win95Apps.WinClassicTerminal(true);
            WinXP app = wm.InitXP(Console, "Command Prompt", null, true, true);
            Console.WriteLine("telnet> 104.27.135.159 Connecting...");

            await Task.Delay(2500); Console.WriteLine("telnet> 104.27.135.159 Connected.");
            await Task.Delay(2500); Console.WriteLine("telnet> 104.27.135.159 set hostname to 'TheHiddenHacker'.");
            await Task.Delay(2500); Console.WriteLine("TheHiddenHacker> STOP!");
            await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> DON'T OPEN INTERNET EXPLORER!");
        }
    }
}
