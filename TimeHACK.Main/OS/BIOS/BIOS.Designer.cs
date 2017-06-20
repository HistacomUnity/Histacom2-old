namespace TimeHACK.OS.BIOS
{
    partial class BIOS
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
            this.BIOSConsole = new TimeHACK.OS.Win95.Win95Apps.WinClassicTerminal();
            this.SuspendLayout();
            // 
            // BIOSConsole
            // 
            this.BIOSConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BIOSConsole.Location = new System.Drawing.Point(0, 0);
            this.BIOSConsole.Name = "BIOSConsole";
            this.BIOSConsole.Size = new System.Drawing.Size(528, 305);
            this.BIOSConsole.TabIndex = 0;
            this.BIOSConsole.Load += new System.EventHandler(this.BIOSConsole_Load);
            // 
            // BIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 305);
            this.Controls.Add(this.BIOSConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BIOS";
            this.Text = "BIOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public Win95.Win95Apps.WinClassicTerminal BIOSConsole;
    }
}