namespace TimeHACK.OS.Win2K.Win2KApps
{
    partial class SurviveTheDay
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
            this.words = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gameoverlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // words
            // 
            this.words.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.words.ForeColor = System.Drawing.Color.White;
            this.words.Location = new System.Drawing.Point(35, 35);
            this.words.Name = "words";
            this.words.Size = new System.Drawing.Size(568, 149);
            this.words.TabIndex = 2;
            this.words.Text = "Welcome to Survive The Day.\r\nYour goal is simple.\r\nMake it from 4 AM to midnight " +
    "without dying.\r\nThe time will be displayed in the bottom right corner.\r\nGood luc" +
    "k... you WILL need it.";
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Red;
            this.time.Location = new System.Drawing.Point(514, 409);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(89, 19);
            this.time.TabIndex = 3;
            this.time.Text = "--:-- --";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(568, 28);
            this.button1.TabIndex = 4;
            this.button1.Tag = "start";
            this.button1.Text = "Play";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.choice_click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(35, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(568, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "--";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.choice_click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Courier New", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(35, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(568, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "--";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.choice_click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Courier New", 12F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(35, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(568, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "--";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.choice_click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Courier New", 12F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(35, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(568, 28);
            this.button5.TabIndex = 8;
            this.button5.Text = "--";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.choice_click);
            // 
            // gameoverlbl
            // 
            this.gameoverlbl.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.gameoverlbl.ForeColor = System.Drawing.Color.Red;
            this.gameoverlbl.Location = new System.Drawing.Point(35, 192);
            this.gameoverlbl.Name = "gameoverlbl";
            this.gameoverlbl.Size = new System.Drawing.Size(568, 21);
            this.gameoverlbl.TabIndex = 10;
            this.gameoverlbl.Text = "GAME OVER: No death, this shouldn\'t show in game!";
            this.gameoverlbl.Visible = false;
            // 
            // SurviveTheDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gameoverlbl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.words);
            this.Name = "SurviveTheDay";
            this.Size = new System.Drawing.Size(635, 459);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label words;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label gameoverlbl;
        private System.Windows.Forms.Timer timer1;
    }
}
