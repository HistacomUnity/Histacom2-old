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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                Cursor.Current = Cursors.WaitCursor;
                _game = new Game(this.panel1, 8, 8, 10);
                _game.Tick += new EventHandler(GameTick);
                _game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged);
                _game.Start();
        }
    }
}
