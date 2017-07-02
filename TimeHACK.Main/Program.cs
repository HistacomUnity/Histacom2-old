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

namespace TimeHACK
{
    static class Program
    {
        static System.Media.SoundPlayer stopsound;

        internal static bool nightly = true;
        internal static string gameID;
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

            gameID = "Getting AppVeyor...";
            System.Threading.Thread getAppVeyor = new System.Threading.Thread(GetAppVeyor);

            getAppVeyor.Start();
            System.Threading.Thread.Sleep(500);

            //TimeHACK.Engine.GameSave.SaveData MySaveData = new TimeHACK.Engine.GameSave.SaveData()
            //{
            //    OS = 60,
            //    MyStringList = new List<string>
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
            Application.EnableVisualStyles();           
            Application.Run(title);
        }

        public static String OpenFileExplorerAsDialogAndReturnGivenPath()
        {
            WinClassicWindowsExplorer we = new WinClassicWindowsExplorer();

            WinClassic app = wm.startWin95(we, "Windows Explorer", Properties.Resources.WinClassicFileExplorer, true, true, true);
            try
            {
                return WindowsExplorerReturnPath;
            } catch {
                return "";
            }           
        }

        public static void ShutdownApplication(System.IO.UnmanagedMemoryStream audio)
        {
            System.Threading.Thread.Sleep(500);
            System.IO.Stream audioPlay = audio;
            stopsound = new System.Media.SoundPlayer(audioPlay);
            stopsound.PlaySync();

            System.Threading.Thread.Sleep(500);
            Environment.Exit(0);
            //Application.Exit();
        }

        public static void GetAppVeyor()
        {
            if (nightly == true)
            {
                try
                {
                    WebClient wc = new WebClient();

                    // Set the GameID
                    string json = wc.DownloadString("http://ci.appveyor.com/api/projects/timehack/timehack");
                    JObject j = JObject.Parse(JObject.Parse(json)["build"].ToString());
                    gameID = "AppVeyor-" + j["buildNumber"].ToString();
                }
                catch (WebException)
                {
                    gameID = "AppVeyor";
                }
            }
            else
            {
                gameID = "TimeHACK 1.1";
            }

        }

        public static void AddTaskbarItem(Form Application, string ApplicationID, string ApplicationName, Image ApplicationIcon)
        {
            TitleScreen.frm95.AddTaskBarItem(Application, ApplicationID, ApplicationName, ApplicationIcon);
        }

        public static void NonImportantApp_Closing(object sender, FormClosingEventArgs e)
        {
            Program.nonimportantapps.Remove((WinClassic)sender);
        }
    }
}
