namespace Histacom2.OS.WinXPBad
{
    partial class WinClassicTimeDistorter3Bad
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
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.buttonXP1 = new PinkieControls.ButtonXP();
            this.buttonXP2 = new PinkieControls.ButtonXP();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // classicLabel1
            // 
            this.classicLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classicLabel1.DropShadow = false;
            this.classicLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel1.Location = new System.Drawing.Point(45, 34);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(262, 120);
            this.classicLabel1.TabIndex = 2;
            this.classicLabel1.Text = "2002";
            // 
            // buttonXP1
            // 
            this.buttonXP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.buttonXP1.DefaultScheme = true;
            this.buttonXP1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonXP1.Hint = "";
            this.buttonXP1.Location = new System.Drawing.Point(28, 186);
            this.buttonXP1.Name = "buttonXP1";
            this.buttonXP1.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
            this.buttonXP1.Size = new System.Drawing.Size(101, 25);
            this.buttonXP1.TabIndex = 3;
            this.buttonXP1.Text = "Travel to 2000";
            this.buttonXP1.Click += new System.EventHandler(this.buttonXP1_Click);
            // 
            // buttonXP2
            // 
            this.buttonXP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.buttonXP2.DefaultScheme = true;
            this.buttonXP2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonXP2.Hint = "";
            this.buttonXP2.Location = new System.Drawing.Point(212, 186);
            this.buttonXP2.Name = "buttonXP2";
            this.buttonXP2.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
            this.buttonXP2.Size = new System.Drawing.Size(101, 25);
            this.buttonXP2.TabIndex = 4;
            this.buttonXP2.Text = "Travel to 2001";
            this.buttonXP2.Click += new System.EventHandler(this.buttonXP2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Countdown:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "60";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Year:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinClassicTimeDistorter3Bad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonXP2);
            this.Controls.Add(this.buttonXP1);
            this.Controls.Add(this.classicLabel1);
            this.Name = "WinClassicTimeDistorter3Bad";
            this.Size = new System.Drawing.Size(340, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Engine.UI.ClassicLabel classicLabel1;
        private PinkieControls.ButtonXP buttonXP1;
        private PinkieControls.ButtonXP buttonXP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
