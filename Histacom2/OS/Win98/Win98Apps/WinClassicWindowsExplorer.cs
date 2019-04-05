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
using System.Diagnostics;
using Histacom2.Engine.Template;
using Histacom2.OS.Win98.Win98Apps;
using Histacom2.GlobalPrograms;

namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class WinClassicWindowsExplorer : UserControl
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

        public WinClassicWindowsExplorer()
        {
            InitializeComponent();
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

            cmbType.Text = onlyViewExtension.FirstOrDefault();

            txtSave.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cmbType.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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

        string ReadDataFile(string reqDirectory, bool returnYesIfProtected = false) {
            string Val = "";
            string directoryFileInfo;
            directoryFileInfo = File.ReadAllText(Path.Combine(reqDirectory, "_data.info"));
            FileSystemFolderInfo toRead = new FileSystemFolderInfo();
            toRead = JsonConvert.DeserializeObject<FileSystemFolderInfo>(directoryFileInfo);

            if (returnYesIfProtected)
            {
                if (toRead.IsProtected)
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

        void RefreshAll() {
            //try {
            this.mainView.Items.Clear();

            if (CurrentDirectory == ProfileFileSystemDirectory)
            {
                txtInfoTitle.Text = "My Computer";
                pictureBox1.Image = Properties.Resources.Win95ComputerIcon;
            } else if (CurrentDirectory == ProfileMyComputerDirectory) {
                txtInfoTitle.Text = "C:";
                pictureBox1.Image = Properties.Resources.WinClassicDrive;
            } else {
                txtInfoTitle.Text = Path.GetFileName(CurrentDirectory);
                pictureBox1.Image = Properties.Resources.WinClassicFolder;
            }
             

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
                else
                {
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

        void RefreshTreeNode()
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
                    case 13:
                        WinClassicAddressBook wcab = new WinClassicAddressBook();
                        wcab.AddressBookObjects = JsonConvert.DeserializeObject<List<AddressBookContactList>>(File.ReadAllText(fileDir));

                        wcab.treeView1.Nodes.Clear();
                        wcab.treeView1.Nodes.Add("Shared Contacts");
                        foreach (AddressBookContactList lst in wcab.AddressBookObjects)
                            wcab.UpdateTreeView(lst);

                        WinClassic app3 = wm.Init(wcab, "Address Book", Properties.Resources.WinClassicAddressBook, true, true);

                        Program.AddTaskbarItem(app3, app3.Tag.ToString(), "Address Book", Properties.Resources.WinClassicAddressBook);
                        break;
                }
            }
            catch
            {
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
                    if (TitleScreen.frm98.ie != null) { wm.StartInfobox95("Error Opening Internet Explorer", "An instance of Internet Explorer 4 is already open.", InfoboxType.Warning, InfoboxButtons.OK); return; }
                    TitleScreen.frm98.ie = wm.Init(new WinClassicIE4(), "Internet Explorer 4", Properties.Resources.Win95IconIE4, true, true);
                    Program.AddTaskbarItem(TitleScreen.frm98.ie, TitleScreen.frm98.ie.Tag.ToString(), "Internet Explorer 4", Properties.Resources.Win95IconIE4);
                    TitleScreen.frm98.ie.BringToFront();
                    TitleScreen.frm98.ie.FormClosing += new FormClosingEventHandler(TitleScreen.frm98.InternetExplorer4_Closing);

                    break;
                case "web chat 99 setup":
                    WinClassicInstaller inst = new WinClassicInstaller("Web Chat 1999");
                    inst.InstallCompleted += (sendr, args) => TitleScreen.frm98.WebChatToolStripMenuItem.Visible = true;
                    WinClassic appInstaller = wm.Init(inst, "Web Chat Setup", null, false, true, false, false);
                    Program.AddTaskbarItem(appInstaller, appInstaller.Tag.ToString(), "Web Chat Setup", null);
                    appInstaller.BringToFront();

                    break;
                case "time distorter setup":
                    WinClassicInstaller instTd = new WinClassicInstaller("Time Distorter 0.2");
                    instTd.InstallCompleted += (sendr, args) =>
                    {
                        TitleScreen.frm98.TimeDistorterToolStripMenuItem.Visible = true;
                    };
                    WinClassic appTd = wm.Init(instTd, "Time Distorter Setup", null, false, true, false, false);
                    Program.AddTaskbarItem(appTd, appTd.Tag.ToString(), "Time Distorter Setup", null);
                    appTd.BringToFront();

                    break;
                case "iebrokeninstaller":
                    wm.StartInfobox95("Internet Explorer Installer", "Installation Failed: The INF file was not found", InfoboxType.Error, InfoboxButtons.OK);

                    break;
                default:
                    wm.StartInfobox95(path.Replace(ProfileMyComputerDirectory, "C:"), $"{path.Replace(ProfileMyComputerDirectory, "C:")} is not a valid Win32 application.", InfoboxType.Error, InfoboxButtons.OK);
                    break;
            }
        }

        int ReturnType(string extension)
        {
            switch (extension)
            {
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
                case ".wab":
                    return 13;
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
                    if (diskView.SelectedNode.Text == "My Computer" || diskView.SelectedNode.Text == "Desktop")
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

                            GoToDir(diskView.SelectedNode.Tag.ToString());
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
            if (File.Exists(CurrentDirectory + "\\New Folder")) {
                wm.StartInfobox95("Windows Explorer", "This directory already exists", InfoboxType.Info, InfoboxButtons.OK);
            } else {
                Directory.CreateDirectory(Path.Combine(CurrentDirectory, "New Folder"));
                SaveDirectoryInfo(CurrentDirectory, "New Folder", false, "New Folder", true);
                
                RefreshAll();
            }

            RefreshTreeNode();
        }

        private void Button1_Click(object sender, EventArgs e)
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
            }
            catch
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
            wm.StartAboutBox98("Windows 98", "Microsoft (R) Windows", Properties.Resources.WinClassicAbout95);
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
            }
            catch { }
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnFolderClose.Image = Properties.Resources.XCross_highlighted;
        }

        private void btnFolderClose_MouseLeave(object sender, EventArgs e)
        {
            btnFolderClose.Image = Properties.Resources.XCross;
        }

        private void btnFolderClose_Click(object sender, EventArgs e)
        {
            FoldersToolStripMenuItem.Checked = false;
            pnlFolders.Hide();
        }

        private void FoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FoldersToolStripMenuItem.Checked)
            {
                FoldersToolStripMenuItem.Checked = false;
                pnlFolders.Hide();
            } else {
                FoldersToolStripMenuItem.Checked = true;
                pnlFolders.Show();
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void mainView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This will change the web view!

            if (mainView.FocusedItem == null)
            {
                txtInfoTip.Show();
                InfoDesc.Hide();
            } else {
                txtInfoTip.Hide();

                if (File.Exists(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text)))
                {
                    // lemon note: no more implementation of windows explorer, because holy hell is it hard and buggy

                    InfoDesc.Show();

                    FileInfo fi = new FileInfo(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text));
                    txtInfoDescName.Text = mainView.FocusedItem.Text;
                    txtInfoDescType.Text = GetDescription(ReturnType(fi.Extension));
                    txtInfoDescModified.Text = fi.CreationTime.ToString();

                    txtInfoDescSize.Show();
                    txtInfoDescSize.Text = $"Size: {fi.Length} bytes.";

                } else if (Directory.Exists(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text))) {
                    txtInfoTip.Hide();
                    InfoDesc.Show();

                    DirectoryInfo fi = new DirectoryInfo(Path.Combine(CurrentDirectory, mainView.FocusedItem.Text));

                    txtInfoDescName.Text = mainView.FocusedItem.Text;
                    txtInfoDescType.Text = "File Folder";
                    txtInfoDescModified.Text = fi.CreationTime.ToString();

                    txtInfoDescSize.Hide();
                }
            }
        }

        public string GetDescription(int type)
        {
            switch (type)
            {
                case 1:
                    return "Text Document";
                case 2:
                    return "Rich Text Document";
                case 3:
                    return "Word Document";
                case 4:
                    return "Excel Document";
                case 5:
                    return "Powerpoint Document";
                case 7:
                    return "Publisher Document";
                case 8:
                    return "XPS File";
                case 9:
                    return "HTML Document";
                case 10:
                    return "Microsoft Works Document";
                case 11:
                    return "Image File";
                case 12:
                    return "Application";
                case 13:
                    return "Address Book File";
                case 21:
                    return "Video File";
                case 16:
                case 17:
                    return "System File";
                case 18:
                    return "Batch File";
                case 19:
                    return "Online Shortcut";
                case 20:
                    return "Bash Script";

            }
            return "File";
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
            } catch {
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
            } catch {
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(CurrentCopyFile))
            {
                // It is a directory

                DirectoryCopy(CurrentCopyFile, CurrentDirectory, true);
            } else if (File.Exists(CurrentCopyFile)) {
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
            foreach (ListViewItem item in mainView.Items)
            {
                item.Selected = true;
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
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
    }
}
