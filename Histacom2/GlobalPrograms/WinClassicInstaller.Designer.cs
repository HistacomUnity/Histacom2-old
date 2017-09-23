namespace Histacom2.GlobalPrograms
{
    partial class WinClassicInstaller
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
            this.classicButton1 = new Histacom2.Engine.UI.ClassicButton();
            this.classicButton2 = new Histacom2.Engine.UI.ClassicButton();
            this.classicButton3 = new Histacom2.Engine.UI.ClassicButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 314);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Histacom2.Properties.Resources.ie4_hsplitter;
            this.pictureBox1.Location = new System.Drawing.Point(0, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 2);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.classicButton1.Location = new System.Drawing.Point(408, 326);
            this.classicButton1.Name = "classicButton1";
            this.classicButton1.Size = new System.Drawing.Size(75, 23);
            this.classicButton1.TabIndex = 2;
            this.classicButton1.Text = "Cancel";
            // 
            // classicButton2
            // 
            this.classicButton2.AdaptBackColorWithTheme = true;
            this.classicButton2.AdaptFontWithTheme = true;
            this.classicButton2.AdaptForeColorWithTheme = true;
            this.classicButton2.BackColor = System.Drawing.Color.Silver;
            this.classicButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.classicButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton2.ForeColor = System.Drawing.Color.Black;
            this.classicButton2.Location = new System.Drawing.Point(323, 326);
            this.classicButton2.Name = "classicButton2";
            this.classicButton2.Size = new System.Drawing.Size(75, 23);
            this.classicButton2.TabIndex = 3;
            this.classicButton2.Text = "&Next >";
            this.classicButton2.Click += new System.EventHandler(this.classicButton2_Click);
            // 
            // classicButton3
            // 
            this.classicButton3.AdaptBackColorWithTheme = true;
            this.classicButton3.AdaptFontWithTheme = true;
            this.classicButton3.AdaptForeColorWithTheme = true;
            this.classicButton3.BackColor = System.Drawing.Color.Silver;
            this.classicButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.classicButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton3.ForeColor = System.Drawing.Color.Black;
            this.classicButton3.Location = new System.Drawing.Point(248, 326);
            this.classicButton3.Name = "classicButton3";
            this.classicButton3.Size = new System.Drawing.Size(75, 23);
            this.classicButton3.TabIndex = 4;
            this.classicButton3.Text = "< &Back";
            this.classicButton3.Visible = false;
            // 
            // WinClassicInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.classicButton3);
            this.Controls.Add(this.classicButton2);
            this.Controls.Add(this.classicButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(495, 358);
            this.MinimumSize = new System.Drawing.Size(495, 358);
            this.Name = "WinClassicInstaller";
            this.Size = new System.Drawing.Size(495, 358);
            this.Load += new System.EventHandler(this.WinClassicInstaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Engine.UI.ClassicButton classicButton1;
        private Engine.UI.ClassicButton classicButton2;
        private Engine.UI.ClassicButton classicButton3;
    }
}
