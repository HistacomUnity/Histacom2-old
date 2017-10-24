using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histacom2.Engine.UI
{
    //public class CustomTextBox : NativeWindow
    //{
    //    private TextBox parentTextBox;
    //    private Bitmap bitmap;
    //    private Graphics textBoxGraphics;
    //    private Graphics bufferGraphics;
    //    // this is where we intercept the Paint event for the TextBox at the OS level  
    //    protected override void WndProc(ref Message m)
    //    {
    //        switch (m.Msg)
    //        {
    //            case 15: // this is the WM_PAINT message  
    //                     // invalidate the TextBox so that it gets refreshed properly  
    //                parentTextBox.Invalidate();
    //                // call the default win32 Paint method for the TextBox first  
    //                base.WndProc(ref m);
    //                // now use our code to draw extra stuff over the TextBox  
    //                this.CustomPaint();
    //                break;
    //            default:
    //                base.WndProc(ref m);
    //                break;
    //        }
    //    }
    //    public CustomTextBox(TextBox textBox)
    //    {
    //        this.parentTextBox = textBox;
    //        this.bitmap = new Bitmap(textBox.Width, textBox.Height);
    //        this.bufferGraphics = Graphics.FromImage(this.bitmap);
    //        this.bufferGraphics.Clip = new Region(textBox.ClientRectangle);
    //        this.textBoxGraphics = Graphics.FromHwnd(textBox.Handle);
    //        // Start receiving messages (make sure you call ReleaseHandle on Dispose):  
    //        this.AssignHandle(textBox.Handle);
    //    }
    //    private void CustomPaint()
    //    {
    //        // code goes here, see below  
    //    }
    //}

    public partial class ClassicDropDown : Control
    {
        public TextBox tb = new TextBox();
        public bool UseSystemPasswordChar { get; set; }      
        public int CursorPosition { get; set; }
        private Timer CursorBlink { get; set; }
        private bool _cursorVisible { get; set; }

        public ClassicDropDown() : base()
        {
            if (SaveSystem.currentTheme != null) Font = SaveSystem.currentTheme.buttonFont;
            else Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            DoubleBuffered = true;

            CursorBlink = new Timer();
            CursorBlink.Interval = 1000;

            // The stuff that make the textbox "work"

            MouseDown += new MouseEventHandler(PerformMouseDown);
            MouseUp += new MouseEventHandler(PerformMouseUp);

            PreviewKeyDown += (s, e) =>
            {
                e.IsInputKey = true;
            };

            //KeyDown += new KeyEventHandler(PerformKeyDown);

            // Remove the default textbox paint event so that we can have our own! ACTUALLY, NO!

            //FieldInfo f1 = typeof(Control).GetField("EventPaint",
            //    BindingFlags.Static | BindingFlags.NonPublic);
            //object obj = f1.GetValue(this);
            //PropertyInfo pi = GetType().GetProperty("Events",
            //    BindingFlags.NonPublic | BindingFlags.Instance);
            //EventHandlerList list = (EventHandlerList)pi.GetValue(this, null);
            //list.RemoveHandler(obj, list[obj]);

            //tb.Paint += new PaintEventHandler(PerformPaint);
            //TextChanged += new EventHandler(PerformTextChanged);
            //CursorBlink.Tick += new EventHandler(PerformCursorBlink);

            //CursorBlink.Start();

            // I know it's a bit of a hack but it's all we can really do...
            tb.Size = new Size(this.Size.Width - 6, this.Size.Height - 6);
            tb.Location = new Point(3, 3);
            tb.BorderStyle = BorderStyle.None;
            Controls.Add(tb);

            
        }

        protected override void OnPaint(PaintEventArgs e)
        {            
            var textboxcolor = Color.Silver;
            if (SaveSystem.currentTheme != null) textboxcolor = SaveSystem.currentTheme.windowColor;

            if (SaveSystem.currentTheme != null) BackColor = SaveSystem.currentTheme.threeDObjectsColor;
            else BackColor = Color.White;

            var _lightBack = Paintbrush.GetLightFromColor(textboxcolor);
            var _darkBack = Paintbrush.GetDarkFromColor(textboxcolor);

            if (SaveSystem.currentTheme != null) Font = SaveSystem.currentTheme.buttonFont;
            else Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            var g = e.Graphics;
            g.Clear(BackColor);

            //g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            //if (UseSystemPasswordChar) g.DrawString(new string('●', Text.Length), Font, Brushes.Black, 3, 3);
            //else g.DrawString(Text, Font, Brushes.Black, 3, 3);

            g.DrawLine(new Pen(_darkBack), 0, 0, Width - 2, 0);
            g.DrawLine(new Pen(_lightBack), Width - 1, 0, Width - 1, Height - 1);
            g.DrawLine(new Pen(_lightBack), 0, Height - 1, Width - 1, Height - 1);
            g.DrawLine(new Pen(_darkBack), 0, 0, 0, Height - 2);
            g.DrawLine(Pens.Black, 1, 1, Width - 3, 1);
            g.DrawLine(Pens.Black, 1, 1, 1, Height - 3);
            g.DrawLine(new Pen(textboxcolor), 1, Height - 2, Width - 2, Height - 2);
            g.DrawLine(new Pen(textboxcolor), Width - 2, Height - 2, Width - 2, 1);

            Size textSize = MeasureText(Text.Substring(0, CursorPosition), Font); // Get the width of the text from the begining to the cursor's position so it can draw the cursor.

            if (_cursorVisible) g.DrawLine(new Pen(Color.Gray), textSize.Width + 3, 4, textSize.Width + 3, Height - 4); // This is the caret!
            g.DrawImage(Properties.Resources.ClassicDropDownButton, Width - 17, 2);

            base.OnPaint(e);

        }

        private void PerformMouseDown(object sender, MouseEventArgs e)
        {
            // TextBox:

            base.Focus();

            // First check if it is in the bounds of the actual box
            if (e.X < Width - 18 && e.X > 3 && e.Y > 3 && e.Y < Width - 2)
            {
                // Now to get where on text you are clicking... this is very tricky because different characters are different widths...
                int Sum = 0;
                int i = 0;

                foreach (char character in Text)
                {

                    Sum += MeasureText(character.ToString(), Font).Width;
                    
                    if (e.X - 3 <= Sum) break;

                    //LastSum = Sum;
                    i++;
                }

                //setCurPos = (Sum == 0) ? Text.Length : Sum;
                //if (setCurPos > Text.Length) setCurPos = Text.Length;
                CursorPosition = i; // This sets the cursor position!
            }
            _cursorVisible = true;

            // DropDown:


            Invalidate();
        }

        private void PerformMouseUp(object sender, MouseEventArgs e)
        {
            // DropDown:


        }

        private void PerformKeyDown(object sender, KeyEventArgs e)
        {
            // TextBox:

            switch (e.KeyCode)
            {
                case Keys.Back:
                    Text = Text.Remove(CursorPosition - 1, 1);
                    break;
                case Keys.Delete:
                    if (!(CursorPosition > Text.Length + 1)) Text = Text.Remove(CursorPosition, 1);
                    break;
                case Keys.Home:
                    CursorPosition = 0;
                    break;
                case Keys.End:
                    CursorPosition = Text.Length;
                    break;
                case Keys.Left:
                    if (CursorPosition > 0) CursorPosition -= 1; 
                    break;
                case Keys.Right:
                    if (CursorPosition < Text.Length) CursorPosition += 1;
                    break;
                case Keys.Return:
                    break;
                case Keys.Space:
                    Text = Text.Insert(CursorPosition, " ");
                    CursorPosition = CursorPosition + 1;
                    break;
                default:
                    bool caps = false;

                    if (e.Shift) caps = true;
                    if (Control.IsKeyLocked(Keys.CapsLock)) caps = true;

                    if (char.IsLetterOrDigit((char)e.KeyCode))
                    {
                        // Now the numbers 1, 2, 3 etc. are "d1", "d2" etc. - STUPID, RIGHT? So now we have to check if it has a number and contains "d".

                        bool handled = false;

                        if (StrContainsNumber(e.KeyCode.ToString().ToLower()))
                        {
                            if (e.KeyCode.ToString().ToLower().Contains("d"))
                            {
                                handled = true;
                                Text = Text.Insert(CursorPosition, e.KeyCode.ToString().Replace("d", ""));
                            }
                        }

                        if (handled == false)
                        {
                            if (caps == false) Text = Text.Insert(CursorPosition, e.KeyCode.ToString().ToLower()); else Text = Text.Insert(CursorPosition, e.KeyCode.ToString().ToUpper());
                        }
                        CursorPosition = CursorPosition + 1;
                    }
                    break;
            }

            _cursorVisible = true;
            Invalidate();
        }

        private void PerformCursorBlink(object sender, EventArgs e)
        {
            if (_cursorVisible) _cursorVisible = false;
            else _cursorVisible = true;
            Invalidate();
        }

        private void PerformTextChanged(object sender, EventArgs e)
        {
            _cursorVisible = true;
            if (CursorPosition >= Text.Length) CursorPosition = Text.Length;
            Invalidate();
        }

        public static Size MeasureText(string Text, Font Font)
        {
            TextFormatFlags flags
              = TextFormatFlags.Left
              | TextFormatFlags.Top
              | TextFormatFlags.NoPadding
              | TextFormatFlags.NoPrefix;
            Size szProposed = new Size(int.MaxValue, int.MaxValue);
            Size sz1 = TextRenderer.MeasureText(".", Font, szProposed, flags);
            Size sz2 = TextRenderer.MeasureText(Text + ".", Font, szProposed, flags);
            return new Size(sz2.Width - sz1.Width, sz2.Height);
        }

        public bool StrContainsNumber(string str)
        {
            foreach (char ch in str)
            {
                double unused;
                if (double.TryParse(ch.ToString(), out unused)) return true;
            }
            return false;
        }

        [DllImport("gdi32.dll")]
        private static extern bool BitBlt(
IntPtr hdcDest, // handle to destination DC
int nXDest, // x-coord of destination upper-left corner
int nYDest, // y-coord of destination upper-left corner
int nWidth, // width of destination rectangle
int nHeight, // height of destination rectangle
IntPtr hdcSrc, // handle to source DC
int nXSrc, // x-coordinate of source upper-left corner
int nYSrc, // y-coordinate of source upper-left corner
System.Int32 dwRop // raster operation code
);
    }
}
