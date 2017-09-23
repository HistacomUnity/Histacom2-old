namespace Histacom2.GlobalPrograms.InstallerPanes
{
    partial class DirectoryPane
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel4 = new Histacom2.Engine.UI.ClassicLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classicLabel5 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicButton1 = new Histacom2.Engine.UI.ClassicButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.classicLabel2);
            this.panel1.Controls.Add(this.classicLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 58);
            this.panel1.TabIndex = 0;
            // 
            // classicLabel2
            // 
            this.classicLabel2.Location = new System.Drawing.Point(40, 28);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(259, 13);
            this.classicLabel2.TabIndex = 1;
            this.classicLabel2.Text = "Select folder where setup will install files.";
            // 
            // classicLabel1
            // 
            this.classicLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel1.Location = new System.Drawing.Point(25, 12);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(274, 13);
            this.classicLabel1.TabIndex = 0;
            this.classicLabel1.Text = "Choose Destination L o c a t i o n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Histacom2.Properties.Resources.WinClassicInstallIcon;
            this.pictureBox1.Location = new System.Drawing.Point(440, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // classicLabel3
            // 
            this.classicLabel3.Location = new System.Drawing.Point(25, 73);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(446, 13);
            this.classicLabel3.TabIndex = 1;
            this.classicLabel3.Text = "Setup will install Program to the destination folder.";
            // 
            // classicLabel4
            // 
            this.classicLabel4.Location = new System.Drawing.Point(25, 99);
            this.classicLabel4.Name = "classicLabel4";
            this.classicLabel4.Size = new System.Drawing.Size(446, 26);
            this.classicLabel4.TabIndex = 2;
            this.classicLabel4.Text = "To install to the default folder, click Next. To install to a different folder, c" +
    "lick Browse and select another folder.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classicButton1);
            this.groupBox1.Controls.Add(this.classicLabel5);
            this.groupBox1.Location = new System.Drawing.Point(24, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination Folder";
            // 
            // classicLabel5
            // 
            this.classicLabel5.Location = new System.Drawing.Point(12, 27);
            this.classicLabel5.Name = "classicLabel5";
            this.classicLabel5.Size = new System.Drawing.Size(311, 13);
            this.classicLabel5.TabIndex = 0;
            this.classicLabel5.Text = "C:\\Program Files\\12padams\\Program\\";
            // 
            // classicButton1
            // 
            this.classicButton1.AdaptBackColorWithTheme = true;
            this.classicButton1.AdaptFontWithTheme = true;
            this.classicButton1.AdaptForeColorWithTheme = true;
            this.classicButton1.BackColor = System.Drawing.Color.Silver;
            this.classicButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.classicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton1.ForeColor = System.Drawing.Color.Black;
            this.classicButton1.Location = new System.Drawing.Point(365, 22);
            this.classicButton1.Name = "classicButton1";
            this.classicButton1.Size = new System.Drawing.Size(75, 23);
            this.classicButton1.TabIndex = 1;
            this.classicButton1.Text = "B&rowse...";
            // 
            // DirectoryPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.classicLabel4);
            this.Controls.Add(this.classicLabel3);
            this.Controls.Add(this.panel1);
            this.Name = "DirectoryPane";
            this.Size = new System.Drawing.Size(495, 314);
            this.Load += new System.EventHandler(this.DirectoryPane_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicLabel classicLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Engine.UI.ClassicLabel classicLabel3;
        private Engine.UI.ClassicLabel classicLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private Engine.UI.ClassicButton classicButton1;
        private Engine.UI.ClassicLabel classicLabel5;
    }
}
