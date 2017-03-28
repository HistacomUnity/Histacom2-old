using System;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Set the GameID
            gameID = "1.0.44";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TitleScreen());
        }
    }
}
