using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.UI
{
    //public class OldClassicTextbox : Control
    //{
    //    private System.ComponentModel.IContainer components = null;
    //    public TextBox tb = new TextBox();
    //    public bool UseSystemPasswordChar { get; set; }

    //    public ClassicTextbox() : base()
    //    {
    //        // A bunch of designer stuff!
    //        this.components = new System.ComponentModel.Container();
    //        this.SuspendLayout();

    //        if (SaveSystem.currentTheme != null) Font = SaveSystem.currentTheme.buttonFont;
    //        else Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

    //        tb.Name = "mainText";
    //        tb.Location = new Point(3, 3);
    //        tb.Size = new Size(Size.Width - 6, Size.Height - 6);
    //        tb.BorderStyle = BorderStyle.None;
    //        Controls.Add(tb);

    //        this.ResumeLayout(false);
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    protected override void OnPaint(PaintEventArgs e)
    //    {           

    //        var textboxcolor = Color.Silver;
    //        if (SaveSystem.currentTheme != null) textboxcolor = SaveSystem.currentTheme.windowColor;

    //        if (SaveSystem.currentTheme != null) BackColor = SaveSystem.currentTheme.threeDObjectsColor;
    //        else BackColor = Color.White;

    //        var _lightBack = Paintbrush.GetLightFromColor(textboxcolor);
    //        var _darkBack = Paintbrush.GetDarkFromColor(textboxcolor);

    //        if (SaveSystem.currentTheme != null) Font = SaveSystem.currentTheme.buttonFont;
    //        else Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

    //        var g = e.Graphics;
    //        g.Clear(BackColor);

    //        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
    //        if (UseSystemPasswordChar) g.DrawString(new string('●', Text.Length), Font, Brushes.Black, 3, 3);
    //        else g.DrawString(Text, Font, Brushes.Black, 3, 3);

    //        g.DrawLine(new Pen(_darkBack), 0, 0, Width - 2, 0);
    //        g.DrawLine(new Pen(_lightBack), Width - 1, 0, Width - 1, Height - 1);
    //        g.DrawLine(new Pen(_lightBack), 0, Height - 1, Width - 1, Height - 1);
    //        g.DrawLine(new Pen(_darkBack), 0, 0, 0, Height - 2);
    //        g.DrawLine(Pens.Black, 1, 1, Width - 3, 1);
    //        g.DrawLine(Pens.Black, 1, 1, 1, Height - 3);
    //        g.DrawLine(new Pen(textboxcolor), 1, Height - 2, Width - 2, Height - 2);
    //        g.DrawLine(new Pen(textboxcolor), Width - 2, Height - 2, Width - 2, 1);

    //        base.OnPaint(e);
    //    }
}
