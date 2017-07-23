using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace TimeHACK.Engine
{
    public static class DesktopController
    {
        public static string ReadDataFile(string reqDirectory, bool returnYesIfProtected = false)
        {
            string Val = "";
            string directoryFileInfo;
            directoryFileInfo = File.ReadAllText(Path.Combine(reqDirectory, "_data.info"));
            FileSystemFolderInfo toRead = new FileSystemFolderInfo();
            toRead = JsonConvert.DeserializeObject<FileSystemFolderInfo>(directoryFileInfo);

            if (returnYesIfProtected == true)
            {
                if (toRead.Isprotected == true)
                {
                    return "yes";
                }
            }
            else
            {
                return toRead.label;
            }
            return Val;
        }

        public static void RefreshDesktopIcons(ListViewItem[] baseIcons, ref ListView theView, string theDirectory)
        {
            theView.Items.Clear(); // This resets it to it's default
            theView.Items.AddRange(baseIcons);

            foreach (string dir in Directory.GetDirectories(theDirectory))
            {
                string label = ReadDataFile(dir);
                theView.Items.Add(label ?? Path.GetFileName(dir), 1);
                theView.FindItemWithText(Path.GetFileName(dir)).Tag = dir;
            }

            foreach (string dir in Directory.GetFiles(theDirectory))
            {
                if (Path.GetFileName(dir) != "_data.info")
                {
                    theView.Items.Add(Path.GetFileName(dir), 12);
                    theView.FindItemWithText(Path.GetFileName(dir)).Tag = dir;
                }              
            }
        }
    }
}
