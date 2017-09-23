namespace Histacom2.GlobalPrograms.InstallerPanes
{
    partial class EULAPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EULAPane));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.classicLabel2.Size = new System.Drawing.Size(394, 13);
            this.classicLabel2.TabIndex = 1;
            this.classicLabel2.Text = "Please read the following important information before continuing.";
            // 
            // classicLabel1
            // 
            this.classicLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel1.Location = new System.Drawing.Point(25, 12);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(274, 13);
            this.classicLabel1.TabIndex = 0;
            this.classicLabel1.Text = "License  Agree m e n t";
            // 
            // classicLabel3
            // 
            this.classicLabel3.Location = new System.Drawing.Point(25, 73);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(457, 26);
            this.classicLabel3.TabIndex = 1;
            this.classicLabel3.Text = "Please read the following license agreement. You must accept the terms of this ag" +
    "reement before continuing with the installation.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(25, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(446, 147);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Silver;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(25, 259);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "I &accept the agreement";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(25, 280);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(167, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "I &do not accept the agreement";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // EULAPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.classicLabel3);
            this.Controls.Add(this.panel1);
            this.Name = "EULAPane";
            this.Size = new System.Drawing.Size(495, 314);
            this.Load += new System.EventHandler(this.DirectoryPane_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicLabel classicLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Engine.UI.ClassicLabel classicLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}
