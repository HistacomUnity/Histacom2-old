using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.OS.Win95.Win95Apps.IE3Sites
{
    public partial class GooglePrototype : UserControl
    {
        public GooglePrototype()
        {
            InitializeComponent();
        }

        private void GooglePrototype_Load(object sender, EventArgs e)
        {
            button1.Paint += (s, args) => Engine.Paintbrush.PaintClassicBorders(s, args, 2);
            button2.Paint += (s, args) => Engine.Paintbrush.PaintClassicBorders(s, args, 2);
            button3.Paint += (s, args) => Engine.Paintbrush.PaintClassicBorders(s, args, 2);
        }
    }
}
