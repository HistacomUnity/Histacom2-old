using TimeHACK.OS.Win95;

namespace TimeHACK.OS.Win95
{
    partial class Windows95
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows95));
            this.panel1.SuspendLayout();
            this.taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).BeginInit();
            this.startmenu.SuspendLayout();
            this.ossidestartmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osimage)).BeginInit();
            this.clockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            // 
            // desktopImages
            // 
            this.desktopImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("desktopImages.ImageStream")));
            this.desktopImages.Images.SetKeyName(0, "WinClassicComputer.png");
            this.desktopImages.Images.SetKeyName(1, "WinClassicFolder.png");
            this.desktopImages.Images.SetKeyName(2, "WinClassicIE4.png");
            this.desktopImages.Images.SetKeyName(3, "WinClassicInbox.png");
            this.desktopImages.Images.SetKeyName(4, "WinClassicMSN.png");
            this.desktopImages.Images.SetKeyName(5, "WinClassicNetworking.png");
            this.desktopImages.Images.SetKeyName(6, "WinClassicOutlook.png");
            this.desktopImages.Images.SetKeyName(7, "WinClassicRecycle.png");
            this.desktopImages.Images.SetKeyName(8, "WinClassicSetup.png");
            this.desktopImages.Images.SetKeyName(9, "WinClassicSetup.png");
            this.desktopImages.Images.SetKeyName(10, "WinClassicSetup.png");
            this.desktopImages.Images.SetKeyName(11, "WinClassicSetup.png");
            // 
            // Windows95
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Windows95";
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.Controls.SetChildIndex(this.desktopicons, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.startmenu, 0);
            this.Controls.SetChildIndex(this.taskbar, 0);
            this.panel1.ResumeLayout(false);
            this.taskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).EndInit();
            this.startmenu.ResumeLayout(false);
            this.startmenu.PerformLayout();
            this.ossidestartmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.osimage)).EndInit();
            this.clockPanel.ResumeLayout(false);
            this.clockPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}