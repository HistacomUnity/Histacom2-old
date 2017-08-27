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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInfoTitle = new System.Windows.Forms.Label();
            this.pnlInfoContent = new System.Windows.Forms.Panel();
            this.InfoDesc = new System.Windows.Forms.Panel();
            this.txtInfoDescSize = new System.Windows.Forms.Label();
            this.txtInfoDescModified = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInfoDescType = new System.Windows.Forms.Label();
            this.txtInfoDescName = new System.Windows.Forms.Label();
            this.txtInfoTip = new System.Windows.Forms.Label();
            this.pnlFolders = new System.Windows.Forms.Panel();
            this.diskView = new System.Windows.Forms.TreeView();
            this.pnlFoldersTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFolderClose = new System.Windows.Forms.PictureBox();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSave = new System.Windows.Forms.TextBox();
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
            this.mainView.Size = new System.Drawing.Size(308, 458);
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
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.txtInfoTitle);
            this.pnlInfo.Controls.Add(this.pnlInfoContent);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(196, 24);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(200, 458);
            this.pnlInfo.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtInfoTitle
            // 
            this.txtInfoTitle.AutoSize = true;
            this.txtInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoTitle.Location = new System.Drawing.Point(3, 51);
            this.txtInfoTitle.Name = "txtInfoTitle";
            this.txtInfoTitle.Size = new System.Drawing.Size(192, 29);
            this.txtInfoTitle.TabIndex = 0;
            this.txtInfoTitle.Text = "FOLDER_NAME";
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
            this.pnlInfoContent.Size = new System.Drawing.Size(199, 362);
            this.pnlInfoContent.TabIndex = 22;
            // 
            // InfoDesc
            // 
            this.InfoDesc.Controls.Add(this.txtInfoDescSize);
            this.InfoDesc.Controls.Add(this.txtInfoDescModified);
            this.InfoDesc.Controls.Add(this.label5);
            this.InfoDesc.Controls.Add(this.txtInfoDescType);
            this.InfoDesc.Controls.Add(this.txtInfoDescName);
            this.InfoDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoDesc.Location = new System.Drawing.Point(0, 25);
            this.InfoDesc.Name = "InfoDesc";
            this.InfoDesc.Size = new System.Drawing.Size(199, 94);
            this.InfoDesc.TabIndex = 22;
            this.InfoDesc.Visible = false;
            // 
            // txtInfoDescSize
            // 
            this.txtInfoDescSize.AutoSize = true;
            this.txtInfoDescSize.Location = new System.Drawing.Point(12, 81);
            this.txtInfoDescSize.Name = "txtInfoDescSize";
            this.txtInfoDescSize.Size = new System.Drawing.Size(59, 13);
            this.txtInfoDescSize.TabIndex = 0;
            this.txtInfoDescSize.Text = "FILE_SIZE";
            // 
            // txtInfoDescModified
            // 
            this.txtInfoDescModified.AutoSize = true;
            this.txtInfoDescModified.Location = new System.Drawing.Point(12, 54);
            this.txtInfoDescModified.Name = "txtInfoDescModified";
            this.txtInfoDescModified.Size = new System.Drawing.Size(92, 13);
            this.txtInfoDescModified.TabIndex = 0;
            this.txtInfoDescModified.Text = "LAST_MODIFIED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Modified:";
            // 
            // txtInfoDescType
            // 
            this.txtInfoDescType.AutoSize = true;
            this.txtInfoDescType.Location = new System.Drawing.Point(12, 18);
            this.txtInfoDescType.Name = "txtInfoDescType";
            this.txtInfoDescType.Size = new System.Drawing.Size(63, 13);
            this.txtInfoDescType.TabIndex = 0;
            this.txtInfoDescType.Text = "FILE_TYPE";
            // 
            // txtInfoDescName
            // 
            this.txtInfoDescName.AutoSize = true;
            this.txtInfoDescName.Location = new System.Drawing.Point(12, 5);
            this.txtInfoDescName.Name = "txtInfoDescName";
            this.txtInfoDescName.Size = new System.Drawing.Size(66, 13);
            this.txtInfoDescName.TabIndex = 0;
            this.txtInfoDescName.Text = "FILE_NAME";
            // 
            // txtInfoTip
            // 
            this.txtInfoTip.BackColor = System.Drawing.Color.Transparent;
            this.txtInfoTip.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInfoTip.Location = new System.Drawing.Point(0, 0);
            this.txtInfoTip.Name = "txtInfoTip";
            this.txtInfoTip.Size = new System.Drawing.Size(199, 25);
            this.txtInfoTip.TabIndex = 21;
            this.txtInfoTip.Text = "Select an item to view its description.";
            this.txtInfoTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFolders
            // 
            this.pnlFolders.Controls.Add(this.diskView);
            this.pnlFolders.Controls.Add(this.pnlFoldersTop);
            this.pnlFolders.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFolders.Location = new System.Drawing.Point(0, 24);
            this.pnlFolders.Name = "pnlFolders";
            this.pnlFolders.Size = new System.Drawing.Size(196, 458);
            this.pnlFolders.TabIndex = 0;
            // 
            // diskView
            // 
            this.diskView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskView.Location = new System.Drawing.Point(0, 22);
            this.diskView.Name = "diskView";
            this.diskView.Size = new System.Drawing.Size(196, 436);
            this.diskView.TabIndex = 13;
            this.diskView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.diskView_AfterSelect);
            // 
            // pnlFoldersTop
            // 
            this.pnlFoldersTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.pnlFoldersTop.Controls.Add(this.label2);
            this.pnlFoldersTop.Controls.Add(this.btnFolderClose);
            this.pnlFoldersTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFoldersTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFoldersTop.Name = "pnlFoldersTop";
            this.pnlFoldersTop.Size = new System.Drawing.Size(196, 22);
            this.pnlFoldersTop.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folders";
            // 
            // btnFolderClose
            // 
            this.btnFolderClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnFolderClose.Image = ((System.Drawing.Image)(resources.GetObject("btnFolderClose.Image")));
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
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSave.Location = new System.Drawing.Point(0, 482);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(704, 35);
            this.pnlSave.TabIndex = 18;
            this.pnlSave.Visible = false;
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(626, 3);
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
            this.txtSave.Size = new System.Drawing.Size(560, 20);
            this.txtSave.TabIndex = 15;
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
            this.CreateShortcutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RenameToolStripMenuItem.Text = "Rename";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInfoContent.ResumeLayout(false);
            this.InfoDesc.ResumeLayout(false);
            this.InfoDesc.PerformLayout();
            this.pnlFolders.ResumeLayout(false);
            this.pnlFoldersTop.ResumeLayout(false);
            this.pnlFoldersTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolderClose)).EndInit();
            this.pnlSave.ResumeLayout(false);
            this.pnlSave.PerformLayout();
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
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlFolders;
        private System.Windows.Forms.Panel pnlFoldersTop;
        private System.Windows.Forms.PictureBox btnFolderClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtInfoTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtInfoTip;
        private System.Windows.Forms.Panel pnlInfoContent;
        private System.Windows.Forms.Panel InfoDesc;
        private System.Windows.Forms.Label txtInfoDescModified;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtInfoDescType;
        private System.Windows.Forms.Label txtInfoDescName;
        private System.Windows.Forms.Label txtInfoDescSize;
        private System.Windows.Forms.Timer refresh;
    }
}
