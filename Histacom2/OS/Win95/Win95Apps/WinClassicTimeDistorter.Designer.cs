namespace Histacom2.OS.Win95
{
    partial class WinClassicTimeDistorter
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
            this.lblDest = new System.Windows.Forms.Label();
            this.lblDestYear = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnGo = new Histacom2.Engine.UI.ClassicButton();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDest
            // 
            this.lblDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDest.Location = new System.Drawing.Point(286, 6);
            this.lblDest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(168, 25);
            this.lblDest.TabIndex = 0;
            this.lblDest.Text = "Destination year";
            this.lblDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestYear
            // 
            this.lblDestYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDestYear.AutoSize = true;
            this.lblDestYear.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDestYear.Location = new System.Drawing.Point(333, 32);
            this.lblDestYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestYear.Name = "lblDestYear";
            this.lblDestYear.Size = new System.Drawing.Size(61, 33);
            this.lblDestYear.TabIndex = 1;
            this.lblDestYear.Text = "null";
            this.lblDestYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrent.Location = new System.Drawing.Point(8, 6);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(131, 25);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current year";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.Location = new System.Drawing.Point(29, 32);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 33);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "null";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(151, 43);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(135, 20);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = ">>>>>>>>>>>>>>\r\n";
            // 
            // btnGo
            // 
            this.btnGo.AdaptBackColorWithTheme = true;
            this.btnGo.AdaptFontWithTheme = true;
            this.btnGo.AdaptForeColorWithTheme = true;
            this.btnGo.BackColor = System.Drawing.Color.Silver;
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(155, 133);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(131, 23);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go To Destination Year";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblCountDown
            // 
            this.lblCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountDown.Location = new System.Drawing.Point(0, 88);
            this.lblCountDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(464, 25);
            this.lblCountDown.TabIndex = 8;
            this.lblCountDown.Text = "null";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCountDown.Visible = false;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // WinClassicTimeDistorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblDestYear);
            this.Controls.Add(this.lblTo);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "WinClassicTimeDistorter";
            this.Size = new System.Drawing.Size(464, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblYear;
        internal System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer countDownTimer;
        internal Histacom2.Engine.UI.ClassicButton btnGo;
        internal System.Windows.Forms.Label lblTo;
        internal System.Windows.Forms.Label lblDestYear;
    }
}
