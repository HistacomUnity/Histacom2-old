using System;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;
using Histacom2.OS;
using Histacom2.OS.Win95;
using Histacom2.OS.Win95.Win95Apps;
using Histacom2.Engine;
using Histacom2.Engine.Template;
using System.Drawing;
using Histacom2.SaveDialogs;

namespace Histacom2
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

            //Histacom2.Engine.GameSave.SaveData MySaveData = new Histacom2.Engine.GameSave.SaveData()
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

            //MySaveData = (Histacom2.Engine.GameSave.SaveData)JsonConvert.DeserializeObject(TheJSON, MySaveData.GetType());
            //MessageBox.Show(MySaveData.OS.ToString());

            Engine.SaveSystem.troubleshooter = new SaveFileTroubleShooter();
            Application.EnableVisualStyles();           
            Application.Run(title);
        }

        public static string OpenFileExplorerAsDialogAndReturnGivenPath()
        {
            if (SaveSystem.CurrentSave.CurrentOS == "95")
            {
                WinClassic app = wm.Init(new Win95WindowsExplorer(), "Windows Explorer", Properties.Resources.WinClassicFileExplorer, true, true, true);
            } else {
                WinClassic app = wm.Init(new WinClassicWindowsExplorer(), "Windows Explorer", Properties.Resources.WinClassicFileExplorer, true, true, true);
            }
            
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
            if (TitleScreen.frm95 != null) TitleScreen.frm95.AddTaskBarItem(Application, ApplicationID, ApplicationName, ApplicationIcon);
            if (TitleScreen.frm98 != null) TitleScreen.frm98.AddTaskBarItem(Application, ApplicationID, ApplicationName, ApplicationIcon);
        }

        public static void NonImportantApp_Closing(object sender, FormClosingEventArgs e)
        {
            Program.nonimportantapps.Remove((WinClassic)sender);
        }

        public static void Invert(Control c, bool forecolor = true, bool backcolor = true)
        {
            if (backcolor)
            {
                if (c.BackColor == Color.Black) c.BackColor = Color.White;
                else c.BackColor = Color.Black;
            }
            if (forecolor)
            {
                if (c.ForeColor == Color.White || c.ForeColor == Color.Silver) c.ForeColor = Color.Black;
                else c.ForeColor = Color.White;
            }
        }
    }
}
