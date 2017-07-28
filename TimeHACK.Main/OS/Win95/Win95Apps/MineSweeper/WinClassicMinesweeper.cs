using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.OS.Win95.Win95Apps.MineSweeper;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicMinesweeper : UserControl
    {
        private Game _game;
        public int currentface = 1;
        public string level = "easy";
        public WinClassicMinesweeper()
        {
            InitializeComponent();
        }
        private void GameTick(object sender, EventArgs e)
        {
            labelTime.Text = _game.Time.ToString();
        }

        private void GameDismantledMinesChanged(object sender, EventArgs e)
        {
            labelBombs.Text = (_game.Mines - _game.DismantledMines).ToString();
        }
        private void begginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "easy";
            panel1.Size = new Size(200, 200);
            this.ParentForm.Size = new Size(240, 275);
            button1.Location = new Point(108, 32);
            labelTime.Location = new Point(162, 34);
            button1.PerformClick();
        }
        private void intermediateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "medium";
            panel1.Size = new Size(400,400);
            this.ParentForm.Size = new Size(440, 480);
            button1.Location = new Point(208, 32);
            labelTime.Location = new Point(362, 34);
            button1.PerformClick();
        }
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "hard";
            panel1.Size = new Size(740, 400);
            this.ParentForm.Size = new Size(776, 480);
            button1.Location = new Point(381, 32);
            labelTime.Location = new Point(702, 34);
            button1.PerformClick();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (level)
            {
                case ("easy"):
                    Cursor.Current = Cursors.WaitCursor;
                    _game = new Game(this.panel1, 8, 8, 10);
                    _game.Tick += new EventHandler(GameTick);
                    _game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged);
                    _game.Start();
                    return;
                case ("medium"):
                    Cursor.Current = Cursors.WaitCursor;
                    _game = new Game(this.panel1, 16, 16, 46);
                    _game.Tick += new EventHandler(GameTick);
                    _game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged);
                    _game.Start();
                    return;
                case ("hard"):
                    Cursor.Current = Cursors.WaitCursor;
                    _game = new Game(this.panel1, 30, 16, 99);
                    _game.Tick += new EventHandler(GameTick);
                    _game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged);
                    _game.Start();
                    return;
            }

        }

        private void WinClassicMinesweeper_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
