using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;
using TimeHACK.Engine.Template;

namespace TimeHACK.OS.Win95
{
    public partial class WinClassicTimeDistorter : UserControl
    {
        private int _counter;
        private Action _action;

        public WinClassicTimeDistorter(string currentYear, string yearToTravel, int counter, Action action = null)
        {
            InitializeComponent();
            
            btnGo.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            lblYear.Text = currentYear;
            lblDestYear.Text = yearToTravel;
            _action = action;
            _counter = counter;
        }

        public int Counter
        {
            get { return _counter; }
            set { _counter = value; }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lblCountDown.Visible = true;
            btnGo.Enabled = false;
            ((WinClassic)ParentForm).closeDisabled = true;

            _action?.Invoke();
            countDownTimer.Start();

            lblCountDown.Text = $"Preparing to travel... ETA: {_counter.ToString()} seconds";
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            _counter--;

            if (_counter == 0)
            {
                countDownTimer.Stop();
            }

            lblCountDown.Text = $"Preparing to travel... ETA: {_counter.ToString()} seconds";
        }
    }
}
