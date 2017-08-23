namespace TimeHACK.Engine.UI
{
    partial class ClassicButton
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
            this.borderpart = new System.Windows.Forms.Panel();
            this.graystuff = new System.Windows.Forms.Panel();
            this.lessgraystuff = new System.Windows.Forms.Label();
            this.borderpart.SuspendLayout();
            this.graystuff.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderpart
            // 
            this.borderpart.BackColor = System.Drawing.Color.White;
            this.borderpart.Controls.Add(this.graystuff);
            this.borderpart.Location = new System.Drawing.Point(0, 0);
            this.borderpart.Name = "borderpart";
            this.borderpart.Size = new System.Drawing.Size(99, 24);
            this.borderpart.TabIndex = 0;
            // 
            // graystuff
            // 
            this.graystuff.BackColor = System.Drawing.Color.Gray;
            this.graystuff.Controls.Add(this.lessgraystuff);
            this.graystuff.Location = new System.Drawing.Point(1, 1);
            this.graystuff.Name = "graystuff";
            this.graystuff.Size = new System.Drawing.Size(98, 23);
            this.graystuff.TabIndex = 0;
            // 
            // lessgraystuff
            // 
            this.lessgraystuff.BackColor = System.Drawing.Color.Silver;
            this.lessgraystuff.Location = new System.Drawing.Point(0, 0);
            this.lessgraystuff.Margin = new System.Windows.Forms.Padding(0);
            this.lessgraystuff.Name = "lessgraystuff";
            this.lessgraystuff.Size = new System.Drawing.Size(97, 22);
            this.lessgraystuff.TabIndex = 0;
            this.lessgraystuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lessgraystuff.Paint += new System.Windows.Forms.PaintEventHandler(this.lessgraystuff_Paint);
            // 
            // ClassicButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.borderpart);
            this.Name = "ClassicButton";
            this.Size = new System.Drawing.Size(100, 25);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ClassicButton_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClassicButton_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClassicButton_MouseUp);
            this.Resize += new System.EventHandler(this.ClassicButton_Resize);
            this.borderpart.ResumeLayout(false);
            this.graystuff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel borderpart;
        private System.Windows.Forms.Panel graystuff;
        private System.Windows.Forms.Label lessgraystuff;
    }
}
