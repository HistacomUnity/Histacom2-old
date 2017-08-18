using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.Engine
{
    public static class FileDialogBoxManager
    {
        public static bool IsInOpenDialog = false;
        public static bool IsInSaveDialog = false;
        public static string OnlyViewExtension = "";

        public static void ActivateOpenFileDialog(string ExtensionToView)
        {
            IsInOpenDialog = true;
            IsInSaveDialog = false;
            OnlyViewExtension = ExtensionToView;
        }

        public static void ActivateSaveFileDialog(string ExtensionToView)
        {
            IsInOpenDialog = false;
            IsInSaveDialog = true;
            OnlyViewExtension = ExtensionToView;
        }

        public static string ReadTextFile(string path)
        {
            try
            {
                return File.ReadAllText(path);
            } catch {
                return "";
            }         
        }

        public static void SaveTextFile(string path, string contents, int fileIcon)
        {
            try
            {
                File.WriteAllText(path, contents);
                FileSystemFolderInfo theDir = Newtonsoft.Json.JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(Path.GetPathRoot(path), "_data.info")));



                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    theDir.Files.Add(new THFileInfo()
                    {
                        Name = Path.GetFileName(path),
                        ByteSize = (int)fs.Length,
                        FileIcon = fileIcon
                    });
                }

                
            } catch { }
        }
    }
}
