namespace TimeHACK.Engine.Template
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoText = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.programContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programContent
            // 
            this.programContent.BackColor = System.Drawing.Color.Silver;
            this.programContent.Controls.Add(this.pictureBox1);
            this.programContent.Controls.Add(this.panel1);
            this.programContent.Controls.Add(this.ok);
            this.programContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programContent.Location = new System.Drawing.Point(0, 0);
            this.programContent.Name = "programContent";
            this.programContent.Size = new System.Drawing.Size(421, 164);
            this.programContent.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::TimeHACK.Engine.Properties.Resources.Win95Warning;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoText);
            this.panel1.Location = new System.Drawing.Point(57, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 96);
            this.panel1.TabIndex = 2;
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoText.Location = new System.Drawing.Point(0, 0);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(35, 13);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "label1";
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok.Location = new System.Drawing.Point(169, 135);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(83, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Infobox95
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.programContent);
            this.Name = "Infobox95";
            this.Size = new System.Drawing.Size(421, 164);
            this.programContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel programContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button ok;
    }
}