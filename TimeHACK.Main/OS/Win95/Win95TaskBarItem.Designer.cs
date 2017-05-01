namespace TimeHACK.Engine.Template.Taskbars
{
    partial class Win95TaskBarItem
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
            this.progPic = new System.Windows.Forms.PictureBox();
            this.progName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progPic)).BeginInit();
            this.SuspendLayout();
            // 
            // progPic
            // 
            this.progPic.Location = new System.Drawing.Point(3, 3);
            this.progPic.Name = "progPic";
            this.progPic.Size = new System.Drawing.Size(28, 24);
            this.progPic.TabIndex = 0;
            this.progPic.TabStop = false;
            this.progPic.Click += new System.EventHandler(this.Win95TaskBarItem_Click);
            // 
            // progName
            // 
            this.progName.AutoSize = true;
            this.progName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progName.Location = new System.Drawing.Point(37, 3);
            this.progName.Name = "progName";
            this.progName.Size = new System.Drawing.Size(60, 24);
            this.progName.TabIndex = 1;
            this.progName.Text = "label1";
            this.progName.Click += new System.EventHandler(this.Win95TaskBarItem_Click);
            // 
            // Win95TaskBarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progName);
            this.Controls.Add(this.progPic);
            this.Name = "Win95TaskBarItem";
            this.Size = new System.Drawing.Size(193, 30);
            this.Load += new System.EventHandler(this.Win95TaskBarItem_Load);
            this.Click += new System.EventHandler(this.Win95TaskBarItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.progPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox progPic;
        private System.Windows.Forms.Label progName;
    }
}
