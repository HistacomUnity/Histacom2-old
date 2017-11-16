namespace Histacom2.OS.Win98.Win98Apps
{
    partial class Win98Welcome
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
            this.classicButton1 = new Histacom2.Engine.UI.ClassicButton();
            this.SuspendLayout();
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
            this.classicButton1.Location = new System.Drawing.Point(393, 293);
            this.classicButton1.Name = "classicButton1";
            this.classicButton1.Size = new System.Drawing.Size(75, 23);
            this.classicButton1.TabIndex = 0;
            this.classicButton1.Text = "&Begin";
            this.classicButton1.Click += new System.EventHandler(this.classicButton1_Click);
            // 
            // Win98Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Histacom2.Properties.Resources.Win98Welcome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.classicButton1);
            this.DoubleBuffered = true;
            this.Name = "Win98Welcome";
            this.Size = new System.Drawing.Size(477, 322);
            this.ResumeLayout(false);

        }

        #endregion

        private Engine.UI.ClassicButton classicButton1;
    }
}
