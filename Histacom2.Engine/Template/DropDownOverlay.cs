using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.Template
{
    public partial class DropDownOverlay : Form
    {
        public DropDownOverlay()
        {
            InitializeComponent();
        }

        private void outline_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, outline.Width - 1, outline.Height - 1); // Draws a 1 pixel border around the dropdown's drop area!
            if (SaveSystem.currentTheme != null) outline.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
        }
    }
}
