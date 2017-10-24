namespace Histacom2.GlobalPrograms.InstallerPanes
{
    partial class CompletePane
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
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classicLabel3
            // 
            this.classicLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.classicLabel3.Location = new System.Drawing.Point(13, 114);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(307, 13);
            this.classicLabel3.TabIndex = 8;
            this.classicLabel3.Text = "Click Finish to exit Setup.";
            // 
            // classicLabel2
            // 
            this.classicLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.classicLabel2.Location = new System.Drawing.Point(13, 66);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(307, 38);
            this.classicLabel2.TabIndex = 7;
            this.classicLabel2.Text = "Setup has finished installing Program on your computer. The application may be la" +
    "unched by selecting the installed icons.";
            // 
            // classicLabel1
            // 
            this.classicLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.classicLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel1.Location = new System.Drawing.Point(13, 16);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(307, 40);
            this.classicLabel1.TabIndex = 6;
            this.classicLabel1.Text = "Completing the Program Setup Wizard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Histacom2.Properties.Resources.WinClassicInstallSidebar;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 314);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.classicLabel3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.classicLabel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.classicLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 16, 11, 0);
            this.panel1.Size = new System.Drawing.Size(331, 314);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(13, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 10);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(13, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 10);
            this.panel3.TabIndex = 9;
            // 
            // CompletePane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CompletePane";
            this.Size = new System.Drawing.Size(495, 314);
            this.Load += new System.EventHandler(this.CompletePane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Engine.UI.ClassicLabel classicLabel3;
        private Engine.UI.ClassicLabel classicLabel2;
        private Engine.UI.ClassicLabel classicLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
