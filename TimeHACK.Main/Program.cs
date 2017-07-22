using System;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;
using TimeHACK.OS;
using TimeHACK.OS.Win95;
using TimeHACK.OS.Win95.Win95Apps;
using TimeHACK.Engine;
using TimeHACK.Engine.Template;
using System.Drawing;
using TimeHACK.SaveDialogs;

namespace TimeHACK
{
    static class Program
    {
        static System.Media.SoundPlayer stopsound;

        internal static bool nightly = true;
        internal static TitleScreen title;
        public static string AddressBookSelectedFolderName;
        public static AddressBookContact AddressBookSelectedContact;
        public static string WindowsExplorerReturnPath;
        static WindowManager wm = new WindowManager();

        public static List<WinClassic> nonimportantapps = new List<WinClassic>();
        public static int currentappcount = 0;

        /// <summary>
        /// The main entry point for the application.
        /// Run TitleScreen.cs at launch.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetCompatibleTextRenderingDefault(false);

            title = new TitleScreen();

            //TimeHACK.Engine.GameSave.SaveData MySaveData = new TimeHACK.Engine.GameSave.SaveData()
            //{
            //    OS = 60,
            //    MystringList = new List<string>
            //    {
            //        "Item1",
            //        "Item2"
            //    }
            //};

            //string TheJSON = JsonConvert.SerializeObject(MySaveData, Formatting.Indented);
            //MessageBox.Show(TheJSON);
            //MySaveData.OS = 40;
            //MessageBox.Show(MySaveData.OS.ToString());

            //MySaveData = (TimeHACK.Engine.GameSave.SaveData)JsonConvert.DeserializeObject(TheJSON, MySaveData.GetType());
            //MessageBox.Show(MySaveData.OS.ToString());

            Engine.SaveSystem.troubleshooter = new SaveFileTroubleShooter();
            Application.EnableVisualStyles();           
            Application.Run(title);
        }

        public static string OpenFileExplorerAsDialogAndReturnGivenPath()
        {
            Win95WindowsExplorer we = new Win95WindowsExplorer();

            WinClassic app = wm.StartWin95(we, "Windows Explorer", Properties.Resources.WinClassicFileExplorer, true, true, true);
            try
            {
                return WindowsExplorerReturnPath;
            } catch {
                return "";
            }           
        }

        public static void ShutdownApplication(System.IO.Stream audio)
        {
            System.Threading.Thread.Sleep(500);
            System.IO.Stream audioPlay = audio;
            stopsound = new System.Media.SoundPlayer(audioPlay);
            stopsound.PlaySync();

            System.Threading.Thread.Sleep(500);
            Environment.Exit(0);
            //Application.Exit();
        }

        public static void AddTaskbarItem(Form Application, string ApplicationID, string ApplicationName, Image ApplicationIcon)
        {
            TitleScreen.frm95.AddTaskBarItem(Application, ApplicationID, ApplicationName, ApplicationIcon);
            TitleScreen.frm98.AddTaskBarItem(Application, ApplicationID, ApplicationName, ApplicationIcon);
        }

        public static void NonImportantApp_Closing(object sender, FormClosingEventArgs e)
        {
            Program.nonimportantapps.Remove((WinClassic)sender);
        }
    }
}
