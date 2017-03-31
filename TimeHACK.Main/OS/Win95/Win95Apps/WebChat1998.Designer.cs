namespace TimeHACK.OS.Win95.Win95Apps
{
    partial class WebChat1998
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
            this.components = new System.ComponentModel.Container();
            this.Chat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Chat
            // 
            this.Chat.Interval = 15000;
            // 
            // WebChat1998
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WebChat1998";
            this.Size = new System.Drawing.Size(724, 482);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Chat;
    }
}
