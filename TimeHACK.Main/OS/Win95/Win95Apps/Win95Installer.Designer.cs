namespace TimeHACK.OS.Win95.Win95Apps
{
    partial class Win95Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win95Installer));
            this.installPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.installname = new System.Windows.Forms.Label();
            this.cancelbutton1 = new System.Windows.Forms.Button();
            this.nextbutton1 = new System.Windows.Forms.Button();
            this.backbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.installPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // installPic
            // 
            this.installPic.BackgroundImage = global::TimeHACK.Properties.Resources.WinClassicInstallPic;
            this.installPic.Location = new System.Drawing.Point(18, 16);
            this.installPic.Name = "installPic";
            this.installPic.Size = new System.Drawing.Size(120, 260);
            this.installPic.TabIndex = 0;
            this.installPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TimeHACK.Properties.Resources.WinAboutSeparator95;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 2);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 260);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // installname
            // 
            this.installname.AutoSize = true;
            this.installname.Location = new System.Drawing.Point(18, 301);
            this.installname.Name = "installname";
            this.installname.Size = new System.Drawing.Size(35, 13);
            this.installname.TabIndex = 3;
            this.installname.Text = "label2";
            this.installname.Visible = false;
            // 
            // cancelbutton1
            // 
            this.cancelbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton1.Location = new System.Drawing.Point(393, 301);
            this.cancelbutton1.Name = "cancelbutton1";
            this.cancelbutton1.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton1.TabIndex = 4;
            this.cancelbutton1.Text = "Cancel";
            this.cancelbutton1.UseVisualStyleBackColor = true;
            // 
            // nextbutton1
            // 
            this.nextbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbutton1.Location = new System.Drawing.Point(312, 301);
            this.nextbutton1.Name = "nextbutton1";
            this.nextbutton1.Size = new System.Drawing.Size(75, 23);
            this.nextbutton1.TabIndex = 5;
            this.nextbutton1.Text = "Next";
            this.nextbutton1.UseVisualStyleBackColor = true;
            // 
            // backbutton1
            // 
            this.backbutton1.Enabled = false;
            this.backbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton1.Location = new System.Drawing.Point(241, 301);
            this.backbutton1.Name = "backbutton1";
            this.backbutton1.Size = new System.Drawing.Size(75, 23);
            this.backbutton1.TabIndex = 6;
            this.backbutton1.Text = "Back";
            this.backbutton1.UseVisualStyleBackColor = true;
            // 
            // Win95Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.backbutton1);
            this.Controls.Add(this.nextbutton1);
            this.Controls.Add(this.cancelbutton1);
            this.Controls.Add(this.installname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.installPic);
            this.Name = "Win95Installer";
            this.Size = new System.Drawing.Size(488, 340);
            this.Load += new System.EventHandler(this.Win95Installer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.installPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox installPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label installname;
        private System.Windows.Forms.Button cancelbutton1;
        private System.Windows.Forms.Button nextbutton1;
        private System.Windows.Forms.Button backbutton1;
    }
}
