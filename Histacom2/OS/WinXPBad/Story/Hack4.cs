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
            await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> and he lost complete trust in me");
            await Task.Delay(3500); Console.WriteLine("TheHiddenHacker> later, in march 2001, 12padams made viruses to try to infect my pc");
            await Task.Delay(4500); Console.WriteLine("TheHiddenHacker> not only because he lost trust in me, but i also had the latest version of the time distorter");
            await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> thankfully, i avoided those early viruses");
            await Task.Delay(3000); Console.WriteLine("TheHiddenHacker> but then, he released something dastardly");
            await Task.Delay(5000); Console.WriteLine("TheHiddenHacker> a virus that infected every single website, and people who visited infected websites got their computers infected and rendered unusable");
            await Task.Delay(4000); Console.WriteLine("TheHiddenHacker> now, its 2002. every website is infected, and 12padams has disappeared...");
        }
    }
}
