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
using TimeHACK.Engine;
using System.Threading;

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
            labelBombs.Font = new Font(TitleScreen.pfc.Families[2], 15, GraphicsUnit.Point);
            labelTime.Font = new Font(TitleScreen.pfc.Families[2], 15, GraphicsUnit.Point);
            panel1.Paint += (sender, args) => Paintbrush.PaintClassicBordersIndented(sender, args, 3);
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
            labelTime.Text = "0";
            switch (level)
            {
                case ("easy"):
                    Cursor.Current = Cursors.WaitCursor;
                    _game = new Game(this.panel1, 8, 8, 10);
                    break;
                case ("medium"):
                    Cursor.Current = Cursors.WaitCursor;
                    _game = new Game(this.panel1, 16, 16, 40);
                    break;
                case ("hard"):
                    Cursor.Current = Cursors.WaitCursor;
                    _game = new Game(this.panel1, 30, 16, 99);
                    break;
            }
            _game.Tick += new EventHandler(GameTick);
            _game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged);
            _game.Start();

        }

        private void WinClassicMinesweeper_Load(object sender, EventArgs e)
        {
            begginnerToolStripMenuItem.PerformClick();
            timer1.Start();
        }

        private void bestTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            wm.StartWin95(new MineBestTimes(), "Best Times", null, false, false, true, false);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_game.win == true)
            {
                switch (level)
                {
                    case ("easy"):
                        if (SaveSystem.CurrentSave.mineSweepE > _game.Time) SaveSystem.CurrentSave.mineSweepE = _game.Time;
                        break;
                    case ("medium"):
                        if (SaveSystem.CurrentSave.mineSweepI > _game.Time) SaveSystem.CurrentSave.mineSweepI = _game.Time;
                        break;
                    case ("hard"):
                        if (SaveSystem.CurrentSave.mineSweepH > _game.Time) SaveSystem.CurrentSave.mineSweepH = _game.Time;
                        Thread t = new Thread(Achieve);
                        t.Start();
                        break;

                }
                SaveSystem.SaveGame();
            }
        }

        private void Achieve()
        {
            SaveSystem.SaveAchievement(20);
            new AchievementBox(20);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Achieve);
            t.Start();
            this.ParentForm.Close();
        }
    }
}
