using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Histacom2
{
    public partial class SeizureWarning : UserControl
    {
        public SeizureWarning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(Engine.SaveSystem.DataDirectory, "o.k"), ".");
            this.Hide();
        }
    }
}
