namespace Histacom2
{
    partial class TitleScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            this.vmModeTimer = new System.Windows.Forms.Timer(this.components);
            this.program = new System.Windows.Forms.Panel();
            this.programContent = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VM_Height = new System.Windows.Forms.NumericUpDown();
            this.VM_Width = new System.Windows.Forms.NumericUpDown();
            this.vm_mode = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameversion = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.PictureBox();
            this.startmenu = new System.Windows.Forms.Panel();
            this.startmenuitems = new System.Windows.Forms.MenuStrip();
            this.DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achievementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ossidestartmenu = new System.Windows.Forms.Panel();
            this.osimage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.updateText = new System.Windows.Forms.Timer(this.components);
            this.program.SuspendLayout();
            this.programContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).BeginInit();
            this.startmenu.SuspendLayout();
            this.startmenuitems.SuspendLayout();
            this.ossidestartmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // vmModeTimer
            // 
            this.vmModeTimer.Tick += new System.EventHandler(this.vmModeTimer_Tick);
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.programContent);
            this.program.Controls.Add(this.toprightcorner);
            this.program.Controls.Add(this.bottomrightcorner);
            this.program.Controls.Add(this.bottomleftcorner);
            this.program.Controls.Add(this.topleftcorner);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(791, 300);
            this.program.TabIndex = 11;
            // 
            // programContent
            // 
            this.programContent.BackColor = System.Drawing.Color.Teal;
            this.programContent.Controls.Add(this.pictureBox3);
            this.programContent.Controls.Add(this.panel2);
            this.programContent.Controls.Add(this.startmenu);
            this.programContent.Controls.Add(this.pictureBox2);
            this.programContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programContent.Location = new System.Drawing.Point(0, 0);
            this.programContent.Name = "programContent";
            this.programContent.Size = new System.Drawing.Size(791, 300);
            this.programContent.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Histacom2.Properties.Resources.CopyrightNotice;
            this.pictureBox3.Location = new System.Drawing.Point(162, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.VM_Height);
            this.panel2.Controls.Add(this.VM_Width);
            this.panel2.Controls.Add(this.vm_mode);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.gameversion);
            this.panel2.Controls.Add(this.startbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 28);
            this.panel2.TabIndex = 10;
            // 
            // VM_Height
            // 
            this.VM_Height.Location = new System.Drawing.Point(658, 5);
            this.VM_Height.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.VM_Height.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.VM_Height.Name = "VM_Height";
            this.VM_Height.Size = new System.Drawing.Size(50, 20);
            this.VM_Height.TabIndex = 15;
            this.VM_Height.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // VM_Width
            // 
            this.VM_Width.Location = new System.Drawing.Point(605, 5);
            this.VM_Width.Maximum = new decimal(new int[] {
            3840,
            0,
            0,
            0});
            this.VM_Width.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.VM_Width.Name = "VM_Width";
            this.VM_Width.Size = new System.Drawing.Size(50, 20);
            this.VM_Width.TabIndex = 14;
            this.VM_Width.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // vm_mode
            // 
            this.vm_mode.AutoSize = true;
            this.vm_mode.BackColor = System.Drawing.Color.Transparent;
            this.vm_mode.ForeColor = System.Drawing.Color.Black;
            this.vm_mode.Location = new System.Drawing.Point(712, 7);
            this.vm_mode.Name = "vm_mode";
            this.vm_mode.Size = new System.Drawing.Size(72, 17);
            this.vm_mode.TabIndex = 4;
            this.vm_mode.Text = "VM Mode";
            this.vm_mode.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(603, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 28);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // gameversion
            // 
            this.gameversion.AutoSize = true;
            this.gameversion.BackColor = System.Drawing.Color.Transparent;
            this.gameversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameversion.Location = new System.Drawing.Point(25, 6);
            this.gameversion.Name = "gameversion";
            this.gameversion.Size = new System.Drawing.Size(78, 13);
            this.gameversion.TabIndex = 0;
            this.gameversion.Text = "gameversion";
            this.gameversion.Click += new System.EventHandler(this.startbutton_Click);
            this.gameversion.MouseLeave += new System.EventHandler(this.gameversion_MouseLeave);
            this.gameversion.MouseHover += new System.EventHandler(this.gameversion_MouseHover);
            // 
            // startbutton
            // 
            this.startbutton.Image = ((System.Drawing.Image)(resources.GetObject("startbutton.Image")));
            this.startbutton.Location = new System.Drawing.Point(2, 4);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(279, 22);
            this.startbutton.TabIndex = 12;
            this.startbutton.TabStop = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // startmenu
            // 
            this.startmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startmenu.BackColor = System.Drawing.Color.Silver;
            this.startmenu.Controls.Add(this.startmenuitems);
            this.startmenu.Controls.Add(this.ossidestartmenu);
            this.startmenu.Location = new System.Drawing.Point(0, 52);
            this.startmenu.Name = "startmenu";
            this.startmenu.Size = new System.Drawing.Size(156, 223);
            this.startmenu.TabIndex = 11;
            // 
            // startmenuitems
            // 
            this.startmenuitems.BackColor = System.Drawing.Color.Silver;
            this.startmenuitems.Dock = System.Windows.Forms.DockStyle.None;
            this.startmenuitems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocumentsToolStripMenuItem,
            this.ProgramsToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.achievementsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.ShutdownToolStripMenuItem});
            this.startmenuitems.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.startmenuitems.Location = new System.Drawing.Point(23, 2);
            this.startmenuitems.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.startmenuitems.Name = "startmenuitems";
            this.startmenuitems.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.startmenuitems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.startmenuitems.Size = new System.Drawing.Size(140, 220);
            this.startmenuitems.TabIndex = 0;
            this.startmenuitems.Text = "StartMenu";
            // 
            // DocumentsToolStripMenuItem
            // 
            this.DocumentsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.DocumentsToolStripMenuItem.BackgroundImage = global::Histacom2.Properties.Resources.sliversilver;
            this.DocumentsToolStripMenuItem.Image = global::Histacom2.Properties.Resources.WinClassicPrograms;
            this.DocumentsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocumentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem";
            this.DocumentsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.DocumentsToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.DocumentsToolStripMenuItem.Text = "New Game";
            this.DocumentsToolStripMenuItem.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // ProgramsToolStripMenuItem
            // 
            this.ProgramsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.ProgramsToolStripMenuItem.BackgroundImage = global::Histacom2.Properties.Resources.sliversilver;
            this.ProgramsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProgramsToolStripMenuItem.Image = global::Histacom2.Properties.Resources.WinClassicDocuments;
            this.ProgramsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgramsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem";
            this.ProgramsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.ProgramsToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.ProgramsToolStripMenuItem.Text = "Load Game";
            this.ProgramsToolStripMenuItem.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.SettingsToolStripMenuItem.Image = global::Histacom2.Properties.Resources.WinClassicSettings;
            this.SettingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // achievementsToolStripMenuItem
            // 
            this.achievementsToolStripMenuItem.Image = global::Histacom2.Properties.Resources.WinClassicEndingsIcon;
            this.achievementsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.achievementsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.achievementsToolStripMenuItem.Name = "achievementsToolStripMenuItem";
            this.achievementsToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.achievementsToolStripMenuItem.Text = "Achievements";
            this.achievementsToolStripMenuItem.Click += new System.EventHandler(this.achievementsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.HelpToolStripMenuItem.Image = global::Histacom2.Properties.Resources.WinClassicHelp;
            this.HelpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.HelpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // ShutdownToolStripMenuItem
            // 
            this.ShutdownToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.ShutdownToolStripMenuItem.Image = global::Histacom2.Properties.Resources.WinClassicShutdown;
            this.ShutdownToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutdownToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem";
            this.ShutdownToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.ShutdownToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.ShutdownToolStripMenuItem.Text = "Shut Down...";
            this.ShutdownToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ossidestartmenu
            // 
            this.ossidestartmenu.Controls.Add(this.osimage);
            this.ossidestartmenu.Location = new System.Drawing.Point(2, 2);
            this.ossidestartmenu.Name = "ossidestartmenu";
            this.ossidestartmenu.Size = new System.Drawing.Size(21, 216);
            this.ossidestartmenu.TabIndex = 4;
            // 
            // osimage
            // 
            this.osimage.BackColor = System.Drawing.Color.Gray;
            this.osimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osimage.Image = global::Histacom2.Properties.Resources.LauncherSideBar;
            this.osimage.Location = new System.Drawing.Point(0, 0);
            this.osimage.Name = "osimage";
            this.osimage.Size = new System.Drawing.Size(21, 216);
            this.osimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.osimage.TabIndex = 0;
            this.osimage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Histacom2.Properties.Resources.Histacom2_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(171, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(613, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // toprightcorner
            // 
            this.toprightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toprightcorner.BackgroundImage")));
            this.toprightcorner.Location = new System.Drawing.Point(787, 0);
            this.toprightcorner.Name = "toprightcorner";
            this.toprightcorner.Size = new System.Drawing.Size(4, 4);
            this.toprightcorner.TabIndex = 6;
            // 
            // bottomrightcorner
            // 
            this.bottomrightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomrightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomrightcorner.BackgroundImage")));
            this.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomrightcorner.Location = new System.Drawing.Point(787, 296);
            this.bottomrightcorner.Name = "bottomrightcorner";
            this.bottomrightcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomrightcorner.TabIndex = 4;
            // 
            // bottomleftcorner
            // 
            this.bottomleftcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomleftcorner.BackgroundImage")));
            this.bottomleftcorner.Location = new System.Drawing.Point(0, 296);
            this.bottomleftcorner.Name = "bottomleftcorner";
            this.bottomleftcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomleftcorner.TabIndex = 2;
            // 
            // topleftcorner
            // 
            this.topleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topleftcorner.BackgroundImage")));
            this.topleftcorner.Location = new System.Drawing.Point(0, 0);
            this.topleftcorner.Name = "topleftcorner";
            this.topleftcorner.Size = new System.Drawing.Size(4, 4);
            this.topleftcorner.TabIndex = 1;
            // 
            // updateText
            // 
            this.updateText.Enabled = true;
            this.updateText.Tick += new System.EventHandler(this.updateText_Tick);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(791, 300);
            this.Controls.Add(this.program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TitleScreen";
            this.Tag = "ignoreFormOnTaskbar";
            this.Text = "Histacom Launcher";
            this.Load += new System.EventHandler(this.TitleScreen_Load);
            this.program.ResumeLayout(false);
            this.programContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).EndInit();
            this.startmenu.ResumeLayout(false);
            this.startmenu.PerformLayout();
            this.startmenuitems.ResumeLayout(false);
            this.startmenuitems.PerformLayout();
            this.ossidestartmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.osimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer vmModeTimer;
        internal System.Windows.Forms.Panel program;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel bottomrightcorner;
        internal System.Windows.Forms.Panel bottomleftcorner;
        internal System.Windows.Forms.Panel topleftcorner;
        public System.Windows.Forms.Panel programContent;
        internal System.Windows.Forms.Panel startmenu;
        internal System.Windows.Forms.MenuStrip startmenuitems;
        internal System.Windows.Forms.ToolStripMenuItem DocumentsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ProgramsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ShutdownToolStripMenuItem;
        internal System.Windows.Forms.Panel ossidestartmenu;
        internal System.Windows.Forms.PictureBox osimage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown VM_Height;
        private System.Windows.Forms.NumericUpDown VM_Width;
        private System.Windows.Forms.CheckBox vm_mode;
        internal System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label gameversion;
        internal System.Windows.Forms.PictureBox startbutton;
        private System.Windows.Forms.Timer updateText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem achievementsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}