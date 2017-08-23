using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHACK.Engine.UI
{
    public partial class ClassicButton : UserControl
    {
        public ClassicButton()
        {
            InitializeComponent();
        }

        private void ClassicButton_SizeChanged(object sender, EventArgs e)
        {

        }

        private void ClassicButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.White;
            borderpart.BackColor = Color.Black;
            lessgraystuff.Location = new Point(1, 1);
        }

        private void ClassicButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            base.OnPaint(e);
        }

        private void lessgraystuff_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            base.OnPaint(e);
        }

        private void ClassicButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Black;
            borderpart.BackColor = Color.White;
            lessgraystuff.Location = new Point(0, 0);
        }

        private void ClassicButton_Resize(object sender, EventArgs e)
        {
            borderpart.Size = new Size(this.Width - 1, this.Height - 1);
            graystuff.Size = new Size(this.Width - 2, this.Height - 2);
            lessgraystuff.Size = new Size(this.Width - 3, this.Height - 3);
        }
    }
}