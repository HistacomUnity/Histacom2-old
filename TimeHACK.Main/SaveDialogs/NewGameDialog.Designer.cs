namespace TimeHACK
{
    partial class NewGameDialog
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
            this.txtProfName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCancl = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDevMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProfName
            // 
            this.txtProfName.Location = new System.Drawing.Point(87, 12);
            this.txtProfName.Name = "txtProfName";
            this.txtProfName.Size = new System.Drawing.Size(370, 20);
            this.txtProfName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile Name (username):";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(382, 70);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(301, 70);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCancl
            // 
            this.btnCancl.Location = new System.Drawing.Point(220, 70);
            this.btnCancl.Name = "btnCancl";
            this.btnCancl.Size = new System.Drawing.Size(75, 23);
            this.btnCancl.TabIndex = 2;
            this.btnCancl.Text = "Cancel";
            this.btnCancl.UseVisualStyleBackColor = true;
            this.btnCancl.Click += new System.EventHandler(this.btnCancl_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(7, 70);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(121, 23);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Technical Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDevMode
            // 
            this.btnDevMode.Location = new System.Drawing.Point(7, 41);
            this.btnDevMode.Name = "btnDevMode";
            this.btnDevMode.Size = new System.Drawing.Size(121, 23);
            this.btnDevMode.TabIndex = 3;
            this.btnDevMode.Text = "What is DevMode?";
            this.btnDevMode.UseVisualStyleBackColor = true;
            this.btnDevMode.Visible = false;
            this.btnDevMode.Click += new System.EventHandler(this.btnDevMode_Click);
            // 
            // NewGameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 96);
            this.Controls.Add(this.btnDevMode);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCancl);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGameDialog";
            this.Tag = "ignoreFormOnTaskbar";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGameDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProfName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCancl;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDevMode;
    }
}