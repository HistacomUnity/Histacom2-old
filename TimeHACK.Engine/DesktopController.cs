using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TimeHACK.Engine
{
    public static class DesktopController
    {
        public static void RefreshDesktopIcons(ListViewItem[] baseIcons, ref ListView theView, string theDirectory)
        {
            theView.Items.Clear(); // This resets it to it's default
            theView.Items.AddRange(baseIcons);

            foreach (string dir in Directory.GetDirectories(theDirectory))
            {
                theView.Items.Add(Path.GetFileName(dir));
                theView.FindItemWithText(Path.GetFileName(dir)).ImageIndex = 1;
            }

            foreach (string dir in Directory.GetFiles(theDirectory))
            {
                theView.Items.Add(Path.GetFileName(dir));
                theView.FindItemWithText(Path.GetFileName(dir)).ImageIndex = 12;
            }
        }
    }
}
