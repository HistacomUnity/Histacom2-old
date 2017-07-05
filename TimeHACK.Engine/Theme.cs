using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHACK.Engine
{
    public class Theme
    {
        public Stream startSound { get; set; }
        public Stream stopSound { get; set; }

        public Stream asteriskSound { get; set; }
        public Stream critStopSound { get; set; }
        public Stream progErrorSound { get; set; }
        public Stream questionSound { get; set; }

        public Image defaultWallpaper;
    }

    public class Default95Theme: Theme
    {
        public Default95Theme()
        {
            startSound = Properties.Resources.Win95Start;
            stopSound = Properties.Resources.Win95Stop;

            asteriskSound = Properties.Resources.CHORD;
            critStopSound = Properties.Resources.CHORD;
            progErrorSound = Properties.Resources.CHORD;
            questionSound = Properties.Resources.CHORD;

            defaultWallpaper = null;
        }
    }
}
