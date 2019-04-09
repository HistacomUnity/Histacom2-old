namespace Histacom2.OS.Win98.Win98Apps
{
    partial class WinClassicTimeDistorter2
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
            this.classicButton1 = new Histacom2.Engine.UI.ClassicButton();
            this.classicLabel1 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel2 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel3 = new Histacom2.Engine.UI.ClassicLabel();
            this.classicLabel4 = new Histacom2.Engine.UI.ClassicLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // classicButton1
            // 
            this.classicButton1.AdaptBackColorWithTheme = true;
            this.classicButton1.AdaptFontWithTheme = false;
            this.classicButton1.AdaptForeColorWithTheme = true;
            this.classicButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.classicButton1.BackColor = System.Drawing.Color.Silver;
            this.classicButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.classicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.classicButton1.ForeColor = System.Drawing.Color.Black;
            this.classicButton1.Location = new System.Drawing.Point(21, 174);
            this.classicButton1.Name = "classicButton1";
            this.classicButton1.Size = new System.Drawing.Size(276, 23);
            this.classicButton1.TabIndex = 0;
            this.classicButton1.Text = "Take me to 2000!";
            this.classicButton1.Click += new System.EventHandler(this.classicButton1_Click);
            // 
            // classicLabel1
            // 
            this.classicLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classicLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel1.Location = new System.Drawing.Point(25, 34);
            this.classicLabel1.Name = "classicLabel1";
            this.classicLabel1.Size = new System.Drawing.Size(270, 120);
            this.classicLabel1.TabIndex = 1;
            this.classicLabel1.Text = "1999";
            // 
            // classicLabel2
            // 
            this.classicLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classicLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel2.Location = new System.Drawing.Point(104, 13);
            this.classicLabel2.Name = "classicLabel2";
            this.classicLabel2.Size = new System.Drawing.Size(108, 18);
            this.classicLabel2.TabIndex = 2;
            this.classicLabel2.Text = "Current Year:";
            // 
            // classicLabel3
            // 
            this.classicLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.classicLabel3.Location = new System.Drawing.Point(24, 154);
            this.classicLabel3.Name = "classicLabel3";
            this.classicLabel3.Size = new System.Drawing.Size(289, 13);
            this.classicLabel3.TabIndex = 3;
            this.classicLabel3.Text = "Click the button to take a one-way trip to the year 2000!";
            // 
            // classicLabel4
            // 
            this.classicLabel4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel4.Location = new System.Drawing.Point(21, 177);
            this.classicLabel4.Name = "classicLabel4";
            this.classicLabel4.Size = new System.Drawing.Size(276, 17);
            this.classicLabel4.TabIndex = 4;
            this.classicLabel4.Text = "Preparing to travel. ETA: N/A secs.";
            this.classicLabel4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WinClassicTimeDistorter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.classicLabel4);
            this.Controls.Add(this.classicLabel3);
            this.Controls.Add(this.classicLabel2);
            this.Controls.Add(this.classicLabel1);
            this.Controls.Add(this.classicButton1);
            this.Name = "WinClassicTimeDistorter2";
            this.Size = new System.Drawing.Size(313, 211);
            this.ResumeLayout(false);

        }

        #endregion

        private Engine.UI.ClassicButton classicButton1;
        public Engine.UI.ClassicLabel classicLabel1;
        private Engine.UI.ClassicLabel classicLabel3;
        public Engine.UI.ClassicLabel classicLabel4;
        private System.Windows.Forms.Timer timer1;
        public Engine.UI.ClassicLabel classicLabel2;
    }
}