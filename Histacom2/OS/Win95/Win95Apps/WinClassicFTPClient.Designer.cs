namespace Histacom2.OS.Win95.Win95Apps
{
    partial class WinClassicFTPClient
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "/software/"}, 0, System.Drawing.Color.Black, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "index.html"}, 1, System.Drawing.Color.Black, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "???.html"}, 1, System.Drawing.Color.Black, System.Drawing.Color.Empty, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinClassicFTPClient));
            this.topBar = new System.Windows.Forms.Panel();
            this.btnLogin = new Histacom2.Engine.UI.ClassicButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Histacom2.Engine.UI.ClassicButton();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.ftpFiles = new System.Windows.Forms.ListView();
            this.fileIcons = new System.Windows.Forms.ImageList(this.components);
            this.hostnameBox = new Histacom2.Engine.UI.ClassicTextBox();
            this.usernameBox = new Histacom2.Engine.UI.ClassicTextBox();
            this.passBox = new Histacom2.Engine.UI.ClassicTextBox();
            this.infoLabel = new Histacom2.Engine.UI.ClassicLabel();
            this.textBox4 = new Histacom2.Engine.UI.ClassicTextBox();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel4 = new Histacom2.Engine.UI.ClassicLabel();
            this.topBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topBar.Controls.Add(this.infoLabel);
            this.topBar.Controls.Add(this.textBox4);
            this.topBar.Controls.Add(this.passBox);
            this.topBar.Controls.Add(this.usernameBox);
            this.topBar.Controls.Add(this.hostnameBox);
            this.topBar.Controls.Add(this.btnLogin);
            this.topBar.Controls.Add(this.classicLabel4);
            this.topBar.Controls.Add(this.classicLabel3);
            this.topBar.Controls.Add(this.classicLabel2);
            this.topBar.Controls.Add(this.classicLabel1);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(762, 30);
            this.topBar.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AdaptBackColorWithTheme = true;
            this.btnLogin.AdaptFontWithTheme = true;
            this.btnLogin.AdaptForeColorWithTheme = true;
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(571, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(44, 20);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 30);
            this.panel1.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.AdaptBackColorWithTheme = true;
            this.btnCancel.AdaptFontWithTheme = true;
            this.btnCancel.AdaptForeColorWithTheme = true;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Location = new System.Drawing.Point(577, 7);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(178, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Please login to a remote FTP server.";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ftpFiles
            // 
            this.ftpFiles.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ftpFiles.AutoArrange = false;
            this.ftpFiles.BackColor = System.Drawing.Color.White;
            this.ftpFiles.BackgroundImageTiled = true;
            this.ftpFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ftpFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.ftpFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftpFiles.ForeColor = System.Drawing.Color.White;
            this.ftpFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.ftpFiles.Location = new System.Drawing.Point(0, 30);
            this.ftpFiles.Name = "ftpFiles";
            this.ftpFiles.Size = new System.Drawing.Size(762, 439);
            this.ftpFiles.SmallImageList = this.fileIcons;
            this.ftpFiles.StateImageList = this.fileIcons;
            this.ftpFiles.TabIndex = 7;
            this.ftpFiles.TileSize = new System.Drawing.Size(32, 32);
            this.ftpFiles.UseCompatibleStateImageBehavior = false;
            this.ftpFiles.View = System.Windows.Forms.View.List;
            this.ftpFiles.Visible = false;
            this.ftpFiles.DoubleClick += new System.EventHandler(this.ftpFiles_DoubleClick);
            // 
            // fileIcons
            // 
            this.fileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIcons.ImageStream")));
            this.fileIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIcons.Images.SetKeyName(0, "WinClassicFolder.png");
            this.fileIcons.Images.SetKeyName(1, "WinClassicNotepad.png");
            this.fileIcons.Images.SetKeyName(2, "WinClassicSetup.png");
            // 
            // hostnameBox
            // 
            this.hostnameBox.BackColor = System.Drawing.Color.White;
            this.hostnameBox.Location = new System.Drawing.Point(37, 4);
            this.hostnameBox.Name = "hostnameBox";
            this.hostnameBox.Size = new System.Drawing.Size(113, 20);
            this.hostnameBox.TabIndex = 10;
            this.hostnameBox.UseSystemPasswordChar = false;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.White;
            this.usernameBox.Location = new System.Drawing.Point(220, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(109, 20);
            this.usernameBox.TabIndex = 10;
            this.usernameBox.UseSystemPasswordChar = false;
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.Location = new System.Drawing.Point(392, 4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(105, 20);
            this.passBox.TabIndex = 10;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // infoLabel
            // 
            this.infoLabel.DropShadow = false;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(621, 7);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(75, 13);
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "classicLabel1";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(530, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(36, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.UseSystemPasswordChar = false;
            // 
            // classicLabel1
            // 
            this.classicLabel1.BackColor = System.Drawing.Color.Transparent;
            this.classicLabel1.DropShadow = false;
            this.classicLabel1.ForeColor = System.Drawing.Color.Black;
            this.classicLabel1.Location = new System.Drawing.Point(3, 7);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(75, 13);
            this.classicLabel1.TabIndex = 11;
            this.classicLabel1.Text = "Host:";
            // 
            // classicLabel2
            // 
            this.classicLabel2.BackColor = System.Drawing.Color.Transparent;
            this.classicLabel2.DropShadow = false;
            this.classicLabel2.ForeColor = System.Drawing.Color.Black;
            this.classicLabel2.Location = new System.Drawing.Point(156, 7);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(75, 13);
            this.classicLabel2.TabIndex = 11;
            this.classicLabel2.Text = "Username:";
            // 
            // classicLabel3
            // 
            this.classicLabel3.BackColor = System.Drawing.Color.Transparent;
            this.classicLabel3.DropShadow = false;
            this.classicLabel3.ForeColor = System.Drawing.Color.Black;
            this.classicLabel3.Location = new System.Drawing.Point(335, 7);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(75, 13);
            this.classicLabel3.TabIndex = 11;
            this.classicLabel3.Text = "Password:";
            // 
            // classicLabel4
            // 
            this.classicLabel4.BackColor = System.Drawing.Color.Transparent;
            this.classicLabel4.DropShadow = false;
            this.classicLabel4.ForeColor = System.Drawing.Color.Black;
            this.classicLabel4.Location = new System.Drawing.Point(503, 7);
            this.classicLabel4.Name = "classicLabel4";
            this.classicLabel4.Size = new System.Drawing.Size(75, 13);
            this.classicLabel4.TabIndex = 11;
            this.classicLabel4.Text = "Port:";
            // 
            // WinClassicFTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ftpFiles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topBar);
            this.Name = "WinClassicFTPClient";
            this.Size = new System.Drawing.Size(762, 499);
            this.Load += new System.EventHandler(this.WinClassicFTPClient_Load);
            this.topBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Engine.UI.ClassicButton btnCancel;
        private System.Windows.Forms.Label welcomeLabel;
        internal System.Windows.Forms.ListView ftpFiles;
        private System.Windows.Forms.ImageList fileIcons;
        private Engine.UI.ClassicButton btnLogin;
        private Engine.UI.ClassicTextBox hostnameBox;
        private Engine.UI.ClassicTextBox passBox;
        private Engine.UI.ClassicTextBox usernameBox;
        private Engine.UI.ClassicLabel infoLabel;
        private Engine.UI.ClassicTextBox textBox4;
        private Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicLabel classicLabel3;
        private Engine.UI.ClassicLabel classicLabel2;
        private Engine.UI.ClassicLabel classicLabel4;
    }
}
