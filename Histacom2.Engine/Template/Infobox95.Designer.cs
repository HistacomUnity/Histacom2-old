namespace Histacom2.Engine.Template
{
    partial class Infobox95
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
            this.programContent = new System.Windows.Forms.Panel();
            this.button1 = new Histacom2.Engine.UI.ClassicButton();
            this.button3 = new Histacom2.Engine.UI.ClassicButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoText = new System.Windows.Forms.Label();
            this.button2 = new Histacom2.Engine.UI.ClassicButton();
            this.programContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programContent
            // 
            this.programContent.BackColor = System.Drawing.Color.Silver;
            this.programContent.Controls.Add(this.button1);
            this.programContent.Controls.Add(this.button3);
            this.programContent.Controls.Add(this.pictureBox1);
            this.programContent.Controls.Add(this.panel1);
            this.programContent.Controls.Add(this.button2);
            this.programContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programContent.Location = new System.Drawing.Point(0, 0);
            this.programContent.Name = "programContent";
            this.programContent.Size = new System.Drawing.Size(413, 118);
            this.programContent.TabIndex = 10;
            this.programContent.Tag = "gnoreFormOnTaskbar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(150, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yes";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(323, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Histacom2.Engine.Properties.Resources.Win95Warning;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoText);
            this.panel1.Location = new System.Drawing.Point(62, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 62);
            this.panel1.TabIndex = 2;
            // 
            // infoText
            // 
            this.infoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoText.Location = new System.Drawing.Point(0, 0);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(341, 62);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "label1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(237, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "No";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Infobox95
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.programContent);
            this.Name = "Infobox95";
            this.Size = new System.Drawing.Size(413, 118);
            this.programContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel programContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label infoText;
        private UI.ClassicButton button1;
        private UI.ClassicButton button2;
        private UI.ClassicButton button3;
    }
}