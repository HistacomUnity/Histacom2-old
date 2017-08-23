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
    }
}
