namespace Histacom2.OS.Win95.Win95Apps._12padamViruses
{
    partial class ErrorBlaster95
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorBlaster95));
            this.classicButton1 = new Histacom2.Engine.UI.ClassicButton();
            this.classicButton3 = new Histacom2.Engine.UI.ClassicButton();
            this.label1 = new System.Windows.Forms.Label();
            this.classicButton2 = new Histacom2.Engine.UI.ClassicButton();
            this.SuspendLayout();
            // 
            // classicButton1
            // 
            this.classicButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classicButton1.BackColor = System.Drawing.Color.Silver;
            this.classicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton1.ForeColor = System.Drawing.Color.Black;
            this.classicButton1.Location = new System.Drawing.Point(16, 219);
            this.classicButton1.Name = "classicButton1";
            this.classicButton1.Size = new System.Drawing.Size(73, 38);
            this.classicButton1.TabIndex = 18;
            this.classicButton1.Text = "Infect";
            this.classicButton1.Click += new System.EventHandler(this.classicButton1_Click);
            // 
            // classicButton3
            // 
            this.classicButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classicButton3.BackColor = System.Drawing.Color.Silver;
            this.classicButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton3.ForeColor = System.Drawing.Color.Black;
            this.classicButton3.Location = new System.Drawing.Point(353, 219);
            this.classicButton3.Name = "classicButton3";
            this.classicButton3.Size = new System.Drawing.Size(75, 38);
            this.classicButton3.TabIndex = 20;
            this.classicButton3.Text = "Exit";
            this.classicButton3.Click += new System.EventHandler(this.classicButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 169);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // classicButton2
            // 
            this.classicButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classicButton2.BackColor = System.Drawing.Color.Silver;
            this.classicButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton2.ForeColor = System.Drawing.Color.Black;
            this.classicButton2.Location = new System.Drawing.Point(95, 219);
            this.classicButton2.Name = "classicButton2";
            this.classicButton2.Size = new System.Drawing.Size(75, 38);
            this.classicButton2.TabIndex = 19;
            this.classicButton2.Text = "Remove";
            this.classicButton2.Click += new System.EventHandler(this.classicButton2_Click);
            // 
            // ErrorBlaster95
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classicButton3);
            this.Controls.Add(this.classicButton2);
            this.Controls.Add(this.classicButton1);
            this.Name = "ErrorBlaster95";
            this.Size = new System.Drawing.Size(447, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Engine.UI.ClassicButton classicButton1;
        private Engine.UI.ClassicButton classicButton3;
        private System.Windows.Forms.Label label1;
        private Engine.UI.ClassicButton classicButton2;
    }
}
