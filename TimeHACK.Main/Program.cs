using System;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;

namespace TimeHACK
{
    static class Program
    {
        internal static string gameID;
        
        /// <summary>
        /// The main entry point for the application.
        /// Run TitleScreen.cs at launch.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try {
                WebClient wc = new WebClient();

                // Set the GameID
                string json = wc.DownloadString("http://ci.appveyor.com/api/projects/timehack/timehack");
                JObject j = JObject.Parse(JObject.Parse(json)["build"].ToString());
                gameID = "1.0." + j["buildNumber"].ToString();
            } catch (WebException)
            {
                gameID = "1.0.42";
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TitleScreen());
        }
    }
}
