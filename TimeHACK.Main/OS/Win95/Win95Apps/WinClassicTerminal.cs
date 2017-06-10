using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicTerminal : UserControl
    {
        public WinClassicTerminal()
        {
            InitializeComponent();
            this.richTextBox1.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }
        private SoundPlayer startsound;
        /// <summary>
        /// Write text to the Terminal and create a new line. Very similar to the Win32 Console.WriteLine Function.
        /// </summary>
        /// <param name="Text"></param>
        public void WriteLine(string Text)
        {
            richTextBox1.AppendText(Text + "\n");
        }

        /// <summary>
        /// Write text to the Terminal. Very similar to the Win32 Console.Write Function.
        /// </summary>
        /// <param name="Text"></param>
        public void Write(String Text)
        {
            richTextBox1.AppendText(Text);
        }
    }
}
