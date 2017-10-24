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
            Win95.Win95Apps.WinClassicTerminal Console = new Win95.Win95Apps.WinClassicTerminal(true);
            WinXP app = wm.InitXP(Console, "MS-DOS Prompt", null, true, true);
        }
    }
}
