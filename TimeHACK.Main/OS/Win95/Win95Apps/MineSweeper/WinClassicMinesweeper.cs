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
        public void calculateFormSize(int x, int y)
        {
            panel1.Size = new Size(x * 25, y * 25);
            this.ParentForm.Size = new Size(x * 25 + 45, y * 25 + 100);
            labelTime.Location = new Point(x * 25 - 38, button1.Location.Y);
            button1.PerformClick();
        }
        private void begginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "easy";
            button1.Location = new Point(108, 32);
            calculateFormSize(8, 8);
        }
        private void intermediateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "medium";
            button1.Location = new Point(208, 32);
            calculateFormSize(16, 16);
        }
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = "hard";
            button1.Location = new Point(381, 32);
            calculateFormSize(30, 16);
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
            begginnerToolStripMenuItem.PerformClick();
        }
    }
}
