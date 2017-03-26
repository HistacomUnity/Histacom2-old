namespace TimeHACK
{
    partial class WinClassicNotepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinClassicNotepad));
            this.program = new System.Windows.Forms.Panel();
            this.notepadtextbox = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programtopbar = new System.Windows.Forms.Panel();
            this.maximizebutton = new System.Windows.Forms.PictureBox();
            this.minimizebutton = new System.Windows.Forms.PictureBox();
            this.programname = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.left = new System.Windows.Forms.Panel();
            this.bottom = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.Panel();
            this.program.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.programtopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.notepadtextbox);
            this.program.Controls.Add(this.MenuStrip1);
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
            this.program.Size = new System.Drawing.Size(800, 520);
            this.program.TabIndex = 5;
            // 
            // notepadtextbox
            // 
            this.notepadtextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.notepadtextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notepadtextbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notepadtextbox.Location = new System.Drawing.Point(4, 46);
            this.notepadtextbox.Multiline = true;
            this.notepadtextbox.Name = "notepadtextbox";
            this.notepadtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notepadtextbox.Size = new System.Drawing.Size(792, 470);
            this.notepadtextbox.TabIndex = 1;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Silver;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1,
            this.EditToolStripMenuItem1,
            this.SearchToolStripMenuItem1,
            this.FormatToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(4, 22);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(792, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem1.Text = "File";
            // 
            // EditToolStripMenuItem1
            // 
            this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
            this.EditToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem1.Text = "Edit";
            // 
            // SearchToolStripMenuItem1
            // 
            this.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1";
            this.SearchToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.SearchToolStripMenuItem1.Text = "Search";
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.FormatToolStripMenuItem.Text = "Help";
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
            this.programtopbar.Size = new System.Drawing.Size(792, 18);
            this.programtopbar.TabIndex = 0;
            this.programtopbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.programtopbar_drag);
            // 
            // maximizebutton
            // 
            this.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximizebutton.BackgroundImage = global::TimeHACK.Properties.Resources.WinClassicMax;
            this.maximizebutton.Location = new System.Drawing.Point(757, 2);
            this.maximizebutton.Name = "maximizebutton";
            this.maximizebutton.Size = new System.Drawing.Size(16, 14);
            this.maximizebutton.TabIndex = 6;
            this.maximizebutton.TabStop = false;
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizebutton.BackgroundImage = global::TimeHACK.Properties.Resources.WinClassicMin;
            this.minimizebutton.Location = new System.Drawing.Point(741, 2);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(16, 14);
            this.minimizebutton.TabIndex = 5;
            this.minimizebutton.TabStop = false;
            // 
            // programname
            // 
            this.programname.AutoSize = true;
            this.programname.Font = new System.Drawing.Font(TitleScreen.pfc.Families[0], 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programname.ForeColor = System.Drawing.Color.White;
            this.programname.Location = new System.Drawing.Point(3, 1);
            this.programname.Name = "programname";
            this.programname.Size = new System.Drawing.Size(55, 13);
            this.programname.TabIndex = 3;
            this.programname.Text = "Notepad";
            // 
            // closebutton
            // 
            this.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closebutton.BackgroundImage = global::TimeHACK.Properties.Resources.WinClassicClose;
            this.closebutton.Location = new System.Drawing.Point(775, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(16, 14);
            this.closebutton.TabIndex = 4;
            this.closebutton.TabStop = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // toprightcorner
            // 
            this.toprightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toprightcorner.BackgroundImage")));
            this.toprightcorner.Location = new System.Drawing.Point(796, 0);
            this.toprightcorner.Name = "toprightcorner";
            this.toprightcorner.Size = new System.Drawing.Size(4, 4);
            this.toprightcorner.TabIndex = 6;
            // 
            // bottomrightcorner
            // 
            this.bottomrightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomrightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomrightcorner.BackgroundImage")));
            this.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomrightcorner.Location = new System.Drawing.Point(796, 516);
            this.bottomrightcorner.Name = "bottomrightcorner";
            this.bottomrightcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomrightcorner.TabIndex = 4;
            // 
            // bottomleftcorner
            // 
            this.bottomleftcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomleftcorner.BackgroundImage")));
            this.bottomleftcorner.Location = new System.Drawing.Point(0, 516);
            this.bottomleftcorner.Name = "bottomleftcorner";
            this.bottomleftcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomleftcorner.TabIndex = 2;
            // 
            // topleftcorner
            // 
            this.topleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topleftcorner.BackgroundImage")));
            this.topleftcorner.Location = new System.Drawing.Point(0, 0);
            this.topleftcorner.Name = "topleftcorner";
            this.topleftcorner.Size = new System.Drawing.Size(4, 4);
            this.topleftcorner.TabIndex = 1;
            // 
            // left
            // 
            this.left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left.BackgroundImage")));
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 4);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(4, 512);
            this.left.TabIndex = 3;
            // 
            // bottom
            // 
            this.bottom.BackgroundImage = global::TimeHACK.Properties.Resources.BottomSide;
            this.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 516);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(796, 4);
            this.bottom.TabIndex = 5;
            // 
            // right
            // 
            this.right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right.BackgroundImage")));
            this.right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(796, 4);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(4, 516);
            this.right.TabIndex = 7;
            // 
            // top
            // 
            this.top.BackgroundImage = global::TimeHACK.Properties.Resources.TopSide;
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(800, 4);
            this.top.TabIndex = 8;
            // 
            // WinClassicNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.program);
            this.Font = new System.Drawing.Font(TitleScreen.pfc.Families[0], 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinClassicNotepad";
            this.Text = "WinClassicNotepad";
            this.Load += new System.EventHandler(this.WinClassicNotepad_Load);
            this.program.ResumeLayout(false);
            this.program.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.programtopbar.ResumeLayout(false);
            this.programtopbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel program;
        internal System.Windows.Forms.TextBox notepadtextbox;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
        internal System.Windows.Forms.Panel programtopbar;
        internal System.Windows.Forms.PictureBox maximizebutton;
        internal System.Windows.Forms.PictureBox minimizebutton;
        internal System.Windows.Forms.Label programname;
        internal System.Windows.Forms.PictureBox closebutton;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel bottomrightcorner;
        internal System.Windows.Forms.Panel bottomleftcorner;
        internal System.Windows.Forms.Panel topleftcorner;
        internal System.Windows.Forms.Panel left;
        internal System.Windows.Forms.Panel bottom;
        internal System.Windows.Forms.Panel right;
        internal System.Windows.Forms.Panel top;
    }
}