namespace Histacom2.GlobalPrograms.InstallerPanes
{
    partial class WelcomePane
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel4 = new Histacom2.Engine.UI.ClassicLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Histacom2.Properties.Resources.WinClassicInstallSidebar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 314);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // classicLabel1
            // 
            this.classicLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel1.Location = new System.Drawing.Point(177, 19);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(311, 40);
            this.classicLabel1.TabIndex = 1;
            this.classicLabel1.Text = "Welcome to the Program Setup Wizard";
            // 
            // classicLabel2
            // 
            this.classicLabel2.Location = new System.Drawing.Point(177, 72);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(311, 13);
            this.classicLabel2.TabIndex = 2;
            this.classicLabel2.Text = "This will install Program on your computer.";
            // 
            // classicLabel3
            // 
            this.classicLabel3.Location = new System.Drawing.Point(177, 98);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(311, 26);
            this.classicLabel3.TabIndex = 3;
            this.classicLabel3.Text = "It is recommended that you close all other applications before continuing.";
            // 
            // classicLabel4
            // 
            this.classicLabel4.Location = new System.Drawing.Point(177, 137);
            this.classicLabel4.Name = "classicLabel4";
            this.classicLabel4.Size = new System.Drawing.Size(311, 13);
            this.classicLabel4.TabIndex = 4;
            this.classicLabel4.Text = "Click Next to continue, or Cancel to exit Setup.";
            // 
            // WelcomePane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.classicLabel4);
            this.Controls.Add(this.classicLabel3);
            this.Controls.Add(this.classicLabel2);
            this.Controls.Add(this.classicLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WelcomePane";
            this.Size = new System.Drawing.Size(495, 314);
            this.Load += new System.EventHandler(this.WelcomePane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicLabel classicLabel2;
        private Engine.UI.ClassicLabel classicLabel3;
        private Engine.UI.ClassicLabel classicLabel4;
    }
}
