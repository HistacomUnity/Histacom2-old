using Histacom2.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histacom2.OS.Win98.Win98Apps.Story
{
    public class Hack3 : object
    {
        static WindowManager wm = new WindowManager();

        public static async void StartObjective()
        {
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: it looks like the time distorter has been activated"); TitleScreen.frm98.webchat.receive.Play(); // 176
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: so, in 3 minutes we see the results?"); TitleScreen.frm98.webchat.receive.Play(); // 173
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText($"12padams: wrong. 3 minutes for {SaveSystem.ProfileName}, and a year for us"); TitleScreen.frm98.webchat.receive.Play(); // 169
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: oh great, not another year"); TitleScreen.frm98.webchat.receive.Play(); // 166
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: hey, tests like these take time, be patient"); TitleScreen.frm98.webchat.receive.Play(); // 162
        }
    }
}
