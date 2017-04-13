namespace TimeHACK.Engine.Template
{
    partial class Win9XBSOD
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(564, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = " Windows ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(120, 294);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(950, 81);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "A fatal exception 0E has occured at 0028:C0034B23.  The current application will " +
    "be terminated.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Blue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(120, 381);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(950, 101);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "*  Press any key to rewind time to before the crash.\r\n*  Press ESC to shutdown yo" +
    "ur computer. You will lose any\r\n   unsaved data in all applications.";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Blue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Perfect DOS VGA 437", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(450, 488);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(382, 34);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Press any key to rewind _";
            // 
            // Win9XBSOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Win9XBSOD";
            this.Text = "Win9XBSOD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}