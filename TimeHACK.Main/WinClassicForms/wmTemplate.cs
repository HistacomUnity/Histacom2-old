using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;

namespace TimeHACK.WinClassicForms
{
    public partial class wmTemplate : Form
    {
        public wmTemplate()
        {
            InitializeComponent();
        }

        private void wmTemplate_Load(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            TestApp ta = new TestApp();
            wm.startWinClassic(ta, "idk", null);
        }
    }
}
