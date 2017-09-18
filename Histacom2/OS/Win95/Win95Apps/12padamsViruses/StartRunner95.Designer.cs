namespace Histacom2.OS.Win95.Win95Apps._12padamsViruses
{
    partial class StartRunner95
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartRunner95));
            this.classicButton1 = new Histacom2.Engine.UI.ClassicButton();
            this.classicButton2 = new Histacom2.Engine.UI.ClassicButton();
            this.classicButton3 = new Histacom2.Engine.UI.ClassicButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classicButton1
            // 
            this.classicButton1.BackColor = System.Drawing.Color.Silver;
            this.classicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton1.ForeColor = System.Drawing.Color.Black;
            this.classicButton1.Location = new System.Drawing.Point(16, 168);
            this.classicButton1.Name = "classicButton1";
            this.classicButton1.Size = new System.Drawing.Size(75, 23);
            this.classicButton1.TabIndex = 11;
            this.classicButton1.Text = "Infect";
            this.classicButton1.Click += new System.EventHandler(this.classicButton1_Click);
            // 
            // classicButton2
            // 
            this.classicButton2.BackColor = System.Drawing.Color.Silver;
            this.classicButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton2.ForeColor = System.Drawing.Color.Black;
            this.classicButton2.Location = new System.Drawing.Point(97, 168);
            this.classicButton2.Name = "classicButton2";
            this.classicButton2.Size = new System.Drawing.Size(75, 23);
            this.classicButton2.TabIndex = 12;
            this.classicButton2.Text = "Remove";
            this.classicButton2.Click += new System.EventHandler(this.classicButton2_Click);
            // 
            // classicButton3
            // 
            this.classicButton3.BackColor = System.Drawing.Color.Silver;
            this.classicButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton3.ForeColor = System.Drawing.Color.Black;
            this.classicButton3.Location = new System.Drawing.Point(293, 168);
            this.classicButton3.Name = "classicButton3";
            this.classicButton3.Size = new System.Drawing.Size(75, 23);
            this.classicButton3.TabIndex = 13;
            this.classicButton3.Text = "Exit";
            this.classicButton3.Click += new System.EventHandler(this.classicButton3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 117);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // StartRunner95
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.classicButton3);
            this.Controls.Add(this.classicButton2);
            this.Controls.Add(this.classicButton1);
            this.Controls.Add(this.label2);
            this.Name = "StartRunner95";
            this.Size = new System.Drawing.Size(383, 208);
            this.Load += new System.EventHandler(this.StartRunner95_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Engine.UI.ClassicButton classicButton1;
        private Engine.UI.ClassicButton classicButton2;
        private Engine.UI.ClassicButton classicButton3;
        internal System.Windows.Forms.Label label2;
    }
}
