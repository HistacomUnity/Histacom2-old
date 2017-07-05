namespace TimeHACK
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sidebar.SuspendLayout();
            this.pnlConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Gray;
            this.sidebar.Controls.Add(this.exampleLoadProfile);
            this.sidebar.Controls.Add(this.exampleDelete);
            this.sidebar.Controls.Add(this.exampleNameBtn);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.Location = new System.Drawing.Point(245, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(102, 82);
            this.sidebar.TabIndex = 2;
            this.sidebar.Visible = false;
            // 
            // exampleLoadProfile
            // 
            this.exampleLoadProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exampleLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exampleLoadProfile.Location = new System.Drawing.Point(3, 1);
            this.exampleLoadProfile.Name = "exampleLoadProfile";
            this.exampleLoadProfile.Size = new System.Drawing.Size(94, 23);
            this.exampleLoadProfile.TabIndex = 0;
            this.exampleLoadProfile.Text = "Load Profile!";
            this.exampleLoadProfile.UseVisualStyleBackColor = false;
            this.exampleLoadProfile.Click += new System.EventHandler(this.exampleLoadProfile_Click);
            // 
            // exampleDelete
            // 
            this.exampleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exampleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exampleDelete.Location = new System.Drawing.Point(3, 54);
            this.exampleDelete.Name = "exampleDelete";
            this.exampleDelete.Size = new System.Drawing.Size(93, 23);
            this.exampleDelete.TabIndex = 0;
            this.exampleDelete.Text = "Delete";
            this.exampleDelete.UseVisualStyleBackColor = false;
            this.exampleDelete.Click += new System.EventHandler(this.exampleDelete_Click);
            // 
            // exampleNameBtn
            // 
            this.exampleNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exampleNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exampleNameBtn.Location = new System.Drawing.Point(3, 27);
            this.exampleNameBtn.Name = "exampleNameBtn";
            this.exampleNameBtn.Size = new System.Drawing.Size(93, 23);
            this.exampleNameBtn.TabIndex = 0;
            this.exampleNameBtn.Text = "Change Name";
            this.exampleNameBtn.UseVisualStyleBackColor = false;
            this.exampleNameBtn.Click += new System.EventHandler(this.exampleNameBtn_Click);
            // 
            // profileName
            // 
            this.profileName.BackColor = System.Drawing.Color.Gray;
            this.profileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(0, 0);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(245, 82);
            this.profileName.TabIndex = 1;
            this.profileName.Text = "Profile Name";
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.BackColor = System.Drawing.Color.Gray;
            this.pnlConfirm.Controls.Add(this.button2);
            this.pnlConfirm.Controls.Add(this.button1);
            this.pnlConfirm.Controls.Add(this.label1);
            this.pnlConfirm.Controls.Add(this.textBox1);
            this.pnlConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConfirm.Location = new System.Drawing.Point(0, 32);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(245, 50);
            this.pnlConfirm.TabIndex = 1;
            this.pnlConfirm.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are you really sure you want to delete this Profile?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(10, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(136, 20);
            this.button2.Name = "cancelButton";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // LoadGameProfileItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConfirm);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.sidebar);
            this.Name = "LoadGameProfileItem";
            this.Size = new System.Drawing.Size(347, 82);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
