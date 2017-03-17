namespace TimeHACK.WinClassicForms
{
    partial class WinClassicTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinClassicTerminal));
            this.top = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Panel();
            this.bottom = new System.Windows.Forms.Panel();
            this.left = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.programtopbar = new System.Windows.Forms.Panel();
            this.maximizebutton = new System.Windows.Forms.PictureBox();
            this.minimizebutton = new System.Windows.Forms.PictureBox();
            this.programname = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.program = new System.Windows.Forms.Panel();
            this.consoleText = new System.Windows.Forms.TextBox();
            this.programtopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            this.program.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackgroundImage = global::TimeHACK.Properties.Resources.TopSide;
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(492, 4);
            this.top.TabIndex = 8;
            // 
            // right
            // 
            this.right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right.BackgroundImage")));
            this.right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(488, 4);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(4, 255);
            this.right.TabIndex = 7;
            // 
            // bottom
            // 
            this.bottom.BackgroundImage = global::TimeHACK.Properties.Resources.BottomSide;
            this.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 255);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(488, 4);
            this.bottom.TabIndex = 5;
            // 
            // left
            // 
            this.left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left.BackgroundImage")));
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 4);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(4, 251);
            this.left.TabIndex = 3;
            // 
            // topleftcorner
            // 
            this.topleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topleftcorner.BackgroundImage")));
            this.topleftcorner.Location = new System.Drawing.Point(0, 0);
            this.topleftcorner.Name = "topleftcorner";
            this.topleftcorner.Size = new System.Drawing.Size(4, 4);
            this.topleftcorner.TabIndex = 1;
            // 
            // bottomleftcorner
            // 
            this.bottomleftcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomleftcorner.BackgroundImage")));
            this.bottomleftcorner.Location = new System.Drawing.Point(0, 255);
            this.bottomleftcorner.Name = "bottomleftcorner";
            this.bottomleftcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomleftcorner.TabIndex = 2;
            // 
            // bottomrightcorner
            // 
            this.bottomrightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomrightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomrightcorner.BackgroundImage")));
            this.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomrightcorner.Location = new System.Drawing.Point(488, 255);
            this.bottomrightcorner.Name = "bottomrightcorner";
            this.bottomrightcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomrightcorner.TabIndex = 4;
            // 
            // toprightcorner
            // 
            this.toprightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toprightcorner.BackgroundImage")));
            this.toprightcorner.Location = new System.Drawing.Point(488, 0);
            this.toprightcorner.Name = "toprightcorner";
            this.toprightcorner.Size = new System.Drawing.Size(4, 4);
            this.toprightcorner.TabIndex = 6;
            // 
            // programtopbar
            // 
            this.programtopbar.BackColor = System.Drawing.Color.DarkBlue;
            this.programtopbar.Controls.Add(this.maximizebutton);
            this.programtopbar.Controls.Add(this.minimizebutton);
            this.programtopbar.Controls.Add(this.programname);
            this.programtopbar.Controls.Add(this.closebutton);
            this.programtopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.programtopbar.Location = new System.Drawing.Point(4, 4);
            this.programtopbar.Name = "programtopbar";
            this.programtopbar.Size = new System.Drawing.Size(484, 18);
            this.programtopbar.TabIndex = 0;
            // 
            // maximizebutton
            // 
            this.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximizebutton.BackgroundImage = global::TimeHACK.Properties.Resources.WinClassicMax;
            this.maximizebutton.Location = new System.Drawing.Point(449, 2);
            this.maximizebutton.Name = "maximizebutton";
            this.maximizebutton.Size = new System.Drawing.Size(16, 14);
            this.maximizebutton.TabIndex = 6;
            this.maximizebutton.TabStop = false;
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizebutton.BackgroundImage = global::TimeHACK.Properties.Resources.WinClassicMin;
            this.minimizebutton.Location = new System.Drawing.Point(433, 2);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(16, 14);
            this.minimizebutton.TabIndex = 5;
            this.minimizebutton.TabStop = false;
            // 
            // programname
            // 
            this.programname.AutoSize = true;
            this.programname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programname.ForeColor = System.Drawing.Color.White;
            this.programname.Location = new System.Drawing.Point(3, 2);
            this.programname.Name = "programname";
            this.programname.Size = new System.Drawing.Size(98, 13);
            this.programname.TabIndex = 3;
            this.programname.Text = "MS-DOS Prompt";
            // 
            // closebutton
            // 
            this.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closebutton.BackgroundImage = global::TimeHACK.Properties.Resources.WinClassicClose;
            this.closebutton.Location = new System.Drawing.Point(467, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(16, 14);
            this.closebutton.TabIndex = 4;
            this.closebutton.TabStop = false;
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.consoleText);
            this.program.Controls.Add(this.programtopbar);
            this.program.Controls.Add(this.toprightcorner);
            this.program.Controls.Add(this.bottomrightcorner);
            this.program.Controls.Add(this.bottomleftcorner);
            this.program.Controls.Add(this.topleftcorner);
            this.program.Controls.Add(this.left);
            this.program.Controls.Add(this.bottom);
            this.program.Controls.Add(this.right);
            this.program.Controls.Add(this.top);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(492, 259);
            this.program.TabIndex = 8;
            // 
            // consoleText
            // 
            this.consoleText.BackColor = System.Drawing.Color.Black;
            this.consoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.consoleText.Location = new System.Drawing.Point(4, 26);
            this.consoleText.Multiline = true;
            this.consoleText.Name = "consoleText";
            this.consoleText.ReadOnly = true;
            this.consoleText.Size = new System.Drawing.Size(484, 229);
            this.consoleText.TabIndex = 9;
            this.consoleText.Text = "Microsoft(R) Windows 95\r\n          (C)Copyright Microsoft Corp 1981-1998.\r\n\r\nC:\\W" +
    "INDOWS>";
            // 
            // WinClassicTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 259);
            this.Controls.Add(this.program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinClassicTerminal";
            this.Text = "WinClassicTerminal";
            this.programtopbar.ResumeLayout(false);
            this.programtopbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            this.program.ResumeLayout(false);
            this.program.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel top;
        internal System.Windows.Forms.Panel right;
        internal System.Windows.Forms.Panel bottom;
        internal System.Windows.Forms.Panel left;
        internal System.Windows.Forms.Panel topleftcorner;
        internal System.Windows.Forms.Panel bottomleftcorner;
        internal System.Windows.Forms.Panel bottomrightcorner;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel programtopbar;
        internal System.Windows.Forms.PictureBox maximizebutton;
        internal System.Windows.Forms.PictureBox minimizebutton;
        internal System.Windows.Forms.Label programname;
        internal System.Windows.Forms.PictureBox closebutton;
        internal System.Windows.Forms.Panel program;
        private System.Windows.Forms.TextBox consoleText;
    }
}