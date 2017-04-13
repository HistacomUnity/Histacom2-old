using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.Engine.Template
{
    public partial class Win9XBSOD : Form
    {
        public bool reset = false;

        public Win9XBSOD()
        {
            InitializeComponent();
        }

        private void Win9XBSOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Environment.Exit(0);
            else
            {
                reset = true;
                this.Close();
            }
        }
    }
}
