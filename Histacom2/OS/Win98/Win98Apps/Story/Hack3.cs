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
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: it looks like the time distorter has been activated" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 116
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: so, in 2 minutes we see the results?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 113
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText($"12padams: wrong. 2 minutes for {SaveSystem.ProfileName}, and a year for us" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 109
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: oh great, not another year" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 106
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: hey, tests like these take time, be patient" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 102
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText($"HiddenHacker: ok.. {SaveSystem.ProfileName} you should feel lucky since you don't have to wait a whole year" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 97
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: still wish i couldve tested it tho" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 94
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("12padams: well for now we need to stop worrying about who wants to do what" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 89
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText($"12padams: instead we should focus on preparing for when {SaveSystem.ProfileName} makes it to 2000" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 84
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("12padams: hiddenhacker, the time distorter will send you a messgae via telnet when it reaches its destination" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 79
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: let me know when you get that message, and we will start another chat" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 75
            await Task.Delay(2000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: got it" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 73
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: btw, what exactly would go wrong with the y2k bug?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 69
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("12padams: well, im not entirely sure, thats why we are testing" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 65
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: \"not entirely\"? so do you have a little idea of what you think might happen?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 60
            await Task.Delay(6000); TitleScreen.frm98.webchat.history.AppendText($"12padams: yeah, i think there might be a slight chance that {SaveSystem.ProfileName} ends up travelling past 2000" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 54
            await Task.Delay(4000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: well i hope that doesnt happen" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 50
            await Task.Delay(3000); TitleScreen.frm98.webchat.history.AppendText("12padams: me too" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 47
            await Task.Delay(6000); TitleScreen.frm98.webchat.history.AppendText($"HiddenHacker: this must be exciting for you, {SaveSystem.ProfileName}. travelling thru time, and all" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 41
            await Task.Delay(6000); TitleScreen.frm98.webchat.history.AppendText("12padams: and it looks like hes about to leave. anything you wanna say to him before he does?" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 35
            await Task.Delay(5000); TitleScreen.frm98.webchat.history.AppendText("HiddenHacker: no, but i still really wish i could have tested it" + Environment.NewLine); TitleScreen.frm98.webchat.receive.Play(); // 30
        }
    }
}
