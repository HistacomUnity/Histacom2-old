namespace TimeHACK
{
    partial class TitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            this.gameversion = new System.Windows.Forms.Label();
            this.vm_mode = new System.Windows.Forms.CheckBox();
            this.vmModeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VM_Height = new System.Windows.Forms.NumericUpDown();
            this.VM_Width = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startbutton = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // gameversion
            // 
            this.gameversion.AutoSize = true;
            this.gameversion.BackColor = System.Drawing.Color.Transparent;
            this.gameversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameversion.Location = new System.Drawing.Point(25, 6);
            this.gameversion.Name = "gameversion";
            this.gameversion.Size = new System.Drawing.Size(78, 13);
            this.gameversion.TabIndex = 0;
            this.gameversion.Text = "gameversion";
            this.gameversion.MouseLeave += new System.EventHandler(this.gameversion_MouseLeave);
            this.gameversion.MouseHover += new System.EventHandler(this.gameversion_MouseHover);
            this.gameversion.Click += new System.EventHandler(this.startbutton_Click);
            // vm_mode
            // 
            this.vm_mode.AutoSize = true;
            this.vm_mode.BackColor = System.Drawing.Color.Transparent;
            this.vm_mode.ForeColor = System.Drawing.Color.Black;
            this.vm_mode.Location = new System.Drawing.Point(724, 7);
            this.vm_mode.Name = "vm_mode";
            this.vm_mode.Size = new System.Drawing.Size(72, 17);
            this.vm_mode.TabIndex = 4;
            this.vm_mode.Text = "VM Mode";
            this.vm_mode.UseVisualStyleBackColor = false;
            // 
            // vmModeTimer
            // 
            this.vmModeTimer.Tick += new System.EventHandler(this.vmModeTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 345);
            this.panel1.TabIndex = 9;
            // 
            // LoadGame
            // 
            this.LoadGame.BackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatAppearance.BorderSize = 0;
            this.LoadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadGame.Image = ((System.Drawing.Image)(resources.GetObject("LoadGame.Image")));
            this.LoadGame.Location = new System.Drawing.Point(275, 363);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(246, 188);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.UseVisualStyleBackColor = false;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            this.LoadGame.MouseEnter += new System.EventHandler(this.LoadGame_Enter);
            this.LoadGame.MouseLeave += new System.EventHandler(this.LoadGame_Leave);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(542, 363);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(246, 188);
            this.Exit.TabIndex = 3;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_Enter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_Leave);
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatAppearance.BorderSize = 0;
            this.NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame.Image = ((System.Drawing.Image)(resources.GetObject("NewGame.Image")));
            this.NewGame.Location = new System.Drawing.Point(6, 363);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(246, 188);
            this.NewGame.TabIndex = 1;
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            this.NewGame.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.NewGame.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.VM_Height);
            this.panel2.Controls.Add(this.VM_Width);
            this.panel2.Controls.Add(this.vm_mode);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.gameversion);
            this.panel2.Controls.Add(this.startbutton);
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 28);
            this.panel2.TabIndex = 10;
            // 
            // VM_Height
            // 
            this.VM_Height.Location = new System.Drawing.Point(668, 5);
            this.VM_Height.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.VM_Height.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.VM_Height.Name = "VM_Height";
            this.VM_Height.Size = new System.Drawing.Size(50, 20);
            this.VM_Height.TabIndex = 15;
            this.VM_Height.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // VM_Width
            // 
            this.VM_Width.Location = new System.Drawing.Point(612, 5);
            this.VM_Width.Maximum = new decimal(new int[] {
            3840,
            0,
            0,
            0});
            this.VM_Width.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.VM_Width.Name = "VM_Width";
            this.VM_Width.Size = new System.Drawing.Size(50, 20);
            this.VM_Width.TabIndex = 14;
            this.VM_Width.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 28);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // startbutton
            // 
            this.startbutton.Image = ((System.Drawing.Image)(resources.GetObject("startbutton.Image")));
            this.startbutton.Location = new System.Drawing.Point(2, 4);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(279, 22);
            this.startbutton.TabIndex = 12;
            this.startbutton.TabStop = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TitleScreen";
            this.Tag = "ignoreFormOnTaskbar";
            this.Text = "TimeHACK Launcher";
            this.Load += new System.EventHandler(this.TitleScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label gameversion;
        private System.Windows.Forms.CheckBox vm_mode;
        private System.Windows.Forms.Timer vmModeTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox startbutton;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown VM_Height;
        private System.Windows.Forms.NumericUpDown VM_Width;
    }
}