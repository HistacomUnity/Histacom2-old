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
            string directoryFileInfo = File.ReadAllText(Path.Combine(reqDirectory, "_data.info"));
            FileSystemFolderInfo toRead = new FileSystemFolderInfo();
            toRead = JsonConvert.DeserializeObject<FileSystemFolderInfo>(directoryFileInfo);

            if (returnYesIfProtected == true)
            {
                if (toRead.IsProtected == true)
                {
                    return "yes";
                }
            }
            else
            {
                return toRead.Label;
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
                    THFileInfo file = new THFileInfo();
                    FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(theDirectory, "_data.info")));
                    foreach (THFileInfo f in fsfi.Files)
                    {
                        if (f.Name.ToLower() == Path.GetFileName(dir).ToLower())
                        {
                            file = f; break;
                        }
                    }

                    if (new FileInfo(dir).Extension == ".exe" && file.FileIcon == 8) file.FileIcon = 10;

                    theView.Items.Add(Path.GetFileName(dir), file.FileIcon);
                    theView.FindItemWithText(Path.GetFileName(dir)).Tag = dir;
                }              
            }
        }
    }
}
