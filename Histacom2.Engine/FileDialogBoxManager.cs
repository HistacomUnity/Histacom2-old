using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine
{
    public static class FileDialogBoxManager
    {
        public static bool IsInOpenDialog = false;
        public static bool IsInSaveDialog = false;
        public static List<string> OnlyViewExtension = new List<string>();

        public static void ActivateOpenFileDialog(params string[] ExtensionToView)
        {
            IsInOpenDialog = true;
            IsInSaveDialog = false;
            OnlyViewExtension = ExtensionToView.ToList();
        }

        public static void ActivateSaveFileDialog(params string[] ExtensionToView)
        {
            IsInOpenDialog = false;
            IsInSaveDialog = true;
            OnlyViewExtension = ExtensionToView.ToList();
        }

        public static void DeactivateFileDialog()
        {
            IsInOpenDialog = false;
            IsInSaveDialog = false;
            OnlyViewExtension = new List<string>();
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

        public static void SaveRtfDocument(RichTextBox tbox, string path)
        {
            int fileBytes = 0;
            tbox.SaveFile(path);
            fileBytes = File.ReadAllText(path).Length;

            THFileInfo info = new THFileInfo();
            info.Name = Path.GetFileName(path);
            info.FileIcon = 20;
            info.ByteSize = fileBytes;
            SaveSystem.CurrentSave.BytesLeft -= fileBytes;
            SaveSystem.UpdateDirectoryInfo(new FileInfo(path).Directory.FullName, info);
        }
    }
}
