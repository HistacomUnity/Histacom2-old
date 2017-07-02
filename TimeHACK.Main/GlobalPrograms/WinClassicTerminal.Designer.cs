namespace TimeHACK.OS.Win95.Win95Apps
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdPrompt = new System.Windows.Forms.RichTextBox();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.termMax = new System.Windows.Forms.Button();
            this.btnNothing = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.sizeSel = new System.Windows.Forms.ComboBox();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdPrompt
            // 
            this.cmdPrompt.BackColor = System.Drawing.Color.Black;
            this.cmdPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdPrompt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrompt.ForeColor = System.Drawing.Color.White;
            this.cmdPrompt.Location = new System.Drawing.Point(0, 0);
            this.cmdPrompt.Name = "cmdPrompt";
            this.cmdPrompt.ShowSelectionMargin = true;
            this.cmdPrompt.Size = new System.Drawing.Size(459, 262);
            this.cmdPrompt.TabIndex = 0;
            this.cmdPrompt.Text = "";
            this.cmdPrompt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.Silver;
            this.actionPanel.Controls.Add(this.btnFont);
            this.actionPanel.Controls.Add(this.btnCopy);
            this.actionPanel.Controls.Add(this.termMax);
            this.actionPanel.Controls.Add(this.btnNothing);
            this.actionPanel.Controls.Add(this.btnSettings);
            this.actionPanel.Controls.Add(this.btnPaste);
            this.actionPanel.Controls.Add(this.btnMark);
            this.actionPanel.Controls.Add(this.sizeSel);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionPanel.Location = new System.Drawing.Point(0, 0);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(459, 28);
            this.actionPanel.TabIndex = 1;
            // 
            // btnFont
            // 
            this.btnFont.BackgroundImage = global::TimeHACK.Properties.Resources.termFont;
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Location = new System.Drawing.Point(266, 3);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(23, 22);
            this.btnFont.TabIndex = 7;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = global::TimeHACK.Properties.Resources.termCopy;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(126, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(23, 22);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // termMax
            // 
            this.termMax.BackgroundImage = global::TimeHACK.Properties.Resources.termMax;
            this.termMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.termMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termMax.Location = new System.Drawing.Point(180, 3);
            this.termMax.Name = "termMax";
            this.termMax.Size = new System.Drawing.Size(23, 22);
            this.termMax.TabIndex = 5;
            this.termMax.UseVisualStyleBackColor = true;
            this.termMax.Click += new System.EventHandler(this.termMax_Click);
            // 
            // btnNothing
            // 
            this.btnNothing.BackgroundImage = global::TimeHACK.Properties.Resources.termNothing;
            this.btnNothing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNothing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNothing.Location = new System.Drawing.Point(234, 3);
            this.btnNothing.Name = "btnNothing";
            this.btnNothing.Size = new System.Drawing.Size(23, 22);
            this.btnNothing.TabIndex = 4;
            this.btnNothing.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::TimeHACK.Properties.Resources.termSettings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(212, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackgroundImage = global::TimeHACK.Properties.Resources.termPaste;
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Location = new System.Drawing.Point(148, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(23, 22);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnMark
            // 
            this.btnMark.BackgroundImage = global::TimeHACK.Properties.Resources.termMark;
            this.btnMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.Location = new System.Drawing.Point(104, 3);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(23, 22);
            this.btnMark.TabIndex = 1;
            this.btnMark.UseVisualStyleBackColor = true;
            // 
            // sizeSel
            // 
            this.sizeSel.BackColor = System.Drawing.Color.Silver;
            this.sizeSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeSel.FormattingEnabled = true;
            this.sizeSel.Items.AddRange(new object[] {
            "Auto",
            "4 x 6",
            "5 x 12",
            "6 x 8",
            "6 x 12",
            "7 x 12",
            "7 x 14",
            "7 x 15",
            "8 x 8",
            "8 x 12",
            "8 x 16",
            "10 x 18",
            "10 x 20",
            "12 x 16",
            "12 x 22"});
            this.sizeSel.Location = new System.Drawing.Point(4, 4);
            this.sizeSel.Name = "sizeSel";
            this.sizeSel.Size = new System.Drawing.Size(92, 21);
            this.sizeSel.TabIndex = 0;
            // 
            // WinClassicTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.cmdPrompt);
            this.Name = "WinClassicTerminal";
            this.Size = new System.Drawing.Size(459, 262);
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox cmdPrompt;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button termMax;
        private System.Windows.Forms.Button btnNothing;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.ComboBox sizeSel;
    }
}
