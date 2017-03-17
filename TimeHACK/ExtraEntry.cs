using System;
using System.Windows.Forms;

namespace TimeHACK
{
    static class ExtraEntry
    {
        internal static string gameID;
        
        // This is an extra file for testing out new Forms / apps. Do NOT edit Program.cs!
        [STAThread]
        static void Main()
        {
            // Set the GameID
            gameID = "WARNING - ExtraEntry Enabled! Please disable this BEFORE commiting.";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinClassicIE4());
        }
    }
}
