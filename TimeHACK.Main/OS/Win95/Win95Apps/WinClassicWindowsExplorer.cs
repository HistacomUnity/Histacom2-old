using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeHACK.Engine.SaveSystem;
using System.IO;
using TimeHACK.Engine;
using Newtonsoft.Json;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicWindowsExplorer : UserControl
    {
        public Boolean IsFileOpenDialog = false;
        public Boolean IsFileSaveDialog = false;
        public String onlyViewExtension = "";
        String ToReplaceWith = ProfileDirectory;
        String currentDirectory = Path.Combine(ProfileDirectory, "folders");
        Int32 fileType = 6;
        String attemptedDirectory = "";
        WindowManager wm = new WindowManager();

        public WinClassicWindowsExplorer()
        {
            InitializeComponent();
        }




        //'Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        //'    mainView.Items.Clear()
        //'    Dim childamount As TreeNodeCollection
        //'    childamount = TreeView1.SelectedNode.Nodes
        //'    lblamountofobjects.Text = (childamount.Count & " objects(s)")
        //'    For Each TreeNode In TreeView1.SelectedNode.Nodes
        //'        If TreeNode.tag = "file" Then
        //'            TreeNode.forecolor = TreeView1.BackColor
        //'        End If
        //'        mainView.Items.Add(TreeNode.text)
        //'    Next
        //'End Sub

        void CheckLbl() {
            try
            {
                dirLbl.Text = dirLbl.Text.Replace(GameDirectory, "");
                dirLbl.Text = dirLbl.Text.Replace("\\TimeHACK\\", "");
                dirLbl.Text = dirLbl.Text.Replace(ProfileDirectory, "");
                dirLbl.Text = dirLbl.Text.Replace("\\Profiles\\" + ProfileName + "\\", "");
                dirLbl.Text = dirLbl.Text.Replace("folders", "My Computer");
                //dirLbl.Text = dirLbl.Text.Substring(7, dirLbl.Text.Length - 7);
            } catch
            {

            }
        }

        String ReadDataFile(String reqDirectory, Boolean returnYesIfProtected = false) {
            String Val = "";
            try
            {
                String directoryFileInfo;
                directoryFileInfo = File.ReadAllText(reqDirectory);
                FileSystemFolderInfo toRead = new FileSystemFolderInfo();
                toRead = JsonConvert.DeserializeObject<FileSystemFolderInfo>(directoryFileInfo);

                if (returnYesIfProtected == true)
                {
                    if (toRead.Isprotected == true)
                    {
                        return "yes";                        
                    }
                } else {
                    return toRead.label;
                }
            } catch (Exception ex) {

            }
            return Val;
        }

        void RefreshAll() {
            try {
                // Refresh the right listview
                icons.Images.Clear();
                this.mainView.Items.Clear();
                diskView.SmallImageList = icons;
                this.mainView.LargeImageList = icons;
                // For Each drive As String In My.Computer.FileSystem.GetDirectories(GameMain.MyDocuments & "\HistacomVB\" & GameMain.SaveProfile & "\HistacomVB\Folders")
                //    If GetPropetiesForDir(drive)(4) = "isMyDocuments" Then
                //        diskView.Items.Add("", 0)
                //    End If
                //Next
                foreach (String str in Directory.GetDirectories(currentDirectory))
                {
                    String label = ReadDataFile(str, false);
                    if (label == "")
                    {
                        this.mainView.Items.Add(Path.GetFileName(str), 1);
                        this.mainView.FindItemWithText(Path.GetFileName(str)).Tag = Path.GetFileName(str);
                    } else {
                        this.mainView.Items.Add(label, 1);
                        this.mainView.FindItemWithText(label).Tag = Path.GetFileName(str);
                    }
                }
                foreach (String str in Directory.GetFiles(currentDirectory))
                {
                    if (IsFileOpenDialog == true || IsFileSaveDialog == true)
                    {
                        if (!(Path.GetFileName(str) == "_data.info"))
                        {
                            if (new FileInfo(str).Extension == onlyViewExtension)
                            {
                                this.mainView.Items.Add(Path.GetFileName(str), 0);
                            }
                        }
                    } else {
                        if (!(Path.GetFileName(str) == "_data.info")) {
                            this.mainView.Items.Add(Path.GetFileName(str));
                        }
                    }
                }
                dirLbl.Text = currentDirectory;
                CheckLbl();
            } catch (Exception ex) {
                wm.startInfobox95("Windows Explorer", "Error with the file explorer \n" + ex.Message, Properties.Resources.Win95Info);
                ((Form)this.TopLevelControl).Close();
            }
        }

        String ReturnType(String extension) {
            String returnVal = "";
            fileType = 1;
            switch (extension) {
                case ".txt":
                    fileType = 1;
                    returnVal = "Text Document \n createtext";
                    break;
                case ".dat":
                    fileType = 1;
                    returnVal = "Text Document \n createtext";
                    break;
                case ".rtf":
                    fileType = 2;
                    returnVal = "Rich Text Document \n createtext";
                    break;
                case ".cfg":
                    fileType = 1;
                    returnVal = "Config file \n createtext";
                    break;
                case ".log":
                    fileType = 1;
                    returnVal = "log text file \n createtext";
                    break;
                case ".properties":
                    fileType = 1;
                    returnVal = "Config file \n createtext";
                    break;
                case ".json":
                    fileType = 1;
                    returnVal = "Config file \n createtext";
                    break;
                case ".doc":
                    fileType = 3;
                    returnVal = "Word Document (Old) \n word";
                    break;
                case ".docx":
                    fileType = 3;
                    returnVal = "Word Document \n word";
                    break;
                case ".docm":
                    fileType = 3;
                    returnVal = "Macro-Enabled Word Document \n word";
                    break;
                case ".xls":
                    fileType = 4;
                    returnVal = "Excel Spreadsheets (Old) \n excel";
                    break;
                case ".xlsx":
                    fileType = 4;
                    returnVal = "Excel Spreadsheets \n excel";
                    break;
                case ".ppt":
                    fileType = 5;
                    returnVal = "Powerpoint Presentation (Old) \n powerpoint";
                    break;
                case ".pptx":
                    fileType = 5;
                    returnVal = "Powerpoint Presentation \n powerpoint";
                    break;
                case ".pub":
                    fileType = 7;
                    returnVal = "Publisher Document \n powerpoint";
                    break;
                case ".xps":
                    fileType = 8;
                    returnVal = "XPS Document \n xpsview";
                    break;
                case ".htm":
                    fileType = 9;
                    returnVal = "HTML web page \n html";
                    break;
                case ".html":
                    fileType = 9;
                    returnVal = "HTML web page \n html";
                    break;
                case ".wps":
                    fileType = 10;
                    returnVal = "Works document \n works";
                    break;
                case ".wmf":
                    fileType = 11;
                    returnVal = "Windows Metafile (A picture) \n createart";
                    break;
                case ".emf":
                    fileType = 11;
                    returnVal = "Enhanced Metafile (A picture) \n createart";
                    break;
                case ".png":
                    fileType = 11;
                    returnVal = "Picture file (Portable Network Graphics) \n createart";
                    break;
                case ".jpg":
                    fileType = 11;
                    returnVal = "Picture file \n createart";
                    break;
                case ".jpeg":
                    fileType = 11;
                    returnVal = "Picture file \n createart";
                    break;
                case ".gif":
                    fileType = 12;
                    returnVal = "Picture file \n gifman";
                    break;
                case ".tif":
                    fileType = 11;
                    returnVal = "Picture file \n createart";
                    break;
                case ".bmp":
                    fileType = 11;
                    returnVal = "Picture file \n createart";
                    break;
                case ".zip":
                    fileType = 11;
                    returnVal = "Compressed ZIP file \n winrar";
                    break;
                case ".rar":
                    fileType = 11;
                    returnVal = "WINRAR Compressed file \n winrar";
                    break;
                case ".gz":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".7z":
                    fileType = 11;
                    returnVal = "7ZIP file \n 7z";
                    break;
                case ".ace":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".arj":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".bz2":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".gzip":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".lzh":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".tar":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".uue":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".xz":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".z":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".001":
                    fileType = 11;
                    returnVal = "WINRAR file \n winrar";
                    break;
                case ".exe":
                    fileType = 12;
                    returnVal = "Program \n exe";
                    break;
                case ".jar":
                    fileType = 13;
                    returnVal = "Java file \n java";
                    break;
                case ".iso":
                    fileType = 14;
                    returnVal = "CD Image file \n iso";
                    break;
                case ".avi":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".m4v":
                    fileType = 15;
                    returnVal = "Video (MPEG-4) \n video";
                    break;
                case ".mp4":
                    fileType = 15;
                    returnVal = "Video (MPEG-4) \n video";
                    break;
                case ".wmv":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".m2v":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".m3u":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".mts":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".dv":
                    fileType = 15;
                    returnVal = "Video (Digital Video) \n video";
                    break;
                case ".flv":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".m1v":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".m2ts":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".mkv":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".mov":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".mpeg4":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".mpeg":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".mpg":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".3gp":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".m4p":
                    fileType = 15;
                    returnVal = "Video \n video";
                    break;
                case ".mp2":
                    fileType = 21;
                    returnVal = "Audio \n video";
                    break;
                case ".mp3":
                    fileType = 21;
                    returnVal = "Audio \n video";
                    break;
                case ".wav":
                    fileType = 21;
                    returnVal = "Audio \n video";
                    break;
                case ".nls":
                    fileType = 16;
                    returnVal = "Font file \n font";
                    break;
                case ".dll":
                    fileType = 17;
                    returnVal = "System File \n sys";
                    break;
                case ".bat":
                    fileType = 18;
                    returnVal = "MS-DOS Batch file \n winterm";
                    break;
                case ".url":
                    fileType = 19;
                    returnVal = "Shortcut \n short";
                    break;
                case ".sh":
                    fileType = 20;
                    returnVal = "BASH file \n winterm";
                    break;
                case ".win":
                    fileType = 17;
                    returnVal = "System file \n sys";
                    break;
            }
            return returnVal;
        }

    //Private Sub windows_explorer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    //    IsFileDialog = False
    //End Sub
        void WinClassicWindowsExplorer_Load(object sender, EventArgs e) {
            icons.Images.Add(Properties.Resources.WinClassicFolder);
            icons.Images.Add(Properties.Resources.WinClassicComputer);
            program.BringToFront();
            dirLbl.Text = "folders";
            diskView.Items.Add("My Computer", 0);
            CheckLbl();
            RefreshAll();
            if (FileDialogBoxManager.IsInOpenDialog)
            {
                IsFileOpenDialog = true;
            } else if (FileDialogBoxManager.IsInSaveDialog) {
                IsFileSaveDialog = true;
            }

            if (IsFileOpenDialog == true)
            {
                pnlSave.Show();
                Button1.Text = "Open";
            } else {
                pnlSave.Show();
                Button1.Text = "Save";
            }

            onlyViewExtension = FileDialogBoxManager.OnlyViewExtension;
        }

        void mainView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if ((String)mainView.FocusedItem.Tag != "") { // If it isn't a file
                    GoToDir(currentDirectory + "\\" + mainView.FocusedItem.Tag);
                } else { // If it is a file
                    if (IsFileOpenDialog == true || IsFileSaveDialog == true) { // If it is a open/save file dialog box
                        Program.WindowsExplorerReturnPath = currentDirectory + "\\" + mainView.FocusedItem.Text;
                        ((Form)this.TopLevelControl).Close();

                    } else {

                        ReturnType(new FileInfo(currentDirectory + "\\" + mainView.FocusedItem.Text).Extension);

                        switch (fileType) {
                            case 1:
                              //ManageTextFile.OpenNewTextFile(currentDirectory + "\\" + mainView.FocusedItem.Text);
                              break;
                        }
                    }
                }

            } catch (Exception ex) {

            }
        }

        void diskView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (diskView.FocusedItem.Text == "My Computer") {

                    GoToDir(ProfileFileSystemDirectory);

                }


            } catch (Exception ex) {
            }
        }

        void btnGo_Click(object sender, EventArgs e)
        {
            GoToDir(ProfileDirectory + "\\" + dirLbl.Text.Replace("My Computer", "folders"));
        }

        void GoToDir(String dir, Boolean GoneThoughHidden = false)
        {
            if (ReadDataFile(dir, true) == "yes" && (GoneThoughHidden == false)) {
                attemptedDirectory = dir;
                mainView.Hide();
                pnlHidden.BringToFront();
                pnlHidden.Show();
            } else {
                pnlHidden.Hide();
                mainView.Show();
                mainView.BringToFront();
                currentDirectory = dir;
                RefreshAll();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToDir(attemptedDirectory, true);
        }

        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(currentDirectory + "\\New Folder")) {
                wm.startInfobox95("Windows Explorer", "This directory already exists", Properties.Resources.Win95Info);
            } else {
                Directory.CreateDirectory(currentDirectory + "\\New Folder");
                SaveDirectoryInfo(currentDirectory + "\\New Folder", false, "New Folder", true);
                
                RefreshAll();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtSave.Text == "")
            {
                wm.startInfobox95("Windows Explorer", "Please enter a filename", Properties.Resources.Win95Info);
            }
            else
            {
                if (new FileInfo(currentDirectory + "\\" + txtSave.Text).Extension == onlyViewExtension)
                {

                    Program.WindowsExplorerReturnPath = currentDirectory + "\\" + txtSave.Text;

                }

                FileDialogBoxManager.IsInOpenDialog = false;
                FileDialogBoxManager.IsInSaveDialog = false;

              ((Form)this.TopLevelControl).Close();
            }
        }
    }
}
