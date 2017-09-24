namespace Histacom2.GlobalPrograms.InstallerPanes
{
    partial class ProgressPane
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.progressBar1 = new Histacom2.Engine.UI.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Histacom2.Properties.Resources.WinClassicInstallIcon;
            this.pictureBox1.Location = new System.Drawing.Point(440, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // classicLabel2
            // 
            this.classicLabel2.Location = new System.Drawing.Point(40, 28);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(380, 13);
            this.classicLabel2.TabIndex = 1;
            this.classicLabel2.Text = "Please   wait   while   setup   installs   Program   on   your   computer.       " +
    "  ";
            // 
            // classicLabel1
            // 
            this.classicLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel1.Location = new System.Drawing.Point(25, 12);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(274, 13);
            this.classicLabel1.TabIndex = 0;
            this.classicLabel1.Text = "Installi n g";
            // 
            // classicLabel3
            // 
            this.classicLabel3.Location = new System.Drawing.Point(25, 73);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(446, 13);
            this.classicLabel3.TabIndex = 1;
            this.classicLabel3.Text = "Extracting Files...";
            // 
            // progressBar1
            // 
            this.progressBar1.BlockSpacing = 5;
            this.progressBar1.BlockWidth = 20;
            this.progressBar1.Location = new System.Drawing.Point(25, 93);
            this.progressBar1.MarqueeWidth = 125;
            this.progressBar1.Maximum = 100D;
            this.progressBar1.Minimum = 0D;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.DarkBlue;
            this.progressBar1.ShowText = false;
            this.progressBar1.Size = new System.Drawing.Size(436, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Text = "progressBar1";
            this.progressBar1.Value = 0D;
            // 
            // ProgressPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.classicLabel3);
            this.Controls.Add(this.panel1);
            this.Name = "ProgressPane";
            this.Size = new System.Drawing.Size(495, 314);
            this.Load += new System.EventHandler(this.DirectoryPane_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicLabel classicLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Engine.UI.ClassicLabel classicLabel3;
        private Engine.UI.ProgressBar progressBar1;
    }
}
