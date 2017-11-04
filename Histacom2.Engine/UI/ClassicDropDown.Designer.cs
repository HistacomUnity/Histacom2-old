namespace Histacom2.Engine.UI
{
    partial class ClassicDropDown
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dropDownSwitch = new System.Windows.Forms.PictureBox();
            this.tborder = new System.Windows.Forms.PictureBox();
            this.bborder = new System.Windows.Forms.PictureBox();
            this.rborder = new System.Windows.Forms.PictureBox();
            this.lborder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bborder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rborder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lborder)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 13);
            this.textBox1.TabIndex = 9;
            // 
            // dropDownSwitch
            // 
            this.dropDownSwitch.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropDownSwitch.Image = global::Histacom2.Engine.Properties.Resources.ClassicDropDownButton;
            this.dropDownSwitch.Location = new System.Drawing.Point(82, 2);
            this.dropDownSwitch.Name = "dropDownSwitch";
            this.dropDownSwitch.Size = new System.Drawing.Size(16, 16);
            this.dropDownSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dropDownSwitch.TabIndex = 10;
            this.dropDownSwitch.TabStop = false;
            this.dropDownSwitch.Click += new System.EventHandler(this.dropDownSwitch_Click);
            // 
            // tborder
            // 
            this.tborder.Dock = System.Windows.Forms.DockStyle.Top;
            this.tborder.Location = new System.Drawing.Point(2, 0);
            this.tborder.Name = "tborder";
            this.tborder.Size = new System.Drawing.Size(96, 2);
            this.tborder.TabIndex = 8;
            this.tborder.TabStop = false;
            // 
            // bborder
            // 
            this.bborder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bborder.Location = new System.Drawing.Point(2, 18);
            this.bborder.Name = "bborder";
            this.bborder.Size = new System.Drawing.Size(96, 2);
            this.bborder.TabIndex = 5;
            this.bborder.TabStop = false;
            // 
            // rborder
            // 
            this.rborder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rborder.Location = new System.Drawing.Point(98, 0);
            this.rborder.Name = "rborder";
            this.rborder.Size = new System.Drawing.Size(2, 20);
            this.rborder.TabIndex = 7;
            this.rborder.TabStop = false;
            // 
            // lborder
            // 
            this.lborder.Dock = System.Windows.Forms.DockStyle.Left;
            this.lborder.Location = new System.Drawing.Point(0, 0);
            this.lborder.Name = "lborder";
            this.lborder.Size = new System.Drawing.Size(2, 20);
            this.lborder.TabIndex = 6;
            this.lborder.TabStop = false;
            // 
            // ClassicDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dropDownSwitch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tborder);
            this.Controls.Add(this.bborder);
            this.Controls.Add(this.rborder);
            this.Controls.Add(this.lborder);
            this.Name = "ClassicDropDown";
            this.Size = new System.Drawing.Size(100, 20);
            this.Load += new System.EventHandler(this.ClassicDropDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dropDownSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tborder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bborder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rborder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lborder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox tborder;
        private System.Windows.Forms.PictureBox bborder;
        private System.Windows.Forms.PictureBox rborder;
        private System.Windows.Forms.PictureBox lborder;
        private System.Windows.Forms.PictureBox dropDownSwitch;
    }
}
