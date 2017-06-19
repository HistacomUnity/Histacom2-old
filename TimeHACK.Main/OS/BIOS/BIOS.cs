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
using TimeHACK.OS.Win95.Win95Apps;
using TimeHACK.Engine.Template;
using System.Threading;

namespace TimeHACK.OS.BIOS
{
    public partial class BIOS : Form
    {
        public BIOS()
        {
            InitializeComponent();
        }

        private void BIOSConsole_Load(object sender, EventArgs e)
        {
            BIOSConsole.WriteLine("TiemHARK BIOS v.1.337, An Shift Soft Ally.");
            Console.Beep(575, 100);
            Thread.Sleep(1000);
            BIOSConsole.WriteLine("Copyright (C) 1984-1998, AShift Software, Inc.");
            Console.Beep(575, 100);
            Thread.Sleep(1500);
            BIOSConsole.WriteLine("\nAntel More a8-1700x at 1.337 ghz");
            Console.Beep(575, 100);
            Thread.Sleep(500);
            
        }
    }
}
