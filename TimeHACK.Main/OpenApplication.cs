using System;
using System.IO;
using TimeHACK.Engine;
using TimeHACK.OS.Win95.Win95Apps;
using TimeHACK.Engine.Template;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK
{
    public class OpenApplication
    {
        WindowManager wm = new WindowManager();
        public String GetDataFromExe(String path)
        {
            return File.ReadAllText(path);
        }

        public void OpenApp(String appName)
        {
            WinClassic toReturn = new WinClassic();

            switch (appName.ToLower())
            {
                case "notepad":
                    toReturn = wm.StartWin95(new WinClassicNotepad(), "Notepad", Properties.Resources.Win95IconNotepad, true, true);
                    Program.AddTaskbarItem(toReturn, toReturn.Tag.ToString(), "Notepad", Properties.Resources.Win95IconNotepad);

                    Program.nonimportantapps.Add(toReturn);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    toReturn.BringToFront();

                    break;
                case "wordpad":
                    toReturn = wm.StartWin95(new WinClassicWordPad(), "Wordpad", Properties.Resources.Win95IconWordpad, true, true);
                    Program.AddTaskbarItem(toReturn, toReturn.Tag.ToString(), "Wordpad", Properties.Resources.Win95IconWordpad);

                    Program.nonimportantapps.Add(toReturn);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    break;
                case "addressbook":
                    toReturn = wm.StartWin95(new WinClassicAddressBook(), "Address Book", Properties.Resources.WinClassicAddressBook, true, true);
                    Program.AddTaskbarItem(toReturn, toReturn.Tag.ToString(), "Address Book", Properties.Resources.WinClassicAddressBook);

                    Program.nonimportantapps.Add(toReturn);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    break;
                case "ie4":
                    toReturn = wm.StartWin95(new WinClassicIE4(), "Internet Explorer 4", Properties.Resources.Win95IconNotepad, true, true);
                    Program.AddTaskbarItem(toReturn, toReturn.Tag.ToString(), "Internet Explorer 4", Properties.Resources.Win95IconNotepad);

                    break;
                case "windowsexplorer":
                    FileDialogBoxManager.IsInOpenDialog = false;
                    FileDialogBoxManager.IsInSaveDialog = false;
                    WinClassicWindowsExplorer we = new WinClassicWindowsExplorer();
                    WinClassic app = wm.StartWin95(we, "Windows Explorer", Properties.Resources.WinClassicFileExplorer, true, true);
                    Program.AddTaskbarItem(app, app.Tag.ToString(), "Windows Explorer", Properties.Resources.WinClassicFileExplorer);

                    Program.nonimportantapps.Add(app);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    app.BringToFront();

                    break;
                case "survivetheday":
                    TimeHACK.OS.Win2K.Win2KApps.SurviveTheDay std = new TimeHACK.OS.Win2K.Win2KApps.SurviveTheDay();
                    toReturn = wm.StartWin95(std, "Survive The Day", null, false, false);
                    Program.AddTaskbarItem(toReturn, toReturn.Tag.ToString(), "Survive The Day", null);

                    Program.nonimportantapps.Add(toReturn);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    toReturn.BringToFront();

                    break;
                case "webchat1998":
                    WebChat1998 wc = new WebChat1998();
                    toReturn = wm.StartWin95(wc, "Web Chat 1998", null, true, true);
                    Program.AddTaskbarItem(toReturn, toReturn.Tag.ToString(), "Web Chat 1998", null);

                    toReturn.BringToFront();

                    break;
                case "msdos":
                    WinClassicTerminal msdos = new WinClassicTerminal();
                    toReturn = wm.StartWin95(msdos, "MS-DOS Prompt", Properties.Resources.MS_DOS, true, true, false);

                    Program.AddTaskbarItem(toReturn, toReturn.Tag.ToString(), "MS-DOS Prompt", Properties.Resources.MS_DOS);
                    toReturn.BringToFront();

                    break;
            }
        }
    }
}
