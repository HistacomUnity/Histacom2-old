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
        public static Boolean IsInOpenDialog = false;
        public static Boolean IsInSaveDialog = false;
        public static String OnlyViewExtension = "";
        public static void ActivateOpenFileDialog(String ExtensionToView)
        {
            IsInOpenDialog = true;
            IsInSaveDialog = false;
            OnlyViewExtension = ExtensionToView;
        }

        public static void ActivateSaveFileDialog(String ExtensionToView)
        {
            IsInOpenDialog = false;
            IsInSaveDialog = true;
            OnlyViewExtension = ExtensionToView;
        }

        public static String ReadTextFile(String path)
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
