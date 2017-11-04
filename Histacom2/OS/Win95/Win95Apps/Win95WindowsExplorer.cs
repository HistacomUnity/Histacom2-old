using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Histacom2.Engine.SaveSystem;
using System.IO;
using Histacom2.Engine;
using Newtonsoft.Json;
using Histacom2.Engine.Template;
using System.Diagnostics;
using Histacom2.OS.Win95.Win95Apps._12padamViruses;
using Histacom2.GlobalPrograms;

namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class Win95WindowsExplorer : UserControl
    {
        public bool IsFileOpenDialog = false;
        public bool IsFileSaveDialog = false;
        public List<string> onlyViewExtension = new List<string>();

        string ToReplaceWith = ProfileDirectory;
        public string CurrentDirectory = ProfileMyComputerDirectory;
        string OldLabelText;
        string CurrentCopyFile;
        //string attemptedDirectory = "";
        WindowManager wm = new WindowManager();

        public Win95WindowsExplorer()
        {
            InitializeComponent();


            // Fonts! yoy!

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            }

            txtSave.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cmbType.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            //Histacom2.Engine.UI.CustomTextBox ctb = new Histacom2.Engine.UI.CustomTextBox(textBox1);
        }

        void WinClassicWindowsExplorer_Load(object sender, EventArgs e)
        {
            diskView.ImageList = new ImageList();

            diskView.ImageList.Images.Add(Properties.Resources.Win95DesktopIcon);
            diskView.ImageList.Images.Add(Properties.Resources.Win95HardDiskIcon);
            diskView.ImageList.Images.Add(Properties.Resources.WinClassicFolderSmall);
            diskView.ImageList.Images.Add(Properties.Resources.WinClassicOpenFolderSmall);
            diskView.ImageList.Images.Add(Properties.Resources.Win95ControlPanelIcon);
            diskView.ImageList.Images.Add(Properties.Resources.Win95PrintersFolder);
            diskView.ImageList.Images.Add(Properties.Resources.Win95ComputerIcon);
            diskView.ImageList.Images.Add(Properties.Resources.Win95NetworkIcon);
            diskView.ImageList.Images.Add(Properties.Resources.Win95RecycleIcon);

            mainView.LargeImageList = new ImageList();
            mainView.LargeImageList.ImageSize = new Size(32, 32);

            // Icons 17, 18, 19 reserved for exclusive apps

            mainView.LargeImageList.Images.AddRange(new Bitmap[] { Properties.Resources.Win95Computer, // 0
                                                    Properties.Resources.WinClassicFolder,
                                                    Properties.Resources.WinClassicIE4,
                                                    Properties.Resources.WinClassicInbox,
                                                    Properties.Resources.WinClassicMSN,
                                                    Properties.Resources.WinClassicNetworking, // 5
                                                    Properties.Resources.WinClassicOutlook,
                                                    Properties.Resources.WinClassicRecycle,
                                                    Properties.Resources.Win95File,
                                                    Properties.Resources.WinClassicFolder,
                                                    Properties.Resources.WinClassicApp, // 10
                                                    Properties.Resources.WinClassicSetup,
                                                    Properties.Resources.WinClassicNotepad,
                                                    Properties.Resources.WinClassicCalcBig,
                                                    Properties.Resources.WinClassicNotepadBig,
                                                    Properties.Resources.WinClassicRegedit, // 15
                                                    Properties.Resources.WinClassicWordpad,
													Properties.Resources.TimeDistorter1,
                                                    Properties.Resources.WinClassicGTN,
                                                    Properties.Resources.WinClassicFTP,
                                                    Properties.Resources.WinClassicRtfFile, // 20
                                                    Properties.Resources.WinClassicAddressBookBig});

            program.BringToFront();


            //diskView.Items.Add("My Computer", 0);
            Application.DoEvents();

            RefreshAll();
            RefreshTreeNode();

            if (FileDialogBoxManager.IsInOpenDialog)
            {
                IsFileOpenDialog = true;
            }
            else if (FileDialogBoxManager.IsInSaveDialog)
            {
                IsFileSaveDialog = true;
            }

            if (IsFileOpenDialog)
            {
                pnlSave.Show();
                btnSave.Text = "Open";
            }
            else
            {
                if (IsFileSaveDialog)
                {
                    pnlSave.Show();
                    btnSave.Text = "Save";
                }
            }

            onlyViewExtension = FileDialogBoxManager.OnlyViewExtension;

            foreach (string str in onlyViewExtension)
                cmbType.Items.Add(str);
        }

        string ReadDataFile(string reqDirectory, bool returnYesIfProtected = false) {
            string Val = "";
            string directoryFileInfo;
            directoryFileInfo = File.ReadAllText(Path.Combine(reqDirectory, "_data.info"));
            FileSystemFolderInfo toRead = new FileSystemFolderInfo();
            toRead = JsonConvert.DeserializeObject<FileSystemFolderInfo>(directoryFileInfo);

            if (returnYesIfProtected)
            {
                if (toRead.IsProtected) return "yes";
            }
            else return toRead.Label;
            return Val;
        }

        private void RefreshAll()
        {
            //try
            //{
                this.mainView.Items.Clear();

                foreach (string str in Directory.GetDirectories(CurrentDirectory))
                {
                    string label = ReadDataFile(str, false);
                    ListViewItem itm = this.mainView.Items.Add(label ?? Path.GetFileName(str));
                    itm.ImageIndex = 1;
                    itm.Tag = str;
                }
                foreach (string str in Directory.GetFiles(CurrentDirectory))
                {
                    ListViewItem itm;

                    if (IsFileOpenDialog || IsFileSaveDialog)
                    {
                        if (!(Path.GetFileName(str) == "_data.info"))
                        { 
                            if (onlyViewExtension.Contains(new FileInfo(str).Extension))
                            {
                                itm = this.mainView.Items.Add(Path.GetFileName(str));
                                itm.Tag = str;
                            }
                            else continue;
                        }
                        else continue;
                    }
                    else {
                        if (!(Path.GetFileName(str) == "_data.info"))
                        {
                            itm = this.mainView.Items.Add(Path.GetFileName(str));
                            itm.Tag = str;
                        }
                        else continue;
                    }
                    FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(CurrentDirectory, "_data.info")));
                    foreach (var item in fsfi.Files)
                    {
                        Debug.Print(item.Name + " " + Path.GetFileName(str));
                        if (item.Name == Path.GetFileName(str)) { itm.ImageIndex = item.FileIcon; break; }
                    }
                }
                /*
            } catch (Exception ex) {
                //wm.StartInfobox95("Exploring - C:", "Error with the file explorer \n" + ex.Message, Properties.Resources.Win95Info); add illegal operation dialog here later
                ((Form)this.TopLevelControl).Close();
            }*/
        }

        private void RefreshTreeNode()
        {
            // Refresh the TreeView

            diskView.Nodes.Clear();
            int loc = 0;
            TreeNode[] folders = new TreeNode[new DirectoryInfo(ProfileMyComputerDirectory).GetDirectories().Length];
            foreach (DirectoryInfo folder in new DirectoryInfo(ProfileMyComputerDirectory).GetDirectories())
            {
                if (folder.GetDirectories().Length > 0)
                {
                    string label = ReadDataFile(folder.FullName, false);
                    TreeNode[] tn = createSubDirNodes(folder);
                    folders[loc] = new TreeNode(label ?? folder.Name, 2, 3, tn);
                    folders[loc].Tag = folder.FullName;
                }
                else
                {
                    string label = ReadDataFile(folder.FullName, false);
                    folders[loc] = new TreeNode(label ?? folder.Name, 2, 3);
                    folders[loc].Tag = folder.FullName;
                }
                loc++;
            }
            TreeNode[] mypcarray = new TreeNode[3];
            mypcarray[0] = new TreeNode("(C:)", 1, 1, folders);
            mypcarray[1] = new TreeNode("Control Panel", 4, 4);
            mypcarray[2] = new TreeNode("Printers", 5, 5);
            TreeNode[] desktoparray = new TreeNode[3];
            desktoparray[0] = new TreeNode("My Computer", 6, 6, mypcarray);
            desktoparray[1] = new TreeNode("Network Neighborhood", 7, 7);
            desktoparray[2] = new TreeNode("Recycle Bin", 8, 8);
            diskView.Nodes.Add(new TreeNode("Desktop", 0, 0, desktoparray));
        }

        public void OpenFile(string fileDir)
        {
            try
            {
                switch (ReturnType(new FileInfo(fileDir).Extension))
                {
                    case 1:
                        WinClassicNotepad np = new WinClassicNotepad();
                        np.mainText.Text = FileDialogBoxManager.ReadTextFile(fileDir);
                        np.CurrentFilePath = fileDir;
                        WinClassic app = wm.Init(np, "Notepad", Properties.Resources.Win95IconNotepad, true, true);

                        Program.AddTaskbarItem(app, app.Tag.ToString(), "Notepad", Properties.Resources.Win95IconNotepad);
                        break;
                    case 2:
                        WinClassicWordPad wp = new WinClassicWordPad();
                        wp.mainText.LoadFile(fileDir);
                        wp.CurrentFilePath = fileDir;
                        WinClassic app2 = wm.Init(wp, "Wordpad", Properties.Resources.Win95IconWordpad, true, true);

                        Program.AddTaskbarItem(app2, app2.Tag.ToString(), "Wordpad", Properties.Resources.Win95IconWordpad);
                        break;
                    case 12:
                        OpenApplication(FileDialogBoxManager.ReadTextFile(fileDir), fileDir);
                        break;
                }
            } catch {
            }
        }

        void OpenApplication(string appname, string path)
        {
            switch (appname.ToLower())
            {
                case "explorer":
                    WinClassic app = wm.Init(new Win95WindowsExplorer(), "Windows Explorer", Properties.Resources.WinClassicFileExplorer, true, true);
                    Program.AddTaskbarItem(app, app.Tag.ToString(), "Windows Explorer", Properties.Resources.WinClassicFileExplorer);
                    break;
                case "calc":
                    WinClassic appCalc = wm.Init(new WinClassicCalculator(), "Calculator", Properties.Resources.WinClassicCalc, true, true);
                    Program.AddTaskbarItem(appCalc, appCalc.Tag.ToString(), "Calculator", Properties.Resources.WinClassicCalc);

                    Program.nonimportantapps.Add(appCalc);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    break;
                case "notepad":
                    WinClassic appNP = wm.Init(new WinClassicNotepad(), "Notepad", Properties.Resources.Win95IconNotepad_2, true, true);
                    Program.AddTaskbarItem(appNP, appNP.Tag.ToString(), "Notepad", Properties.Resources.Win95IconNotepad_2);

                    Program.nonimportantapps.Add(appNP);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    break;
                case "wordpad":
                    WinClassic appWP = wm.Init(new WinClassicWordPad(), "Wordpad", Properties.Resources.Win95WordpadIcon2, true, true);
                    Program.AddTaskbarItem(appWP, appWP.Tag.ToString(), "Wordpad", Properties.Resources.Win95WordpadIcon2);

                    Program.nonimportantapps.Add(appWP);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    break;
                case "ie":
                    if (TitleScreen.frm95.ie != null) { wm.StartInfobox95("Error Opening Internet Explorer", "An instance of Internet Explorer 4 is already open.", InfoboxType.Warning, InfoboxButtons.OK); return; }
                    TitleScreen.frm95.ie = wm.Init(new WinClassicIE3(), "Internet Explorer 4", Properties.Resources.Win95IconIE4, true, true);
                    Program.AddTaskbarItem(TitleScreen.frm95.ie, TitleScreen.frm95.ie.Tag.ToString(), "Internet Explorer 4", Properties.Resources.Win95IconIE4);
                    TitleScreen.frm95.ie.BringToFront();
                    TitleScreen.frm95.ie.FormClosing += new FormClosingEventHandler(TitleScreen.frm95.InternetExplorer4_Closing);

                    break;
                case "web chat setup":
                    Win95Installer inst = new Win95Installer("Web Chat 1998");
                    inst.InstallCompleted += (sendr, args) => { TitleScreen.frm95.WebChatToolStripMenuItem.Visible = true; CurrentSave.installed95[0] = true; SaveGame(); };
                    WinClassic appInstaller = wm.Init(inst, "Web Chat Setup", null, true, true);
                    Program.AddTaskbarItem(appInstaller, appInstaller.Tag.ToString(), "Web Chat Setup", null);
                    appInstaller.BringToFront();

                    break;
                case "ftp client setup":
                    Win95Installer instFtp = new Win95Installer("FTP Client");
                    instFtp.InstallCompleted += (sendr, args) =>
                    {
                        SaveDirectoryInfo(ProfileProgramsDirectory, "12padams", true, "12padams", true);
                        SaveDirectoryInfo(Path.Combine(ProfileProgramsDirectory, "12padams"), "FTP Client", true, "FTP Client", true);
                        CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "12padams", "FTP Client"), "ftpclint.exe", "ftp client", 19, 58395);
                        TitleScreen.frm95.FTPClientToolStripMenuItem.Visible = true;
                        CurrentSave.installed95[1] = true;
                        SaveGame();
                    };
                    WinClassic appFtp = wm.Init(instFtp, "FTP Client Setup", null, true, true);
                    Program.AddTaskbarItem(appFtp, appFtp.Tag.ToString(), "FTP Client Setup", null);
                    appFtp.BringToFront();

                    break;
                case "time distorter setup":
                    Win95Installer instTd = new Win95Installer("Time Distorter 0.1");
                    instTd.InstallCompleted += (sendr, args) =>
                    {
                        SaveDirectoryInfo(ProfileProgramsDirectory, "12padams", true, "12padams", true);
                        SaveDirectoryInfo(Path.Combine(ProfileProgramsDirectory, "12padams"), "Time Distorter 0.1", true, "Time Distorter 0.1", true);
                        CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "12padams", "Time Distorter 0.1"), "tdistort.exe", "time distorter", 17, 23895);
                        TitleScreen.frm95.TimeDistorterToolStripMenuItem.Visible = true;
                        CurrentSave.installed95[5] = true;
                        SaveGame();
                    };
                    WinClassic appTd = wm.Init(instTd, "Time Distorter Setup", null, true, true);
                    Program.AddTaskbarItem(appTd, appTd.Tag.ToString(), "Time Distorter Setup", null);
                    appTd.BringToFront();

                    break;
                case "iebrokeninstaller":
                    wm.StartInfobox95("Internet Explorer Installer", "Installation Failed: The INF file was not found", InfoboxType.Error, InfoboxButtons.OK);

                    break;
                case "gtnv1 setup":
                    Win95Installer instGtn = new Win95Installer("Guess The Number V1");
                    instGtn.InstallCompleted += (sendr, args) =>
                    {
                        SaveDirectoryInfo(ProfileProgramsDirectory, "12padams", true, "12padams", true);
                        SaveDirectoryInfo(Path.Combine(ProfileProgramsDirectory, "12padams"), "Guess The Number V1", true, "Guess The Number V1", true);
                        CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "12padams", "Guess The Number V1"), "guessnum.exe", "guess number", 18, 17483);
                        TitleScreen.frm95.GuessTheNumberToolStripMenuItem.Visible = true;
                        CurrentSave.installed95[6] = true;
                        SaveGame();
                    };
                    WinClassic appGtn = wm.Init(instGtn, "Guess The Number Setup", null, true, true);
                    Program.AddTaskbarItem(appGtn, appGtn.Tag.ToString(), "Guess The Number Setup", null);
                    appGtn.BringToFront();

                    break;
                case "guess number":
                    WinClassic appGTN = wm.Init(new GuessTheNumber(), "Guess The Number", Properties.Resources.WinClassicGTNIcon, false, true, false, false);
                    Program.AddTaskbarItem(appGTN, appGTN.Tag.ToString(), "Guess The Number", Properties.Resources.WinClassicGTNIcon);

                    Program.nonimportantapps.Add(appGTN);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);

                    break;
                case "eb95 setup":
                    Win95Installer ebInstall = new Win95Installer("Error Blaster 95");
                    ebInstall.InstallCompleted += (sender, args) => { TitleScreen.frm95.ErrorBlasterToolStripMenuItem.Visible = true; CurrentSave.installed95[3] = true; };
                    WinClassic installer = wm.Init(ebInstall, "Error Blaster 95 Setup", null, true, true);
                    Program.AddTaskbarItem(installer, installer.Tag.ToString(), "Error Blaster 95 Setup", null);
                    installer.BringToFront();
                    break;
                case "error blaster":
                    WinClassic eb = wm.Init(new ErrorBlaster95(), "Welcome to Error Blaster 95!", null, true, true);
                    Program.AddTaskbarItem(eb, eb.Tag.ToString(), "Welcome to Error Blaster 95!", null);
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].BringToFront();
                    Program.nonimportantapps[Program.nonimportantapps.Count - 1].FormClosing += new FormClosingEventHandler(Program.NonImportantApp_Closing);
                    break;
                case "sr95 setup":
                    Win95Installer srInstall = new Win95Installer("Start Runner 95");
                    srInstall.InstallCompleted += (sender, args) => { TitleScreen.frm95.StartRunnerToolStripMenuItem.Visible = true; CurrentSave.installed95[2] = true; };
                    WinClassic install = wm.Init(srInstall, "Start Runner 95 Setup", null, true, true);
                    Program.AddTaskbarItem(install, install.Tag.ToString(), "Start Runner 95 Setup", null);
                    install.BringToFront();
                    break;
                default:
                    wm.StartInfobox95(path.Replace(ProfileMyComputerDirectory, "C:"), $"{path.Replace(ProfileMyComputerDirectory, "C:")} is not a valid Win32 application.", InfoboxType.Error, InfoboxButtons.OK);
                    break;
            }
        }

        int ReturnType(string extension) {
            switch (extension) {
                case ".txt":
                case ".cfg":
                case ".log":
                case ".ini":
                case ".properties":
                case ".json":
                case ".dat":
                    return 1;

                case ".rtf":
                    return 2;      
                    
                case ".doc":
                    return 3;
                case ".docm":
                    return 3;
                case ".xls":
                    return 4;
                case ".ppt":
                    return 5;
                case ".pub":
                    return 7;
                case ".xps":
                    return 8;
                case ".htm":
                    return 9;
                case ".html":
                    return 9;
                case ".wps":
                    return 10; 
                case ".wmf":
                case ".emf":
                case ".png":
                case ".jpg":
                case ".jpeg":
                case ".gif":
                case ".tif":
                case ".bmp":
                case ".zip":
                    return 11;

                case ".exe":
                    return 12;
                case ".avi":              
                case ".m4v":
                case ".mp4":
                case ".wmv":
                case ".m2v":
                case ".m3u":
                case ".mts":
                case ".dv":
                case ".flv":
                case ".m1v":
                case ".m2ts":
                case ".mkv":
                case ".mov":
                case ".mpeg4":
                case ".mpeg":
                case ".mpg":
                case ".3gp":
                case ".m4p":
                    return 15;

                case ".mp2":
                case ".mp3":
                case ".wav":
                    return 21;
                case ".nls":
                    return 16;
                case ".dll":
                    return 17;
                case ".bat":
                    return 18;
                case ".url":
                    return 19;
                case ".sh":
                    return 20;
                case ".win":
                    return 17;
            }
            return 0;
        }

    //Private Sub windows_explorer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    //    IsFileDialog = False
    //End Sub

        void mainView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text)))
                { // If it isn't a file
                    if (mainView.FocusedItem.Text == "C:")
                        GoToDir(Path.Combine(CurrentDirectory, "CDrive"));
                    else
                        GoToDir(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text));
                }
                else
                { // If it is a file
                        if (IsFileOpenDialog || IsFileSaveDialog)
                        {
                            if (onlyViewExtension.Contains(new FileInfo(Path.Combine(CurrentDirectory, txtSave.Text)).Extension))
                            {
                                Program.WindowsExplorerReturnPath = Path.Combine(CurrentDirectory, txtSave.Text);
                            }


                            FileDialogBoxManager.IsInOpenDialog = false;
                            FileDialogBoxManager.IsInSaveDialog = false;

                            ((Form)this.TopLevelControl).Close();
                        }
                        else
                            OpenFile(mainView.FocusedItem.Tag.ToString());
                }
            } catch { /* TODO: Illegal operation */ }
        }

        void diskView_AfterSelect(object sender, EventArgs e)
        {
            try
            {
                if (diskView.SelectedNode != null)
                {
                    if (diskView.SelectedNode.Text == "My Computer")
                    {
                        GoToDir(ProfileFileSystemDirectory);
                    }
                    else if (diskView.SelectedNode.Text == "(C:)")
                    {
                        GoToDir(ProfileMyComputerDirectory);
                    }
                    else
                    {
                        if (diskView.SelectedNode.Tag != null)
                        {
                            // It is a directory:

                            try
                            {
                                GoToDir(diskView.SelectedNode.Tag.ToString());
                            }
                            catch { }
                        }
                    }
                }
            } catch {
            }
        }

        void GoToDir(string dir)
        {
            mainView.Show();
            mainView.BringToFront();
            CurrentDirectory = dir;
            RefreshAll();
        }

        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(CurrentDirectory + "\\New Folder"))
            {
                //wm.StartInfobox95("Windows Explorer", "This directory already exists", Properties.Resources.Win95Info);
                //TODO: add making "New Folder (2)"
            }
            else
            {
                SaveDirectoryInfo(CurrentDirectory, "New Folder", false, "New Folder", true, false);

                RefreshAll();
                OldLabelText = "New Folder";
                mainView.LabelEdit = true;
                mainView.FindItemWithText("New Folder").BeginEdit();
            }

            RefreshTreeNode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainView.FocusedItem != null)
                {
                    if (mainView.FocusedItem.Tag.ToString() == "")
                    { // If it isn't a file
                        GoToDir(Path.Combine(CurrentDirectory, mainView.FocusedItem.Tag.ToString()));
                    }
                    else txtSave.Text = mainView.FocusedItem.Tag.ToString();
                }
                if (txtSave.Text == "") wm.StartInfobox95("Windows Explorer", "Please enter a filename", InfoboxType.Info, InfoboxButtons.OK);
                else
                {
                    if (onlyViewExtension.Contains(new FileInfo(Path.Combine(CurrentDirectory, txtSave.Text)).Extension)) Program.WindowsExplorerReturnPath = Path.Combine(CurrentDirectory, txtSave.Text);

                    FileDialogBoxManager.IsInOpenDialog = false;
                    FileDialogBoxManager.IsInSaveDialog = false;

                    ((Form)this.TopLevelControl).Close();
                }
            }
            catch { }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FileOrDirectoryExists(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text)))
                {
                    wm.StartInfobox95("Windows Explorer", "This directory doesn't exist", InfoboxType.Info, InfoboxButtons.OK);
                }
                else
                {
                    if (Directory.Exists(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text)))
                    {
                        Directory.Delete(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text), true);

                        // Remove the directory now from the _data.info

                        SaveSystem.RemoveSubDirFromDirectory(CurrentDirectory, mainView.FocusedItem.Text);
                    }
                    else
                    {
                        File.Delete(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text));

                        // Remove the file now from the _data.info

                        RemoveFileFromDirectory(CurrentDirectory, mainView.FocusedItem.Text);
                      
                    }

                    RefreshAll();
                    RefreshTreeNode();
                }
            } catch
            {
                RefreshAll();
            }

            RefreshTreeNode();
        }

        internal static bool FileOrDirectoryExists(string path)
        {
             return (Directory.Exists(path) || File.Exists(path));
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
        private void AboutWindows95ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            wm.StartAboutBox95("Windows 95", "Microsoft Windows 95 Rev B", Properties.Resources.WinClassicAbout95);
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // The AfterLabelEdit event will kick in after this
                OldLabelText = mainView.FocusedItem.Text;
                mainView.LabelEdit = true;
                mainView.FocusedItem.BeginEdit();
            } catch
            {

            }
        }

        private void mainView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                string setText = e.Label;
                if (setText == "") wm.StartInfobox95("Rename", "You must type a filename.", InfoboxType.Error, InfoboxButtons.OK);
                else
                {
                    if (Directory.Exists(setText)) wm.StartInfobox95("Error Renaming File", $"Cannot rename {new DirectoryInfo(setText).Name}: A file with the name you specified already exists. Specify a different filename.", InfoboxType.Error, InfoboxButtons.OK);
                    else
                    {
                        if (File.Exists(setText)) wm.StartInfobox95("Error Renaming File", $"Cannot rename {new FileInfo(setText).Name}: A file with the name you specified already exists. Specify a different filename.", InfoboxType.Error, InfoboxButtons.OK);
                        else
                        {
                            if (Directory.Exists(Path.Combine(CurrentDirectory, OldLabelText)))
                            {
                                // It was a directory

                                Directory.Move(Path.Combine(CurrentDirectory, OldLabelText), Path.Combine(CurrentDirectory, setText));

                                File.Delete(Path.Combine(CurrentDirectory, setText, "_data.info"));
                                SaveDirectoryInfo(CurrentDirectory, setText, false, setText, true, true);

                                // Rename the directory now in the _data.info

                                RenameDirectory(CurrentDirectory, OldLabelText, setText);
                            }
                            else
                            {
                                // It was a file                    

                                File.Copy(Path.Combine(CurrentDirectory, OldLabelText), Path.Combine(CurrentDirectory, setText));
                                File.Delete(Path.Combine(CurrentDirectory, OldLabelText));

                                // Rename the file now in the _data.info

                                RenameFile(CurrentDirectory, OldLabelText, setText);
                            }
                        }
                    }
                }
                RefreshAll();
                RefreshTreeNode();
            } catch { }
        }

        private TreeNode[] createSubDirNodes(DirectoryInfo folder)
        {
            TreeNode[] toReturn = new TreeNode[folder.GetDirectories().Length];
            int loc = 0;
            foreach (DirectoryInfo fold in folder.GetDirectories())
            {
                if (fold.GetDirectories().Length > 0)
                {
                    string label = ReadDataFile(fold.FullName, false);
                    TreeNode[] tn = createSubDirNodes(fold);
                    toReturn[loc] = new TreeNode(label ?? fold.Name, 2, 3, tn);
                    toReturn[loc].Tag = fold.FullName;
                }
                else
                {
                    string label = ReadDataFile(fold.FullName, false);
                    toReturn[loc] = new TreeNode(label ?? fold.Name, 2, 3);
                    toReturn[loc].Tag = fold.FullName;
                }
                loc++;
            }
            return toReturn;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void CutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainView.FocusedItem != null && mainView.FocusedItem.ImageKey != "")
                {

                    // It is a directory
                    string oldLocation;
                    oldLocation = mainView.FocusedItem.ImageKey;

                    CurrentCopyFile = Path.Combine(GameDirectory, "Data", Path.GetFileName(mainView.FocusedItem.ImageKey));

                    if (Directory.Exists(CurrentCopyFile)) Directory.Delete(CurrentCopyFile);
                    if (File.Exists(CurrentCopyFile)) File.Delete(CurrentCopyFile);

                    Directory.Move(mainView.FocusedItem.ImageKey, Path.Combine(GameDirectory, "Data", Path.GetDirectoryName(mainView.FocusedItem.ImageKey)));


                    DirectoryCopy(CurrentCopyFile, oldLocation, true);
                }
                else if (mainView.FocusedItem != null)
                {
                    // It is a file

                    CurrentCopyFile = Path.Combine(GameDirectory, "Data", Path.GetFileName(mainView.FocusedItem.Tag.ToString()));

                    if (Directory.Exists(CurrentCopyFile)) Directory.Delete(CurrentCopyFile);
                    if (File.Exists(CurrentCopyFile)) File.Delete(CurrentCopyFile);

                    File.Move(mainView.FocusedItem.Tag.ToString(), Path.Combine(GameDirectory, "Data", Path.GetFileName(mainView.FocusedItem.Tag.ToString())));
                }
                RefreshAll();
            }
            catch
            {
            }
        }

        private void CopyCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainView.FocusedItem != null && mainView.FocusedItem.ImageKey != "")
                {
                    // It is a directory
                    string oldLocation;
                    oldLocation = mainView.FocusedItem.ImageKey;
                    CurrentCopyFile = Path.Combine(GameDirectory, "Data", Path.GetFileName(mainView.FocusedItem.ImageKey));

                    if (Directory.Exists(CurrentCopyFile)) Directory.Delete(CurrentCopyFile);
                    if (File.Exists(CurrentCopyFile)) File.Delete(CurrentCopyFile);

                    DirectoryCopy(CurrentCopyFile, oldLocation, true);
                }
                else if (mainView.FocusedItem != null)
                {
                    // It is a file

                    CurrentCopyFile = Path.Combine(GameDirectory, "Data", Path.GetFileName(mainView.FocusedItem.Tag.ToString()));

                    if (Directory.Exists(CurrentCopyFile)) Directory.Delete(CurrentCopyFile);
                    if (File.Exists(CurrentCopyFile)) File.Delete(CurrentCopyFile);

                    File.Copy(mainView.FocusedItem.Tag.ToString(), Path.Combine(GameDirectory, "Data", Path.GetFileName(mainView.FocusedItem.Tag.ToString())));

                }
                RefreshAll();
            }
            catch
            {
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(CurrentCopyFile))
            {
                // It is a directory

                DirectoryCopy(CurrentCopyFile, CurrentDirectory, true);
            }
            else if (File.Exists(CurrentCopyFile))
            {
                // It is a file

                File.Copy(CurrentCopyFile, Path.Combine(CurrentDirectory, Path.GetFileName(CurrentCopyFile)));
            }
            RefreshAll();
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (dir.Exists)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                // If the destination directory doesn't exist, create it.
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, false);
                }

                // If copying subdirectories, copy them and their contents to new location.
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
                }
            }
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void SellectAllCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in mainView.Items) item.Selected = true;
        }

        private void TextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(CurrentDirectory + "\\New Text Document.txt"))
            {
                //wm.StartInfobox95("Windows Explorer", "This directory already exists", Properties.Resources.Win95Info);
                //TODO: add making "New Text Document (2)"
            }
            else
            {
                CreateWindowsFile(CurrentDirectory, "New Text Document.txt", "", 12, 0);

                RefreshAll();
                OldLabelText = "New Folder";
                mainView.LabelEdit = true;
                mainView.FindItemWithText("New Text Document.txt").BeginEdit();
            }

            RefreshTreeNode();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
