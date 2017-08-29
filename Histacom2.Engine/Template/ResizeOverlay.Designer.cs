namespace Histacom2.Engine.Template
{
    partial class ResizeOverlay
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
            this.components = new System.ComponentModel.Container();
            this.outline = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.outline)).BeginInit();
            this.SuspendLayout();
            // 
            // outline
            // 
            this.outline.BackColor = System.Drawing.Color.Transparent;
            this.outline.Location = new System.Drawing.Point(194, 158);
            this.outline.Name = "outline";
            this.outline.Size = new System.Drawing.Size(300, 158);
            this.outline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outline.TabIndex = 0;
            this.outline.TabStop = false;
            this.outline.Paint += new System.Windows.Forms.PaintEventHandler(this.outline_Paint);
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 20;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // ResizeOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.outline);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResizeOverlay";
            this.Tag = "ignoreFormOnTaskbar";
            this.Text = "ResizeOverlay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.outline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox outline;
        public System.Windows.Forms.Timer tmrMove;
    }
}