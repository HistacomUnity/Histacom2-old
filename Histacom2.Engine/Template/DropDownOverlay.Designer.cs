namespace Histacom2.Engine.Template
{
    partial class DropDownOverlay
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
            this.outline = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // outline
            // 
            this.outline.BackColor = System.Drawing.Color.White;
            this.outline.Location = new System.Drawing.Point(230, 56);
            this.outline.Name = "outline";
            this.outline.Size = new System.Drawing.Size(200, 100);
            this.outline.TabIndex = 0;
            this.outline.Paint += new System.Windows.Forms.PaintEventHandler(this.outline_Paint);
            // 
            // DropDownOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(628, 210);
            this.Controls.Add(this.outline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DropDownOverlay";
            this.Text = "DropDownOverlay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel outline;
    }
}