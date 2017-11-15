namespace Histacom2.Engine.Template
{
    partial class AboutBox98
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new Histacom2.Engine.UI.ClassicLabel();
            this.textBox4 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicButton1 = new Histacom2.Engine.UI.ClassicButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(78, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(193, 42);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "@SOFTWARENAME\r\nWindows 98\r\nCopyright © 1981-1997 Microsoft Corp.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(78, 106);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(185, 42);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "This product is licensed to:\r\n@ACTUALUSER\r\n@COMPANYNAME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Histacom2.Engine.Properties.Resources.WinAboutSeparator95;
            this.pictureBox2.Location = new System.Drawing.Point(76, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 2);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.DropShadow = false;
            this.textBox3.Location = new System.Drawing.Point(74, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 13);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Physical Memory Available to Windows:   196,052 KB";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.DropShadow = false;
            this.textBox4.Location = new System.Drawing.Point(74, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 13);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "System Resources:                                    90% Free";
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
            this.classicButton1.Location = new System.Drawing.Point(251, 223);
            this.classicButton1.Name = "classicButton1";
            this.classicButton1.Size = new System.Drawing.Size(75, 23);
            this.classicButton1.TabIndex = 6;
            this.classicButton1.Text = "OK";
            this.classicButton1.Click += new System.EventHandler(this.classicButton1_Click);
            // 
            // AboutBox98
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.classicButton1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AboutBox98";
            this.Size = new System.Drawing.Size(342, 255);
            this.Tag = "gnoreFormOnTaskbar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UI.ClassicLabel textBox3;
        private UI.ClassicLabel textBox4;
        private UI.ClassicButton classicButton1;
    }
}
