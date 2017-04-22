namespace TimeHACK.OS.Win95.Win95Apps
{
    partial class WinClassicDownloader
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
            this.components = new System.ComponentModel.Container();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.amountLbl = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.transferLbl = new System.Windows.Forms.Label();
            this.dlTimer = new System.Windows.Forms.Timer(this.components);
            this.dlSpeed = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progBar
            // 
            this.progBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progBar.Location = new System.Drawing.Point(5, 29);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(290, 23);
            this.progBar.TabIndex = 15;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.BackColor = System.Drawing.Color.Transparent;
            this.amountLbl.Location = new System.Drawing.Point(1, 63);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(114, 13);
            this.amountLbl.TabIndex = 14;
            this.amountLbl.Text = "Downloaded 0kb /0kb";
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Location = new System.Drawing.Point(3, 15);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(39, 13);
            this.appName.TabIndex = 11;
            this.appName.Text = "Label2";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(1, 78);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(124, 13);
            this.locationLbl.TabIndex = 13;
            this.locationLbl.Text = "Downloading to Desktop";
            // 
            // transferLbl
            // 
            this.transferLbl.AutoSize = true;
            this.transferLbl.Location = new System.Drawing.Point(0, 94);
            this.transferLbl.Name = "transferLbl";
            this.transferLbl.Size = new System.Drawing.Size(73, 13);
            this.transferLbl.TabIndex = 12;
            this.transferLbl.Text = "Transfer rate: ";
            // 
            // dlTimer
            // 
            this.dlTimer.Interval = 1000;
            this.dlTimer.Tick += new System.EventHandler(this.dlTimer_Tick);
            // 
            // dlSpeed
            // 
            this.dlSpeed.Interval = 750;
            this.dlSpeed.Tick += new System.EventHandler(this.dlSpeed_Tick);
            // 
            // WinClassicDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.transferLbl);
            this.Name = "WinClassicDownloader";
            this.Size = new System.Drawing.Size(408, 132);
            this.Load += new System.EventHandler(this.WinClassicDownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar progBar;
        internal System.Windows.Forms.Label amountLbl;
        internal System.Windows.Forms.Label appName;
        internal System.Windows.Forms.Label locationLbl;
        internal System.Windows.Forms.Label transferLbl;
        private System.Windows.Forms.Timer dlTimer;
        private System.Windows.Forms.Timer dlSpeed;
    }
}
