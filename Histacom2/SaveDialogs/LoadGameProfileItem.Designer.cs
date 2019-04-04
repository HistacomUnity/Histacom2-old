namespace Histacom2
{
    partial class LoadGameProfileItem
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.exampleLoadProfile = new System.Windows.Forms.Button();
            this.exampleDelete = new System.Windows.Forms.Button();
            this.exampleNameBtn = new System.Windows.Forms.Button();
            this.profileName = new System.Windows.Forms.Label();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.sidebar.SuspendLayout();
            this.pnlConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidebar.Controls.Add(this.exampleLoadProfile);
            this.sidebar.Controls.Add(this.exampleDelete);
            this.sidebar.Controls.Add(this.exampleNameBtn);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.Location = new System.Drawing.Point(366, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(129, 134);
            this.sidebar.TabIndex = 2;
            this.sidebar.Visible = false;
            // 
            // exampleLoadProfile
            // 
            this.exampleLoadProfile.BackColor = System.Drawing.Color.Silver;
            this.exampleLoadProfile.FlatAppearance.BorderSize = 0;
            this.exampleLoadProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleLoadProfile.Location = new System.Drawing.Point(4, 5);
            this.exampleLoadProfile.Name = "exampleLoadProfile";
            this.exampleLoadProfile.Size = new System.Drawing.Size(122, 38);
            this.exampleLoadProfile.TabIndex = 0;
            this.exampleLoadProfile.Text = "Load Profile!";
            this.exampleLoadProfile.UseVisualStyleBackColor = true;
            this.exampleLoadProfile.Click += new System.EventHandler(this.exampleLoadProfile_Click);
            // 
            // exampleDelete
            // 
            this.exampleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exampleDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleDelete.Location = new System.Drawing.Point(4, 93);
            this.exampleDelete.Name = "exampleDelete";
            this.exampleDelete.Size = new System.Drawing.Size(122, 38);
            this.exampleDelete.TabIndex = 0;
            this.exampleDelete.Text = "Delete";
            this.exampleDelete.UseVisualStyleBackColor = true;
            this.exampleDelete.Click += new System.EventHandler(this.exampleDelete_Click);
            // 
            // exampleNameBtn
            // 
            this.exampleNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exampleNameBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleNameBtn.Location = new System.Drawing.Point(4, 49);
            this.exampleNameBtn.Name = "exampleNameBtn";
            this.exampleNameBtn.Size = new System.Drawing.Size(122, 38);
            this.exampleNameBtn.TabIndex = 0;
            this.exampleNameBtn.Text = "Change Name";
            this.exampleNameBtn.UseVisualStyleBackColor = true;
            this.exampleNameBtn.Click += new System.EventHandler(this.exampleNameBtn_Click);
            // 
            // profileName
            // 
            this.profileName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.profileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(0, 0);
            this.profileName.Name = "profileName";
            this.profileName.Padding = new System.Windows.Forms.Padding(44);
            this.profileName.Size = new System.Drawing.Size(366, 134);
            this.profileName.TabIndex = 1;
            this.profileName.Text = "Profile Name";
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlConfirm.Controls.Add(this.btnNo);
            this.pnlConfirm.Controls.Add(this.btnYes);
            this.pnlConfirm.Controls.Add(this.lblProfile);
            this.pnlConfirm.Controls.Add(this.txtProfileName);
            this.pnlConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConfirm.Location = new System.Drawing.Point(0, 69);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(366, 65);
            this.pnlConfirm.TabIndex = 1;
            this.pnlConfirm.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(121, 29);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(109, 29);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(7, 29);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(109, 29);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(3, 5);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(357, 21);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Are you really sure you want to delete this Profile?";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(6, 33);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(109, 20);
            this.txtProfileName.TabIndex = 1;
            this.txtProfileName.Visible = false;
            // 
            // LoadGameProfileItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConfirm);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.sidebar);
            this.Name = "LoadGameProfileItem";
            this.Size = new System.Drawing.Size(495, 134);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoadGameProfileItem_Paint);
            this.sidebar.ResumeLayout(false);
            this.pnlConfirm.ResumeLayout(false);
            this.pnlConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button exampleLoadProfile;
        private System.Windows.Forms.Button exampleDelete;
        private System.Windows.Forms.Button exampleNameBtn;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.Panel pnlConfirm;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtProfileName;
    }
}
