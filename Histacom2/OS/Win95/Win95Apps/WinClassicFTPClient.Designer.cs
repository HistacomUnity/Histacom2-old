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
            this.infoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hostnameBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.ftpFiles = new System.Windows.Forms.ListView();
            this.fileIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnLogin = new Histacom2.Engine.UI.ClassicButton();
            this.topBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topBar.Controls.Add(this.btnLogin);
            this.topBar.Controls.Add(this.infoLabel);
            this.topBar.Controls.Add(this.label4);
            this.topBar.Controls.Add(this.textBox4);
            this.topBar.Controls.Add(this.label3);
            this.topBar.Controls.Add(this.passBox);
            this.topBar.Controls.Add(this.label2);
            this.topBar.Controls.Add(this.usernameBox);
            this.topBar.Controls.Add(this.label1);
            this.topBar.Controls.Add(this.hostnameBox);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(762, 30);
            this.topBar.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(635, 7);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "label5";
            this.infoLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Port:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(538, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "21";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pass&word:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(397, 4);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(214, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Host:";
            // 
            // hostnameBox
            // 
            this.hostnameBox.Location = new System.Drawing.Point(41, 4);
            this.hostnameBox.Name = "hostnameBox";
            this.hostnameBox.Size = new System.Drawing.Size(100, 20);
            this.hostnameBox.TabIndex = 1;
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
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.ftpFiles.Click += new System.EventHandler(this.ftpItems_Click);
            // 
            // fileIcons
            // 
            this.fileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIcons.ImageStream")));
            this.fileIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIcons.Images.SetKeyName(0, "WinClassicFolder.png");
            this.fileIcons.Images.SetKeyName(1, "WinClassicNotepad.png");
            this.fileIcons.Images.SetKeyName(2, "WinClassicSetup.png");
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(585, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(44, 20);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
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
            this.topBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox hostnameBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label welcomeLabel;
        internal System.Windows.Forms.ListView ftpFiles;
        private System.Windows.Forms.ImageList fileIcons;
        private Engine.UI.ClassicButton btnLogin;
    }
}
