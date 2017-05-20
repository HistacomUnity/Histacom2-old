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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win95TaskBarItem));
            this.progName = new System.Windows.Forms.Label();
            this.progPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.progPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progName
            // 
            this.progName.AutoSize = true;
            this.progName.BackColor = System.Drawing.Color.Transparent;
            this.progName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progName.Location = new System.Drawing.Point(18, 2);
            this.progName.Name = "progName";
            this.progName.Size = new System.Drawing.Size(60, 24);
            this.progName.TabIndex = 1;
            this.progName.Text = "label1";
            this.progName.Click += new System.EventHandler(this.Win95TaskBarItem_Click);
            // 
            // progPic
            // 
            this.progPic.BackColor = System.Drawing.Color.Transparent;
            this.progPic.Location = new System.Drawing.Point(3, 3);
            this.progPic.Name = "progPic";
            this.progPic.Size = new System.Drawing.Size(16, 16);
            this.progPic.TabIndex = 0;
            this.progPic.TabStop = false;
            this.progPic.Click += new System.EventHandler(this.Win95TaskBarItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.progName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 22);
            this.panel1.TabIndex = 2;
            // 
            // Win95TaskBarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progPic);
            this.Controls.Add(this.panel1);
            this.Name = "Win95TaskBarItem";
            this.Size = new System.Drawing.Size(160, 22);
            this.Load += new System.EventHandler(this.Win95TaskBarItem_Load);
            this.Click += new System.EventHandler(this.Win95TaskBarItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.progPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox progPic;
        private System.Windows.Forms.Label progName;
        private System.Windows.Forms.Panel panel1;
    }
}
