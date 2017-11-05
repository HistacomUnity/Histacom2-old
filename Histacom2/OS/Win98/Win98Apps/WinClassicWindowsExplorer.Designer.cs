namespace Histacom2.OS.Win95.Win95Apps
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
            this.mainView = new System.Windows.Forms.ListView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.txtInfoTitle = new Histacom2.Engine.UI.ClassicLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInfoContent = new System.Windows.Forms.Panel();
            this.InfoDesc = new System.Windows.Forms.Panel();
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.txtInfoDescSize = new Histacom2.Engine.UI.ClassicLabel();
            this.txtInfoDescModified = new Histacom2.Engine.UI.ClassicLabel();
            this.txtInfoDescType = new Histacom2.Engine.UI.ClassicLabel();
            this.txtInfoDescName = new Histacom2.Engine.UI.ClassicLabel();
            this.txtInfoTip = new Histacom2.Engine.UI.ClassicLabel();
            this.pnlFolders = new System.Windows.Forms.Panel();
            this.diskView = new System.Windows.Forms.TreeView();
            this.pnlFoldersTop = new System.Windows.Forms.Panel();
            this.btnFolderClose = new System.Windows.Forms.PictureBox();
            this.classicLabel4 = new Histacom2.Engine.UI.ClassicLabel();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnCanc = new Histacom2.Engine.UI.ClassicButton();
            this.cmbType = new Histacom2.Engine.UI.ClassicDropDown();
            this.txtSave = new Histacom2.Engine.UI.ClassicTextBox();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.btnSave = new Histacom2.Engine.UI.ClassicButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitmapImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellectAllCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutWindows95ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.program.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInfoContent.SuspendLayout();
            this.InfoDesc.SuspendLayout();
            this.pnlFolders.SuspendLayout();
            this.pnlFoldersTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolderClose)).BeginInit();
            this.pnlSave.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.mainView);
            this.program.Controls.Add(this.pnlInfo);
            this.program.Controls.Add(this.pnlFolders);
            this.program.Controls.Add(this.toprightcorner);
            this.program.Controls.Add(this.bottomrightcorner);
            this.program.Controls.Add(this.bottomleftcorner);
            this.program.Controls.Add(this.topleftcorner);
            this.program.Controls.Add(this.pnlSave);
            this.program.Controls.Add(this.MenuStrip1);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(704, 517);
            this.program.TabIndex = 13;
            // 
            // mainView
            // 
            this.mainView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView.Location = new System.Drawing.Point(396, 24);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(308, 439);
            this.mainView.TabIndex = 10;
            this.mainView.UseCompatibleStateImageBehavior = false;
            this.mainView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.mainView_AfterLabelEdit);
            this.mainView.SelectedIndexChanged += new System.EventHandler(this.mainView_SelectedIndexChanged);
            this.mainView.DoubleClick += new System.EventHandler(this.mainView_DoubleClick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BackgroundImage = global::Histacom2.Properties.Resources.Win98WebBackground;
            this.pnlInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlInfo.Controls.Add(this.txtInfoTitle);
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.pnlInfoContent);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(196, 24);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(200, 439);
            this.pnlInfo.TabIndex = 19;
            // 
            // txtInfoTitle
            // 
            this.txtInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtInfoTitle.DropShadow = false;
            this.txtInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtInfoTitle.Location = new System.Drawing.Point(13, 56);
            this.txtInfoTitle.Name = "txtInfoTitle";
            this.txtInfoTitle.Size = new System.Drawing.Size(194, 30);
            this.txtInfoTitle.TabIndex = 23;
            this.txtInfoTitle.Text = "FOLDER_NAME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Histacom2.Properties.Resources.WinClassicFolder;
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pnlInfoContent
            // 
            this.pnlInfoContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfoContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfoContent.Controls.Add(this.InfoDesc);
            this.pnlInfoContent.Controls.Add(this.txtInfoTip);
            this.pnlInfoContent.Location = new System.Drawing.Point(0, 95);
            this.pnlInfoContent.Name = "pnlInfoContent";
            this.pnlInfoContent.Size = new System.Drawing.Size(199, 343);
            this.pnlInfoContent.TabIndex = 22;
            // 
            // InfoDesc
            // 
            this.InfoDesc.Controls.Add(this.classicLabel3);
            this.InfoDesc.Controls.Add(this.txtInfoDescSize);
            this.InfoDesc.Controls.Add(this.txtInfoDescModified);
            this.InfoDesc.Controls.Add(this.txtInfoDescType);
            this.InfoDesc.Controls.Add(this.txtInfoDescName);
            this.InfoDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoDesc.Location = new System.Drawing.Point(0, 26);
            this.InfoDesc.Name = "InfoDesc";
            this.InfoDesc.Size = new System.Drawing.Size(199, 94);
            this.InfoDesc.TabIndex = 22;
            this.InfoDesc.Visible = false;
            // 
            // classicLabel3
            // 
            this.classicLabel3.DropShadow = false;
            this.classicLabel3.Location = new System.Drawing.Point(13, 38);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(179, 13);
            this.classicLabel3.TabIndex = 1;
            this.classicLabel3.Text = "Last modified:";
            // 
            // txtInfoDescSize
            // 
            this.txtInfoDescSize.DropShadow = false;
            this.txtInfoDescSize.Location = new System.Drawing.Point(15, 76);
            this.txtInfoDescSize.Name = "txtInfoDescSize";
            this.txtInfoDescSize.Size = new System.Drawing.Size(179, 13);
            this.txtInfoDescSize.TabIndex = 1;
            this.txtInfoDescSize.Text = "FILE_SIZE";
            // 
            // txtInfoDescModified
            // 
            this.txtInfoDescModified.DropShadow = false;
            this.txtInfoDescModified.Location = new System.Drawing.Point(13, 57);
            this.txtInfoDescModified.Name = "txtInfoDescModified";
            this.txtInfoDescModified.Size = new System.Drawing.Size(179, 13);
            this.txtInfoDescModified.TabIndex = 1;
            this.txtInfoDescModified.Text = "DATE_MODIFIED";
            // 
            // txtInfoDescType
            // 
            this.txtInfoDescType.DropShadow = false;
            this.txtInfoDescType.Location = new System.Drawing.Point(13, 19);
            this.txtInfoDescType.Name = "txtInfoDescType";
            this.txtInfoDescType.Size = new System.Drawing.Size(183, 13);
            this.txtInfoDescType.TabIndex = 1;
            this.txtInfoDescType.Text = "FILE_TYPE";
            // 
            // txtInfoDescName
            // 
            this.txtInfoDescName.DropShadow = false;
            this.txtInfoDescName.Location = new System.Drawing.Point(13, 2);
            this.txtInfoDescName.Name = "txtInfoDescName";
            this.txtInfoDescName.Size = new System.Drawing.Size(179, 13);
            this.txtInfoDescName.TabIndex = 1;
            this.txtInfoDescName.Text = "FILE_NAME";
            // 
            // txtInfoTip
            // 
            this.txtInfoTip.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInfoTip.DropShadow = false;
            this.txtInfoTip.Location = new System.Drawing.Point(0, 0);
            this.txtInfoTip.Name = "txtInfoTip";
            this.txtInfoTip.Size = new System.Drawing.Size(199, 26);
            this.txtInfoTip.TabIndex = 23;
            this.txtInfoTip.Text = "Please choose an item to view it\'s description.";
            // 
            // pnlFolders
            // 
            this.pnlFolders.Controls.Add(this.diskView);
            this.pnlFolders.Controls.Add(this.pnlFoldersTop);
            this.pnlFolders.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFolders.Location = new System.Drawing.Point(0, 24);
            this.pnlFolders.Name = "pnlFolders";
            this.pnlFolders.Size = new System.Drawing.Size(196, 439);
            this.pnlFolders.TabIndex = 0;
            // 
            // diskView
            // 
            this.diskView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskView.Location = new System.Drawing.Point(0, 22);
            this.diskView.Name = "diskView";
            this.diskView.Size = new System.Drawing.Size(196, 417);
            this.diskView.TabIndex = 13;
            this.diskView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.diskView_AfterSelect);
            // 
            // pnlFoldersTop
            // 
            this.pnlFoldersTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.pnlFoldersTop.Controls.Add(this.btnFolderClose);
            this.pnlFoldersTop.Controls.Add(this.classicLabel4);
            this.pnlFoldersTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFoldersTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFoldersTop.Name = "pnlFoldersTop";
            this.pnlFoldersTop.Size = new System.Drawing.Size(196, 22);
            this.pnlFoldersTop.TabIndex = 20;
            // 
            // btnFolderClose
            // 
            this.btnFolderClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnFolderClose.Image = global::Histacom2.Properties.Resources.XCross;
            this.btnFolderClose.Location = new System.Drawing.Point(172, 3);
            this.btnFolderClose.Name = "btnFolderClose";
            this.btnFolderClose.Size = new System.Drawing.Size(21, 16);
            this.btnFolderClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFolderClose.TabIndex = 20;
            this.btnFolderClose.TabStop = false;
            this.btnFolderClose.Click += new System.EventHandler(this.btnFolderClose_Click);
            this.btnFolderClose.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btnFolderClose.MouseLeave += new System.EventHandler(this.btnFolderClose_MouseLeave);
            // 
            // classicLabel4
            // 
            this.classicLabel4.DropShadow = false;
            this.classicLabel4.Location = new System.Drawing.Point(3, 5);
            this.classicLabel4.Name = "classicLabel4";
            this.classicLabel4.Size = new System.Drawing.Size(179, 13);
            this.classicLabel4.TabIndex = 1;
            this.classicLabel4.Text = "Folders";
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
            this.pnlSave.Controls.Add(this.btnCanc);
            this.pnlSave.Controls.Add(this.cmbType);
            this.pnlSave.Controls.Add(this.txtSave);
            this.pnlSave.Controls.Add(this.classicLabel2);
            this.pnlSave.Controls.Add(this.classicLabel1);
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSave.Location = new System.Drawing.Point(0, 463);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(704, 54);
            this.pnlSave.TabIndex = 18;
            this.pnlSave.Visible = false;
            // 
            // btnCanc
            // 
            this.btnCanc.AdaptBackColorWithTheme = true;
            this.btnCanc.AdaptFontWithTheme = true;
            this.btnCanc.AdaptForeColorWithTheme = true;
            this.btnCanc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCanc.BackColor = System.Drawing.Color.Silver;
            this.btnCanc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCanc.ForeColor = System.Drawing.Color.Black;
            this.btnCanc.Location = new System.Drawing.Point(619, 28);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 25);
            this.btnCanc.TabIndex = 30;
            this.btnCanc.Text = "Cancel";
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.BackColor = System.Drawing.Color.White;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbType.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("cmbType.Items")));
            this.cmbType.Location = new System.Drawing.Point(64, 32);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(549, 20);
            this.cmbType.TabIndex = 29;
            this.cmbType.UseSystemPasswordChar = false;
            // 
            // txtSave
            // 
            this.txtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSave.BackColor = System.Drawing.Color.White;
            this.txtSave.Location = new System.Drawing.Point(64, 7);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(549, 20);
            this.txtSave.TabIndex = 28;
            this.txtSave.UseSystemPasswordChar = false;
            // 
            // classicLabel2
            // 
            this.classicLabel2.DropShadow = false;
            this.classicLabel2.Location = new System.Drawing.Point(11, 33);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(64, 13);
            this.classicLabel2.TabIndex = 26;
            this.classicLabel2.Text = "File type:";
            // 
            // classicLabel1
            // 
            this.classicLabel1.DropShadow = false;
            this.classicLabel1.Location = new System.Drawing.Point(11, 7);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(64, 13);
            this.classicLabel1.TabIndex = 27;
            this.classicLabel1.Text = "File name:";
            // 
            // btnSave
            // 
            this.btnSave.AdaptBackColorWithTheme = true;
            this.btnSave.AdaptFontWithTheme = true;
            this.btnSave.AdaptForeColorWithTheme = true;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(619, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ViewToolStripMenuItem,
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
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // CreateShortcutToolStripMenuItem
            // 
            this.CreateShortcutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderToolStripMenuItem,
            this.TextDocumentToolStripMenuItem,
            this.BitmapImageToolStripMenuItem});
            this.CreateShortcutToolStripMenuItem.Name = "CreateShortcutToolStripMenuItem";
            this.CreateShortcutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.CreateShortcutToolStripMenuItem.Text = "New";
            // 
            // FolderToolStripMenuItem
            // 
            this.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem";
            this.FolderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.FolderToolStripMenuItem.Text = "Folder";
            this.FolderToolStripMenuItem.Click += new System.EventHandler(this.FolderToolStripMenuItem_Click);
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
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.RenameToolStripMenuItem.Text = "Rename";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutCtrlXToolStripMenuItem,
            this.CopyCtrlCToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.SellectAllCtrlAToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // CutCtrlXToolStripMenuItem
            // 
            this.CutCtrlXToolStripMenuItem.Name = "CutCtrlXToolStripMenuItem";
            this.CutCtrlXToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.CutCtrlXToolStripMenuItem.Text = "Cut                       Ctrl+X";
            this.CutCtrlXToolStripMenuItem.Click += new System.EventHandler(this.CutCtrlXToolStripMenuItem_Click);
            // 
            // CopyCtrlCToolStripMenuItem
            // 
            this.CopyCtrlCToolStripMenuItem.Name = "CopyCtrlCToolStripMenuItem";
            this.CopyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.CopyCtrlCToolStripMenuItem.Text = "Copy                    Ctrl+C";
            this.CopyCtrlCToolStripMenuItem.Click += new System.EventHandler(this.CopyCtrlCToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.PasteToolStripMenuItem.Text = "Paste                    Ctrl+V";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // SellectAllCtrlAToolStripMenuItem
            // 
            this.SellectAllCtrlAToolStripMenuItem.Name = "SellectAllCtrlAToolStripMenuItem";
            this.SellectAllCtrlAToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.SellectAllCtrlAToolStripMenuItem.Text = "Select All             Ctrl+A";
            this.SellectAllCtrlAToolStripMenuItem.Click += new System.EventHandler(this.SellectAllCtrlAToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoldersToolStripMenuItem,
            this.RefreshToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "View";
            // 
            // FoldersToolStripMenuItem
            // 
            this.FoldersToolStripMenuItem.Checked = true;
            this.FoldersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FoldersToolStripMenuItem.Name = "FoldersToolStripMenuItem";
            this.FoldersToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.FoldersToolStripMenuItem.Text = "Folders";
            this.FoldersToolStripMenuItem.Click += new System.EventHandler(this.FoldersToolStripMenuItem_Click);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
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
            // refresh
            // 
            this.refresh.Enabled = true;
            this.refresh.Interval = 4000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
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
            this.pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInfoContent.ResumeLayout(false);
            this.InfoDesc.ResumeLayout(false);
            this.pnlFolders.ResumeLayout(false);
            this.pnlFoldersTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFolderClose)).EndInit();
            this.pnlSave.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel program;
        internal System.Windows.Forms.TreeView diskView;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CreateShortcutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FolderToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TextDocumentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BitmapImageToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CutCtrlXToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CopyCtrlCToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SellectAllCtrlAToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FoldersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem AboutWindows95ToolStripMenuItem;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel bottomrightcorner;
        internal System.Windows.Forms.Panel bottomleftcorner;
        internal System.Windows.Forms.Panel topleftcorner;
        internal System.Windows.Forms.ListView mainView;
        internal System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlFolders;
        private System.Windows.Forms.Panel pnlFoldersTop;
        private System.Windows.Forms.PictureBox btnFolderClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInfoContent;
        private System.Windows.Forms.Panel InfoDesc;
        private System.Windows.Forms.Timer refresh;
        private Engine.UI.ClassicButton btnCanc;
        private Engine.UI.ClassicDropDown cmbType;
        private Engine.UI.ClassicTextBox txtSave;
        private Engine.UI.ClassicLabel classicLabel2;
        private Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicButton btnSave;
        private Engine.UI.ClassicLabel txtInfoTitle;
        private Engine.UI.ClassicLabel txtInfoTip;
        private Engine.UI.ClassicLabel txtInfoDescName;
        private Engine.UI.ClassicLabel txtInfoDescType;
        private Engine.UI.ClassicLabel classicLabel3;
        private Engine.UI.ClassicLabel txtInfoDescModified;
        private Engine.UI.ClassicLabel txtInfoDescSize;
        private Engine.UI.ClassicLabel classicLabel4;
    }
}
