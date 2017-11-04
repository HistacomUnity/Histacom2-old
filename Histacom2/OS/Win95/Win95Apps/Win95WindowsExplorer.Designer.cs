namespace Histacom2.OS.Win95.Win95Apps
{
    partial class Win95WindowsExplorer
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
            this.program = new System.Windows.Forms.Panel();
            this.mainView = new System.Windows.Forms.ListView();
            this.diskView = new System.Windows.Forms.TreeView();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellectAllCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutWindows95ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.cmbType = new Histacom2.Engine.UI.ClassicDropDown();
            this.txtSave = new Histacom2.Engine.UI.ClassicTextBox();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.btnSave = new Histacom2.Engine.UI.ClassicButton();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.btnCanc = new Histacom2.Engine.UI.ClassicButton();
            this.program.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.mainView);
            this.program.Controls.Add(this.diskView);
            this.program.Controls.Add(this.MenuStrip1);
            this.program.Controls.Add(this.toprightcorner);
            this.program.Controls.Add(this.topleftcorner);
            this.program.Controls.Add(this.pnlSave);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(704, 517);
            this.program.TabIndex = 13;
            // 
            // mainView
            // 
            this.mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView.Location = new System.Drawing.Point(213, 24);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(491, 439);
            this.mainView.TabIndex = 10;
            this.mainView.UseCompatibleStateImageBehavior = false;
            this.mainView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.mainView_AfterLabelEdit);
            this.mainView.DoubleClick += new System.EventHandler(this.mainView_DoubleClick);
            // 
            // diskView
            // 
            this.diskView.Dock = System.Windows.Forms.DockStyle.Left;
            this.diskView.Location = new System.Drawing.Point(0, 24);
            this.diskView.Name = "diskView";
            this.diskView.Size = new System.Drawing.Size(213, 439);
            this.diskView.TabIndex = 13;
            this.diskView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.diskView_AfterSelect);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Silver;
            this.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.TextDocumentToolStripMenuItem});
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
            this.TextDocumentToolStripMenuItem.Click += new System.EventHandler(this.TextDocumentToolStripMenuItem_Click);
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
            this.SellectAllCtrlAToolStripMenuItem.Text = "Select All            Ctrl+A";
            this.SellectAllCtrlAToolStripMenuItem.Click += new System.EventHandler(this.SellectAllCtrlAToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "View";
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
            // toprightcorner
            // 
            this.toprightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightcorner.Location = new System.Drawing.Point(700, 0);
            this.toprightcorner.Name = "toprightcorner";
            this.toprightcorner.Size = new System.Drawing.Size(4, 4);
            this.toprightcorner.TabIndex = 6;
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
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.White;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbType.Location = new System.Drawing.Point(56, 31);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(549, 20);
            this.cmbType.TabIndex = 23;
            this.cmbType.UseSystemPasswordChar = false;
            // 
            // txtSave
            // 
            this.txtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSave.BackColor = System.Drawing.Color.White;
            this.txtSave.Location = new System.Drawing.Point(56, 6);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(549, 20);
            this.txtSave.TabIndex = 22;
            this.txtSave.UseSystemPasswordChar = false;
            // 
            // classicLabel2
            // 
            this.classicLabel2.DropShadow = false;
            this.classicLabel2.Location = new System.Drawing.Point(3, 32);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(64, 13);
            this.classicLabel2.TabIndex = 19;
            this.classicLabel2.Text = "File type:";
            // 
            // classicLabel1
            // 
            this.classicLabel1.DropShadow = false;
            this.classicLabel1.Location = new System.Drawing.Point(3, 6);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(64, 13);
            this.classicLabel1.TabIndex = 19;
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
            this.btnSave.Location = new System.Drawing.Point(611, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 15000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // btnCanc
            // 
            this.btnCanc.AdaptBackColorWithTheme = true;
            this.btnCanc.AdaptFontWithTheme = true;
            this.btnCanc.AdaptForeColorWithTheme = true;
            this.btnCanc.BackColor = System.Drawing.Color.Silver;
            this.btnCanc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCanc.ForeColor = System.Drawing.Color.Black;
            this.btnCanc.Location = new System.Drawing.Point(611, 27);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 25);
            this.btnCanc.TabIndex = 24;
            this.btnCanc.Text = "Cancel";
            // 
            // Win95WindowsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.program);
            this.Name = "Win95WindowsExplorer";
            this.Size = new System.Drawing.Size(704, 517);
            this.Load += new System.EventHandler(this.WinClassicWindowsExplorer_Load);
            this.program.ResumeLayout(false);
            this.program.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.pnlSave.ResumeLayout(false);
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
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CutCtrlXToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CopyCtrlCToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SellectAllCtrlAToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem AboutWindows95ToolStripMenuItem;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel topleftcorner;
        internal System.Windows.Forms.ListView mainView;
        internal System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Timer refresh;
        private Engine.UI.ClassicButton btnSave;
        private Engine.UI.ClassicLabel classicLabel2;
        private Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicTextBox txtSave;
        private Engine.UI.ClassicDropDown cmbType;
        private Engine.UI.ClassicButton btnCanc;
    }
}
