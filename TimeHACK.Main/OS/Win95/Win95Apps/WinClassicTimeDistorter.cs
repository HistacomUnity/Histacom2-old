using System;
using System.Windows.Forms;
using TimeHACK.Engine;
using TimeHACK.Engine.Template;

namespace TimeHACK.OS.Win95
{
    public partial class WinClassicTimeDistorter : UserControl
    {
        private int _counter;
        private Form _action;

        public WinClassicTimeDistorter(string currentYear, string yearToTravel, int counter, Form action = null)
        {
            InitializeComponent();
            
            btnGo.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            lblYear.Text = currentYear;
            lblDestYear.Text = yearToTravel;
            _action = action;
            _counter = counter;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lblCountDown.Visible = true;
            btnGo.Enabled = false;
            countDownTimer.Start();

            lblCountDown.Text = $"Preparing to travel... ETA: {_counter.ToString()} seconds";
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            _counter--;

            if (_counter == 0)
            {
                countDownTimer.Stop();

                if (_action != null)
                    _action.ShowDialog();
            }
            lblCountDown.Text = $"Preparing to travel... ETA: {_counter.ToString()} seconds";
        }
    }
}
