using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK.OS.Win95.Win95Apps.MineSweeper
{
    class Square
    {
        public event EventHandler Dismantle;
        public event EventHandler Explode;

        private Button _button;
        private bool _dismantled = false;
        private Game _game;
        private bool _minded = false;
        private bool _opened = false;
        private bool _exploded = false;
        private int _x;
        private int _y;

        public Square(Game game, int x, int y)
        {
            _game = game;
            _x = x;
            _y = y;
            _button = new Button();
            Button.Text = "";

            int w = _game.Panel.Width / _game.Width;
            int h = _game.Panel.Height / _game.Height;

            _button.Width = 16;
            _button.Height = 16;
            _button.Left = w * X;
            _button.Top = h * Y;
            _button.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            _button.Click += new EventHandler(Click);
            _button.MouseDown += new MouseEventHandler(DismantleClick);
            _button.MouseUp += new MouseEventHandler(MiddleClick);
            _button.FlatStyle = FlatStyle.Flat;
            _button.FlatAppearance.BorderSize = 0;
            _button.BackgroundImage = Properties.Resources.minesweepSquare;
            _button.BackgroundImageLayout = ImageLayout.Stretch;

            _game.Panel.Controls.Add(Button);
        }

        private void MiddleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && Opened)
            {
                int c = 0;
                if (_game.IsBomb(X - 1, Y - 1)) c++;
                if (_game.IsBomb(X - 0, Y - 1)) c++;
                if (_game.IsBomb(X + 1, Y - 1)) c++;
                if (_game.IsBomb(X - 1, Y - 0)) c++;
                if (_game.IsBomb(X + 1, Y - 0)) c++;
                if (_game.IsBomb(X - 1, Y + 1)) c++;
                if (_game.IsBomb(X - 0, Y + 1)) c++;
                if (_game.IsBomb(X + 1, Y + 1)) c++;

                int s = 0;
                if (_game.IsDismantled(X - 1, Y - 1) && _game.IsBomb(X - 1, Y - 1)) s++;
                if (_game.IsDismantled(X - 0, Y - 1) && _game.IsBomb(X - 0, Y - 1)) s++;
                if (_game.IsDismantled(X + 1, Y - 1) && _game.IsBomb(X + 1, Y - 1)) s++;
                if (_game.IsDismantled(X - 1, Y - 0) && _game.IsBomb(X - 1, Y - 0)) s++;
                if (_game.IsDismantled(X + 1, Y - 0) && _game.IsBomb(X + 1, Y - 0)) s++;
                if (_game.IsDismantled(X - 1, Y + 1) && _game.IsBomb(X - 1, Y + 1)) s++;
                if (_game.IsDismantled(X - 0, Y + 1) && _game.IsBomb(X - 0, Y + 1)) s++;
                if (_game.IsDismantled(X + 1, Y + 1) && _game.IsBomb(X + 1, Y + 1)) s++;

                if (s == c)
                {
                    _game.OpenSpot(X - 1, Y - 1);
                    _game.OpenSpot(X - 0, Y - 1);
                    _game.OpenSpot(X + 1, Y - 1);
                    _game.OpenSpot(X - 1, Y - 0);
                    _game.OpenSpot(X - 0, Y - 0);
                    _game.OpenSpot(X + 1, Y - 0);
                    _game.OpenSpot(X - 1, Y + 1);
                    _game.OpenSpot(X - 0, Y + 1);
                    _game.OpenSpot(X + 1, Y + 1);
                }
            }
        }

        public Button Button
        {
            get { return (this._button); }
        }

        private void Click(object sender, EventArgs e)
        {

            if (!Dismantled)
            {
                if (Minded)
                {
                    Button.BackgroundImage = Properties.Resources.minesweepSquareExploded;
                    _exploded = true;
                    OnExplode();
                }
                else
                {
                    this.Open();
                }
            }
            if (_game.ftime == true && !Minded)
            {
                _game.ftime = false;
                _game._timer = new Timer();
                _game._timer.Interval = 1000;
                _game._timer.Tick += new EventHandler(_game.TimerTick);
                _game._timer.Enabled = true;
            }
        }

        private void DismantleClick(object sender, MouseEventArgs e)
        {
            if (!Opened && e.Button == MouseButtons.Right)
            {
                if (Dismantled)
                {
                    _dismantled = false;
                    Button.BackgroundImage = Properties.Resources.minesweepSquareQuestion;
                }
                else if(Button.Text == "?")
                {
                    Button.BackgroundImage = Properties.Resources.minesweepSquare;
                    return;
                }
                else
                {
                    _dismantled = true;
                    Button.BackgroundImage = Properties.Resources.WinClassicMinesweeperFlag;
                }
                OnDismantle();
            }
        }

        public bool Dismantled
        {
            get { return (this._dismantled); }
        }

        public bool Minded
        {
            get { return (this._minded); }
            set { this._minded = value; }
        }

        protected void OnDismantle()
        {
            if (Dismantle != null)
            {
                Dismantle(this, new EventArgs());
            }
        }

        protected void OnExplode()
        {
            if (Explode != null)
            {
                Explode(this, new EventArgs());
            }
        }

        public void Open()
        {
            if (!Minded)
            {
                if (!Opened && !Dismantled)
                {
                    _opened = true;
                    // Count Bombs
                    int c = 0;
                    if (_game.IsBomb(X - 1, Y - 1)) c++;
                    if (_game.IsBomb(X - 0, Y - 1)) c++;
                    if (_game.IsBomb(X + 1, Y - 1)) c++;
                    if (_game.IsBomb(X - 1, Y - 0)) c++;
                    if (_game.IsBomb(X - 0, Y - 0)) c++;
                    if (_game.IsBomb(X + 1, Y - 0)) c++;
                    if (_game.IsBomb(X - 1, Y + 1)) c++;
                    if (_game.IsBomb(X - 0, Y + 1)) c++;
                    if (_game.IsBomb(X + 1, Y + 1)) c++;

                    if (c > 0)
                    {
                        switch (c)
                        {
                            case 1:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare1;
                                break;
                            case 2:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare2;
                                break;
                            case 3:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare3;
                                break;
                            case 4:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare4;
                                break;
                            case 5:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare5;
                                break;
                            case 6:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare6;
                                break;
                            case 7:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare7;
                                break;
                            case 8:
                                Button.BackgroundImage = Properties.Resources.minesweepSquare8;
                                break;
                        }
                    }
                    else
                    {
                        Button.BackgroundImage = Properties.Resources.minesweepSquare0;
                        Button.Enabled = false;

                        _game.OpenSpot(X - 1, Y - 1);
                        _game.OpenSpot(X - 0, Y - 1);
                        _game.OpenSpot(X + 1, Y - 1);
                        _game.OpenSpot(X - 1, Y - 0);
                        _game.OpenSpot(X - 0, Y - 0);
                        _game.OpenSpot(X + 1, Y - 0);
                        _game.OpenSpot(X - 1, Y + 1);
                        _game.OpenSpot(X - 0, Y + 1);
                        _game.OpenSpot(X + 1, Y + 1);
                    }
                }
            }
        }

        public bool Opened
        {
            get { return (this._opened); }
        }

        public int X
        {
            get { return (this._x); }
        }

        public int Y
        {
            get { return (this._y); }
        }

        public bool Exploded
        {
            get { return (this._exploded); }
        }

        public void RemoveEvents()
        {
            _button.Click -= new EventHandler(Click);
            _button.MouseDown -= new MouseEventHandler(DismantleClick);
            _button.MouseUp -= new MouseEventHandler(MiddleClick);
        }
    }
}
