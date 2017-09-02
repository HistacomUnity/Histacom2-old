namespace Histacom2.OS.Win95.Win95Apps
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
            this.amountLbl = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.transferLbl = new System.Windows.Forms.Label();
            this.dlTimer = new System.Windows.Forms.Timer(this.components);
            this.dlSpeed = new System.Windows.Forms.Timer(this.components);
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new Histacom2.UI.ProgressBar();
            this.SuspendLayout();
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
            // progBar
            // 
            this.progBar.BackColor = System.Drawing.Color.Silver;
            this.progBar.ForeColor = System.Drawing.Color.Navy;
            this.progBar.Location = new System.Drawing.Point(6, 32);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(399, 23);
            this.progBar.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.BlockSpacing = 5;
            this.progressBar1.BlockWidth = 20;
            this.progressBar1.Location = new System.Drawing.Point(6, 32);
            this.progressBar1.MarqueeWidth = 125;
            this.progressBar1.Maximum = 100D;
            this.progressBar1.Minimum = 0D;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.DarkBlue;
            this.progressBar1.ShowText = false;
            this.progressBar1.Size = new System.Drawing.Size(399, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Text = "progressBar1";
            this.progressBar1.Value = 0D;
            // 
            // WinClassicDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.progressBar1);
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
        internal System.Windows.Forms.Label amountLbl;
        internal System.Windows.Forms.Label appName;
        internal System.Windows.Forms.Label locationLbl;
        internal System.Windows.Forms.Label transferLbl;
        private System.Windows.Forms.Timer dlTimer;
        private System.Windows.Forms.Timer dlSpeed;
        private System.Windows.Forms.ProgressBar progBar;
        private UI.ProgressBar progressBar1;
    }
}
