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
    public partial class ResizeOverlay : Form
    {
        public Rectangle ToDraw = new Rectangle();

        public ResizeOverlay()
        {
            InitializeComponent();
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            outline.Bounds = ToDraw; // Pens.Gray, ToDraw);
        }

        private void outline_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, 0, 0, outline.Width, 4); // Top border
            e.Graphics.FillRectangle(Brushes.Gray, 0, outline.Height - 4, outline.Width, 4); // Bottom border
            e.Graphics.FillRectangle(Brushes.Gray, 0, 0, 4, outline.Height); // Left border
            e.Graphics.FillRectangle(Brushes.Gray, outline.Width - 4, 0, 4, outline.Height); // Right border
        }
    }
}
