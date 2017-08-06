using System;
using System.Drawing;
using System.Windows.Forms;


namespace TimeHACK.OS.Win95.Win95Apps.MineSweeper
{
    public class Game
    {
        public event EventHandler DismantledMinesChanged;
        public event EventHandler Tick;

        private int _dismantledMines;
        private int _height;
        private int _incorrectdismantledMines;
        private int _mines;
        private Panel _panel;
        private Square[,] _squares;
        public Timer _timer;
        private int _width;
        public bool  ftime = true;
        public int Time;
        public bool win = false;

        public Game(Panel panel, int width, int height, int mines)
        {
            _panel = panel;
            _width = width;
            _height = height;
            _mines = mines;
            win = false;
        }

        private void Dismantle(object sender, EventArgs e)
        {

            Square s = (Square)sender;
            if (s.Dismantled)
            {
                if (s.Minded)
                {
                    _dismantledMines++;
                }
                else
                {
                    _incorrectdismantledMines++;
                }
            }
            else
            {
                if (s.Minded)
                {
                    _dismantledMines--;
                }
                else
                {
                    _incorrectdismantledMines--;
                }
            }

            OnDismantledMinesChanged();

            if (_dismantledMines == Mines)
            {
                _timer.Enabled = false;
                Panel.Enabled = false;
                win = true;
            }
        }

        public int DismantledMines
        {
            get { return _dismantledMines + _incorrectdismantledMines; }
        }

        private void Explode(object sender, EventArgs e)
        {
            if (_timer != null) _timer.Enabled = false;
            foreach (Square s in _squares)
            {
                s.RemoveEvents();
                if (s.Minded)
                {
                    s.Button.Text = "*";
                    s.Button.Font = new Font("Arial Black", 16F, FontStyle.Regular, GraphicsUnit.Point, ((System.Byte)(0)));
                    s.Button.ForeColor = Color.Black;
                }
            }
        }

        public int Height
        {
            get { return (this._height); }
        }

        public bool IsBomb(int x, int y)
        {
            if (x >= 0 && x < Width)
            {
                if (y >= 0 && y < Height)
                {
                    return _squares[x, y].Minded;
                }
            }
            return false;
        }

        public int Mines
        {
            get { return (this._mines); }
        }

        protected void OnDismantledMinesChanged()
        {

            if (DismantledMinesChanged != null)
            {
                DismantledMinesChanged(this, new EventArgs());
            }
        }

        protected void OnTick()
        {
            if (Tick != null)
            {
                Tick(this, new EventArgs());
            }
        }

        public void OpenSpot(int x, int y)
        {
            if (x >= 0 && x < Width)
            {
                if (y >= 0 && y < Height)
                {
                    _squares[x, y].Open();
                }
            }
        }

        public Panel Panel
        {
            get { return (this._panel); }
        }

        public void Start()
        {

            //Panel.SuspendLayout();
            Time = 0;
            _dismantledMines = 0;
            _incorrectdismantledMines = 0;
            Panel.Enabled = true;
            Panel.Controls.Clear();

            // Create Spots
            _squares = new Square[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Square s = new Square(this, x, y);
                    s.Explode += new EventHandler(Explode);
                    s.Dismantle += new EventHandler(Dismantle);
                    _squares[x, y] = s;
                }
            }

            // Place Mines
            int b = 0;
            Random r = new Random();
            while (b < Mines)
            {
                int x = r.Next(Width);
                int y = r.Next(Height);

                Square s = _squares[x, y];
                if (!s.Minded)
                {
                    s.Minded = true;
                    b++;
                }
            }

            OnDismantledMinesChanged();
        }

        public void TimerTick(object sender, EventArgs e)
        {
            Time++;
            OnTick();
        }

        public int Width
        {
            get { return (this._width); }
        }
    }
}
