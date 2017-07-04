namespace TimeHACK.OS.Win95.Win95Apps
{
    partial class WinClassicWindowsExplorer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinClassicWindowsExplorer));
            this.program = new System.Windows.Forms.Panel();
            this.diskView = new System.Windows.Forms.TreeView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitmapImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellectAllCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByDriveLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BySizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByFreeSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineUpIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesOrFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnTheInternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapNetworkDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectNetworkDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutWindows95ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.mainView = new System.Windows.Forms.ListView();
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.program.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.diskView);
            this.program.Controls.Add(this.MenuStrip1);
            this.program.Controls.Add(this.toprightcorner);
            this.program.Controls.Add(this.bottomrightcorner);
            this.program.Controls.Add(this.bottomleftcorner);
            this.program.Controls.Add(this.topleftcorner);
            this.program.Controls.Add(this.pnlSave);
            this.program.Controls.Add(this.mainView);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(704, 517);
            this.program.TabIndex = 13;
            // 
            // diskView
            // 
            this.diskView.ImageList = this.icons;
            this.diskView.Location = new System.Drawing.Point(3, 27);
            this.diskView.Name = "diskView";
            this.diskView.Size = new System.Drawing.Size(213, 444);
            this.diskView.TabIndex = 13;
            this.diskView.Visible = true;
            this.diskView.DoubleClick += new System.EventHandler(this.diskView_DoubleClick);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "nwnp32_1_SERVER_ICON.png");
            this.icons.Images.SetKeyName(1, "shell32_21.ico_16x16.png");
            this.icons.Images.SetKeyName(2, "blank-file-Windows95Icon.gif");
            this.icons.Images.SetKeyName(3, "WinClassicCalc.png");
            this.icons.Images.SetKeyName(4, "WinClassicComputer.png");
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Silver;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(704, 24);
            this.MenuStrip1.TabIndex = 6;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateShortcutToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.RenameToolStripMenuItem,
            this.PropertiesToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // CreateShortcutToolStripMenuItem
            // 
            this.CreateShortcutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderToolStripMenuItem,
            this.ShortcutToolStripMenuItem,
            this.TextDocumentToolStripMenuItem,
            this.BitmapImageToolStripMenuItem});
            this.CreateShortcutToolStripMenuItem.Name = "CreateShortcutToolStripMenuItem";
            this.CreateShortcutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.CreateShortcutToolStripMenuItem.Text = "New";
            // 
            // FolderToolStripMenuItem
            // 
            this.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem";
            this.FolderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.FolderToolStripMenuItem.Text = "Folder";
            this.FolderToolStripMenuItem.Click += new System.EventHandler(this.FolderToolStripMenuItem_Click);
            // 
            // ShortcutToolStripMenuItem
            // 
            this.ShortcutToolStripMenuItem.Name = "ShortcutToolStripMenuItem";
            this.ShortcutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ShortcutToolStripMenuItem.Text = "Shortcut";
            // 
            // TextDocumentToolStripMenuItem
            // 
            this.TextDocumentToolStripMenuItem.Name = "TextDocumentToolStripMenuItem";
            this.TextDocumentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.TextDocumentToolStripMenuItem.Text = "Text Document";
            // 
            // BitmapImageToolStripMenuItem
            // 
            this.BitmapImageToolStripMenuItem.Name = "BitmapImageToolStripMenuItem";
            this.BitmapImageToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.BitmapImageToolStripMenuItem.Text = "Bitmap Image";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.RenameToolStripMenuItem.Text = "Rename";
            // 
            // PropertiesToolStripMenuItem
            // 
            this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.PropertiesToolStripMenuItem.Text = "Properties";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoCtrlZToolStripMenuItem,
            this.CutCtrlXToolStripMenuItem,
            this.CopyCtrlCToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.PasteShortcutToolStripMenuItem,
            this.SellectAllCtrlAToolStripMenuItem,
            this.InvertSelectionToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // UndoCtrlZToolStripMenuItem
            // 
            this.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem";
            this.UndoCtrlZToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.UndoCtrlZToolStripMenuItem.Text = "Undo                    Ctrl+Z";
            // 
            // CutCtrlXToolStripMenuItem
            // 
            this.CutCtrlXToolStripMenuItem.Name = "CutCtrlXToolStripMenuItem";
            this.CutCtrlXToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.CutCtrlXToolStripMenuItem.Text = "Cut                       Ctrl+X";
            // 
            // CopyCtrlCToolStripMenuItem
            // 
            this.CopyCtrlCToolStripMenuItem.Name = "CopyCtrlCToolStripMenuItem";
            this.CopyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.CopyCtrlCToolStripMenuItem.Text = "Copy                    Ctrl+C";
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.PasteToolStripMenuItem.Text = "Paste                    Ctrl+V";
            // 
            // PasteShortcutToolStripMenuItem
            // 
            this.PasteShortcutToolStripMenuItem.Name = "PasteShortcutToolStripMenuItem";
            this.PasteShortcutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.PasteShortcutToolStripMenuItem.Text = "Paste Shortcut";
            // 
            // SellectAllCtrlAToolStripMenuItem
            // 
            this.SellectAllCtrlAToolStripMenuItem.Name = "SellectAllCtrlAToolStripMenuItem";
            this.SellectAllCtrlAToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.SellectAllCtrlAToolStripMenuItem.Text = "Sellect All            Ctrl+A";
            // 
            // InvertSelectionToolStripMenuItem
            // 
            this.InvertSelectionToolStripMenuItem.Name = "InvertSelectionToolStripMenuItem";
            this.InvertSelectionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.InvertSelectionToolStripMenuItem.Text = "Invert Selection";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolbarToolStripMenuItem,
            this.StatusBarToolStripMenuItem,
            this.LargeIconsToolStripMenuItem,
            this.SmallIconsToolStripMenuItem,
            this.ListToolStripMenuItem,
            this.DetailsToolStripMenuItem,
            this.ArrangeIconsToolStripMenuItem,
            this.LineUpIconsToolStripMenuItem,
            this.RefreshToolStripMenuItem,
            this.OptionsToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "View";
            // 
            // ToolbarToolStripMenuItem
            // 
            this.ToolbarToolStripMenuItem.Name = "ToolbarToolStripMenuItem";
            this.ToolbarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ToolbarToolStripMenuItem.Text = "Toolbar";
            // 
            // StatusBarToolStripMenuItem
            // 
            this.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem";
            this.StatusBarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.StatusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // LargeIconsToolStripMenuItem
            // 
            this.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem";
            this.LargeIconsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.LargeIconsToolStripMenuItem.Text = "Large Icons";
            // 
            // SmallIconsToolStripMenuItem
            // 
            this.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem";
            this.SmallIconsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.SmallIconsToolStripMenuItem.Text = "Small Icons";
            // 
            // ListToolStripMenuItem
            // 
            this.ListToolStripMenuItem.Name = "ListToolStripMenuItem";
            this.ListToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ListToolStripMenuItem.Text = "List";
            // 
            // DetailsToolStripMenuItem
            // 
            this.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem";
            this.DetailsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.DetailsToolStripMenuItem.Text = "Details";
            // 
            // ArrangeIconsToolStripMenuItem
            // 
            this.ArrangeIconsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ByDriveLetterToolStripMenuItem,
            this.ByTypeToolStripMenuItem,
            this.BySizeToolStripMenuItem,
            this.ByFreeSpaceToolStripMenuItem});
            this.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem";
            this.ArrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ArrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            // 
            // ByDriveLetterToolStripMenuItem
            // 
            this.ByDriveLetterToolStripMenuItem.Name = "ByDriveLetterToolStripMenuItem";
            this.ByDriveLetterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ByDriveLetterToolStripMenuItem.Text = "by Drive Letter";
            // 
            // ByTypeToolStripMenuItem
            // 
            this.ByTypeToolStripMenuItem.Name = "ByTypeToolStripMenuItem";
            this.ByTypeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ByTypeToolStripMenuItem.Text = "by Type";
            // 
            // BySizeToolStripMenuItem
            // 
            this.BySizeToolStripMenuItem.Name = "BySizeToolStripMenuItem";
            this.BySizeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.BySizeToolStripMenuItem.Text = "by Size";
            // 
            // ByFreeSpaceToolStripMenuItem
            // 
            this.ByFreeSpaceToolStripMenuItem.Name = "ByFreeSpaceToolStripMenuItem";
            this.ByFreeSpaceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ByFreeSpaceToolStripMenuItem.Text = "by Free Space";
            // 
            // LineUpIconsToolStripMenuItem
            // 
            this.LineUpIconsToolStripMenuItem.Name = "LineUpIconsToolStripMenuItem";
            this.LineUpIconsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.LineUpIconsToolStripMenuItem.Text = "Line up Icons";
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.OptionsToolStripMenuItem.Text = "Options...";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindToolStripMenuItem,
            this.MapNetworkDriveToolStripMenuItem,
            this.DisconnectNetworkDriveToolStripMenuItem,
            this.GoToToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // FindToolStripMenuItem
            // 
            this.FindToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesOrFoldersToolStripMenuItem,
            this.ComputerToolStripMenuItem,
            this.OnTheInternetToolStripMenuItem,
            this.PeopleToolStripMenuItem});
            this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            this.FindToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.FindToolStripMenuItem.Text = "Find";
            // 
            // FilesOrFoldersToolStripMenuItem
            // 
            this.FilesOrFoldersToolStripMenuItem.Name = "FilesOrFoldersToolStripMenuItem";
            this.FilesOrFoldersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.FilesOrFoldersToolStripMenuItem.Text = "Files or Folders...";
            // 
            // ComputerToolStripMenuItem
            // 
            this.ComputerToolStripMenuItem.Name = "ComputerToolStripMenuItem";
            this.ComputerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ComputerToolStripMenuItem.Text = "Computer...";
            // 
            // OnTheInternetToolStripMenuItem
            // 
            this.OnTheInternetToolStripMenuItem.Name = "OnTheInternetToolStripMenuItem";
            this.OnTheInternetToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.OnTheInternetToolStripMenuItem.Text = "On the Internet";
            // 
            // PeopleToolStripMenuItem
            // 
            this.PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            this.PeopleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.PeopleToolStripMenuItem.Text = "People...";
            // 
            // MapNetworkDriveToolStripMenuItem
            // 
            this.MapNetworkDriveToolStripMenuItem.Name = "MapNetworkDriveToolStripMenuItem";
            this.MapNetworkDriveToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.MapNetworkDriveToolStripMenuItem.Text = "Map Network Drive...";
            // 
            // DisconnectNetworkDriveToolStripMenuItem
            // 
            this.DisconnectNetworkDriveToolStripMenuItem.Name = "DisconnectNetworkDriveToolStripMenuItem";
            this.DisconnectNetworkDriveToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.DisconnectNetworkDriveToolStripMenuItem.Text = "Disconnect Network Drive...";
            // 
            // GoToToolStripMenuItem
            // 
            this.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem";
            this.GoToToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.GoToToolStripMenuItem.Text = "Go to...";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem1,
            this.AboutWindows95ToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // HelpToolStripMenuItem1
            // 
            this.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
            this.HelpToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.HelpToolStripMenuItem1.Text = "Help Topics";
            // 
            // AboutWindows95ToolStripMenuItem
            // 
            this.AboutWindows95ToolStripMenuItem.Name = "AboutWindows95ToolStripMenuItem";
            this.AboutWindows95ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.AboutWindows95ToolStripMenuItem.Text = "About Windows 95";
            this.AboutWindows95ToolStripMenuItem.Click += new System.EventHandler(this.AboutWindows95ToolStripMenuItem_Click);
            // 
            // toprightcorner
            // 
            this.toprightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightcorner.Location = new System.Drawing.Point(700, 0);
            this.toprightcorner.Name = "toprightcorner";
            this.toprightcorner.Size = new System.Drawing.Size(4, 4);
            this.toprightcorner.TabIndex = 6;
            // 
            // bottomrightcorner
            // 
            this.bottomrightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomrightcorner.Location = new System.Drawing.Point(700, 513);
            this.bottomrightcorner.Name = "bottomrightcorner";
            this.bottomrightcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomrightcorner.TabIndex = 4;
            // 
            // bottomleftcorner
            // 
            this.bottomleftcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomleftcorner.Location = new System.Drawing.Point(0, 513);
            this.bottomleftcorner.Name = "bottomleftcorner";
            this.bottomleftcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomleftcorner.TabIndex = 2;
            // 
            // topleftcorner
            // 
            this.topleftcorner.Location = new System.Drawing.Point(0, 0);
            this.topleftcorner.Name = "topleftcorner";
            this.topleftcorner.Size = new System.Drawing.Size(4, 4);
            this.topleftcorner.TabIndex = 1;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.Button1);
            this.pnlSave.Controls.Add(this.Label1);
            this.pnlSave.Controls.Add(this.txtSave);
            this.pnlSave.Location = new System.Drawing.Point(3, 474);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(850, 35);
            this.pnlSave.TabIndex = 18;
            this.pnlSave.Visible = false;
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(608, 1);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Save";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "File Name:";
            // 
            // txtSave
            // 
            this.txtSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSave.Location = new System.Drawing.Point(60, 3);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(542, 20);
            this.txtSave.TabIndex = 15;
            // 
            // mainView
            // 
            this.mainView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainView.LargeImageList = this.iconsList;
            this.mainView.Location = new System.Drawing.Point(215, 27);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(486, 444);
            this.mainView.SmallImageList = this.iconsList;
            this.mainView.StateImageList = this.iconsList;
            this.mainView.TabIndex = 10;
            this.mainView.UseCompatibleStateImageBehavior = false;
            this.mainView.View = System.Windows.Forms.View.List;
            this.mainView.DoubleClick += new System.EventHandler(this.mainView_DoubleClick);
            // 
            // iconsList
            // 
            this.iconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsList.ImageStream")));
            this.iconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsList.Images.SetKeyName(0, "nwnp32_1_SERVER_ICON.png");
            this.iconsList.Images.SetKeyName(1, "shell32_21.ico_16x16.png");
            this.iconsList.Images.SetKeyName(2, "blank-file-Windows95Icon.gif");
            this.iconsList.Images.SetKeyName(3, "WinClassicCalc.png");
            this.iconsList.Images.SetKeyName(4, "WinClassicComputer.png");
            // 
            // WinClassicWindowsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.program);
            this.Name = "WinClassicWindowsExplorer";
            this.Size = new System.Drawing.Size(704, 517);
            this.Load += new System.EventHandler(this.WinClassicWindowsExplorer_Load);
            this.program.ResumeLayout(false);
            this.program.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel program;
        internal System.Windows.Forms.TreeView diskView;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CreateShortcutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FolderToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ShortcutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TextDocumentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BitmapImageToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PropertiesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UndoCtrlZToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CutCtrlXToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CopyCtrlCToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteShortcutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SellectAllCtrlAToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem InvertSelectionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolbarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem StatusBarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LargeIconsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SmallIconsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DetailsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ArrangeIconsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ByDriveLetterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ByTypeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BySizeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ByFreeSpaceToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineUpIconsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FindToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FilesOrFoldersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ComputerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OnTheInternetToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PeopleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MapNetworkDriveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DisconnectNetworkDriveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GoToToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem AboutWindows95ToolStripMenuItem;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel bottomrightcorner;
        internal System.Windows.Forms.Panel bottomleftcorner;
        internal System.Windows.Forms.Panel topleftcorner;
        internal System.Windows.Forms.ListView mainView;
        internal System.Windows.Forms.Panel pnlSave;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSave;
        internal System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.ImageList iconsList;
    }
}
