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
        public Stream exclamationSound { get; set; }
        public Stream progErrorSound { get; set; }
        public Stream questionSound { get; set; }

        public Image defaultWallpaper { get; set; }

        public string themeName { get; set; }
    }

    public class Default95Theme: Theme
    {
        public Default95Theme()
        {
            startSound = Properties.Resources.Win95Start;
            stopSound = Properties.Resources.Win95Stop;

            asteriskSound = Properties.Resources.CHORD;
            critStopSound = Properties.Resources.CHORD;
            exclamationSound = Properties.Resources.CHORD;
            progErrorSound = Properties.Resources.CHORD;
            questionSound = Properties.Resources.CHORD;

            defaultWallpaper = null;
            themeName = "default95";
        }
    }

    public class Default98Theme : Theme
    {
        public Default98Theme()
        {
            startSound = Properties.Resources.Win98Start;
            stopSound = Properties.Resources.Win98Stop;

            asteriskSound = Properties.Resources.CHORD;
            critStopSound = Properties.Resources.CHORD;
            exclamationSound = Properties.Resources.CHORD;
            progErrorSound = Properties.Resources.CHORD;
            questionSound = Properties.Resources.CHORD;

            defaultWallpaper = null;
            themeName = "default98";
        }
    }

    public class DangerousCreaturesTheme: Theme
    {
        public DangerousCreaturesTheme()
        {
            startSound = Properties.Resources.Win95PlusDangerousCreaturesStart;
            stopSound = Properties.Resources.Win95PlusDangerousCreaturesStart;

            asteriskSound = Properties.Resources.Win95PlusDangerousCreaturesAsterisk;
            critStopSound = Properties.Resources.Win95PlusDangerousCreaturesCritStop;
            exclamationSound = Properties.Resources.Win95PlusDangerousCreaturesExclamation;
            progErrorSound = Properties.Resources.Win95PlusDangerousCreaturesProgError;
            questionSound = Properties.Resources.Win95PlusDangerousCreaturesQuestion;

            defaultWallpaper = Properties.Resources.Win95PlusDangerousCreaturesWallpaper;
            themeName = "dangeranimals";
        }
    }

    public class InsideComputerTheme: Theme
    {
        public InsideComputerTheme()
        {
            startSound = Properties.Resources.Win95PlusInsideComputerStart;
            stopSound = Properties.Resources.Win95PlusInsideComputerStop;

            defaultWallpaper = Properties.Resources.Win95PlusInsideComputerWallpaper;
            themeName = "insidepc";
        }
    }
}
