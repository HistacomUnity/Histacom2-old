namespace TimeHACK.OS.Win95.Win95Apps
{
    partial class WinClassicWordPad
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
            this.topmenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutWordpadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormatBar = new System.Windows.Forms.Panel();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.comboFont = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.topmenu.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFormatBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topmenu
            // 
            this.topmenu.BackColor = System.Drawing.Color.Silver;
            this.topmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topmenu.Location = new System.Drawing.Point(0, 0);
            this.topmenu.Name = "topmenu";
            this.topmenu.Size = new System.Drawing.Size(593, 24);
            this.topmenu.TabIndex = 0;
            this.topmenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sendToolStripMenuItem.Text = "Send...";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem,
            this.formatBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.Checked = true;
            this.toolbarToolStripMenuItem.CheckOnClick = true;
            this.toolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            this.toolbarToolStripMenuItem.Click += new System.EventHandler(this.toolbarToolStripMenuItem_Click);
            // 
            // formatBarToolStripMenuItem
            // 
            this.formatBarToolStripMenuItem.Checked = true;
            this.formatBarToolStripMenuItem.CheckOnClick = true;
            this.formatBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.formatBarToolStripMenuItem.Name = "formatBarToolStripMenuItem";
            this.formatBarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.formatBarToolStripMenuItem.Text = "Format Bar";
            this.formatBarToolStripMenuItem.Click += new System.EventHandler(this.formatBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateTimeToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.dateTimeToolStripMenuItem.Text = "Date/Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulletStyleToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // bulletStyleToolStripMenuItem
            // 
            this.bulletStyleToolStripMenuItem.CheckOnClick = true;
            this.bulletStyleToolStripMenuItem.Name = "bulletStyleToolStripMenuItem";
            this.bulletStyleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.bulletStyleToolStripMenuItem.Text = "Bullet style";
            this.bulletStyleToolStripMenuItem.Click += new System.EventHandler(this.bulletStyleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutWordpadToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpTopicsToolStripMenuItem
            // 
            this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.helpTopicsToolStripMenuItem.Text = "Help Topics";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(156, 6);
            // 
            // aboutWordpadToolStripMenuItem
            // 
            this.aboutWordpadToolStripMenuItem.Name = "aboutWordpadToolStripMenuItem";
            this.aboutWordpadToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutWordpadToolStripMenuItem.Text = "About Wordpad";
            this.aboutWordpadToolStripMenuItem.Click += new System.EventHandler(this.aboutWordpadToolStripMenuItem_Click);
            // 
            // mainText
            // 
            this.mainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainText.Location = new System.Drawing.Point(0, 80);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(593, 290);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.Silver;
            this.pnlToolbar.Controls.Add(this.btnPaste);
            this.pnlToolbar.Controls.Add(this.btnCopy);
            this.pnlToolbar.Controls.Add(this.btnCut);
            this.pnlToolbar.Controls.Add(this.btnNew);
            this.pnlToolbar.Controls.Add(this.pictureBox1);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 24);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(593, 28);
            this.pnlToolbar.TabIndex = 2;
            // 
            // btnPaste
            // 
            this.btnPaste.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.btnPaste.Image = global::TimeHACK.Properties.Resources.WinClassicPaste;
            this.btnPaste.Location = new System.Drawing.Point(102, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(26, 23);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.btnCopy.Image = global::TimeHACK.Properties.Resources.WinClassicCopy;
            this.btnCopy.Location = new System.Drawing.Point(70, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(26, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.btnCut.Image = global::TimeHACK.Properties.Resources.WinClassicCut;
            this.btnCut.Location = new System.Drawing.Point(38, 3);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(26, 23);
            this.btnCut.TabIndex = 1;
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.btnNew.Image = global::TimeHACK.Properties.Resources.WinClassicNew;
            this.btnNew.Location = new System.Drawing.Point(6, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(26, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 1);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFormatBar
            // 
            this.pnlFormatBar.BackColor = System.Drawing.Color.Silver;
            this.pnlFormatBar.Controls.Add(this.comboSize);
            this.pnlFormatBar.Controls.Add(this.comboFont);
            this.pnlFormatBar.Controls.Add(this.pictureBox2);
            this.pnlFormatBar.Controls.Add(this.btnUnderline);
            this.pnlFormatBar.Controls.Add(this.btnItalic);
            this.pnlFormatBar.Controls.Add(this.btnBold);
            this.pnlFormatBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormatBar.Location = new System.Drawing.Point(0, 52);
            this.pnlFormatBar.Name = "pnlFormatBar";
            this.pnlFormatBar.Size = new System.Drawing.Size(593, 28);
            this.pnlFormatBar.TabIndex = 3;
            // 
            // comboSize
            // 
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.comboSize.Location = new System.Drawing.Point(157, 3);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(50, 21);
            this.comboSize.TabIndex = 1;
            this.comboSize.Text = "12";
            this.comboSize.SelectedIndexChanged += new System.EventHandler(this.comboSize_SelectedIndexChanged);
            // 
            // comboFont
            // 
            this.comboFont.FormattingEnabled = true;
            this.comboFont.Location = new System.Drawing.Point(6, 3);
            this.comboFont.Name = "comboFont";
            this.comboFont.Size = new System.Drawing.Size(145, 21);
            this.comboFont.TabIndex = 1;
            this.comboFont.Text = "Arial";
            this.comboFont.SelectedIndexChanged += new System.EventHandler(this.comboFont_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(593, 1);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackColor = System.Drawing.Color.DimGray;
            this.btnUnderline.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(277, 2);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(26, 23);
            this.btnUnderline.TabIndex = 1;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = false;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            this.btnUnderline.MouseEnter += new System.EventHandler(this.btnUnderline_MouseEnter);
            this.btnUnderline.MouseLeave += new System.EventHandler(this.btnUnderline_MouseLeave);
            // 
            // btnItalic
            // 
            this.btnItalic.BackColor = System.Drawing.Color.DimGray;
            this.btnItalic.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(245, 2);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(26, 23);
            this.btnItalic.TabIndex = 1;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = false;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            this.btnItalic.MouseEnter += new System.EventHandler(this.btnItalic_MouseEnter);
            this.btnItalic.MouseLeave += new System.EventHandler(this.btnItalic_MouseLeave);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.Color.DimGray;
            this.btnBold.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(213, 2);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(26, 23);
            this.btnBold.TabIndex = 1;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            this.btnBold.MouseEnter += new System.EventHandler(this.btnBold_MouseEnter);
            this.btnBold.MouseLeave += new System.EventHandler(this.btnBold_MouseLeave);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Silver;
            this.statusBar.Controls.Add(this.lblStatus);
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Location = new System.Drawing.Point(0, 353);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(593, 17);
            this.statusBar.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(213, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "For Help, go to Help -> Help topics";
            // 
            // WinClassicWordPad
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.pnlFormatBar);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.topmenu);
            this.Name = "WinClassicWordPad";
            this.Size = new System.Drawing.Size(593, 370);
            this.topmenu.ResumeLayout(false);
            this.topmenu.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFormatBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.MenuStrip topmenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulletStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutWordpadToolStripMenuItem;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFormatBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel statusBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox comboFont;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnBold;
    }
}
