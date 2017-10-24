using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histacom2.Engine
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

        public Color threeDObjectsColor { get; set; }
        public Color threeDObjectsTextColor { get; set; }

        public Font buttonFont { get; set; }

        public Color windowColor { get; set; }

        public Color activeTitleBarColor { get; set; }
        public Color activeTitleTextColor { get; set; }
        public Color inactiveTitleBarColor { get; set; }
        public Color inactiveTitleTextColor { get; set; }

        public Color selectedBackColor { get; set; }
        public Color selectedTextColor { get; set; }

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

            threeDObjectsColor = Color.Silver;
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.Navy;
            activeTitleTextColor = Color.White;
            inactiveTitleBarColor = Color.Gray;
            inactiveTitleTextColor = Color.Silver;

            selectedBackColor = Color.Navy;
            selectedTextColor = Color.White;

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

            threeDObjectsColor = Color.Silver;
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.Navy;
            activeTitleTextColor = Color.White;
            inactiveTitleBarColor = Color.Gray;
            inactiveTitleTextColor = Color.Silver;

            selectedBackColor = Color.Navy;
            selectedTextColor = Color.White;

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

            threeDObjectsColor = Color.FromArgb(112, 112, 112);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);

            windowColor = Color.FromArgb(184, 184, 184);

            activeTitleBarColor = Color.Teal;
            activeTitleTextColor = Color.White;
            inactiveTitleBarColor = Color.FromArgb(72, 72, 72);
            inactiveTitleTextColor = Color.Gray;

            selectedBackColor = Color.Teal;
            selectedTextColor = Color.White;

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

            asteriskSound = Properties.Resources.Win95PlusInsideComputerAsterisk;
            critStopSound = Properties.Resources.Win95PlusInsideComputerCritStop;
            exclamationSound = Properties.Resources.Win95PlusInsideComputerExclamation;
            progErrorSound = Properties.Resources.Win95PlusInsideComputerProgError;
            questionSound = Properties.Resources.Win95PlusInsideComputerQuestion;

            threeDObjectsColor = Color.FromArgb(169, 200, 169);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);

            windowColor = Color.White;

            activeTitleBarColor = Color.FromArgb(224, 0, 0);
            activeTitleTextColor = Color.White;
            inactiveTitleBarColor = Color.FromArgb(96, 168, 128);
            inactiveTitleTextColor = Color.FromArgb(216, 224, 216);

            selectedBackColor = Color.FromArgb(248, 255, 160);
            selectedTextColor = Color.Black;

            defaultWallpaper = Properties.Resources.Win95PlusInsideComputerWallpaper;
            themeName = "insidepc";
        }
    }

    public class Default95PlusTheme : Theme
    {
        public Default95PlusTheme()
        {
            startSound = Properties.Resources.Win95PlusDefaultStop;
            stopSound = Properties.Resources.Win95PlusDefaultStop;

            asteriskSound = Properties.Resources.Win95PlusDefaultAstrisk;
            critStopSound = Properties.Resources.Win95PlusDefaultCritStop;
            exclamationSound = Properties.Resources.Win95PlusDefaultExclamation;
            progErrorSound = Properties.Resources.Win95PlusDefaultProgError;
            questionSound = Properties.Resources.Win95PlusDefaultQuestion;

            threeDObjectsColor = Color.Silver;
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.Navy;
            activeTitleTextColor = Color.White;
            inactiveTitleBarColor = Color.Gray;
            inactiveTitleTextColor = Color.Silver;

            selectedBackColor = Color.Navy;
            selectedTextColor = Color.White;

            defaultWallpaper = Properties.Resources.Win95PlusDefaultWallpaper;
            themeName = "default95plus";
        }
    }

    public class GoldenEraTheme : Theme
    {
        public GoldenEraTheme()
        {
            startSound = Properties.Resources.Win95PlusGoldenEraStop;
            stopSound = Properties.Resources.Win95PlusGoldenEraStop;

            asteriskSound = Properties.Resources.Win95PlusGoldenEraAstrisk;
            critStopSound = Properties.Resources.Win95PlusGoldenEraCritStop;
            exclamationSound = Properties.Resources.Win95PlusGoldenEraExclamation;
            progErrorSound = Properties.Resources.Win95PlusGoldenEraProgError;
            questionSound = Properties.Resources.Win95PlusGoldenEraQuestion;

            threeDObjectsColor = Color.FromArgb(184, 200, 184);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.FromArgb(225, 248, 224);

            activeTitleBarColor = Color.FromArgb(216, 112, 96);
            activeTitleTextColor = Color.FromArgb(255, 248, 224);
            inactiveTitleBarColor = Color.FromArgb(112, 143, 112);
            inactiveTitleTextColor = Color.FromArgb(0, 0, 0);

            selectedBackColor = Color.FromArgb(128 ,136, 168);
            selectedTextColor = Color.FromArgb(225,248, 224);

            defaultWallpaper = Properties.Resources.Win95PlusGoldenEraWallpaper;
            themeName = "goldenera";
        }
    }


    public class LeoTheme : Theme
    {
        public LeoTheme()
        {
            startSound = Properties.Resources.Win95PlusLeoStart;
            stopSound = Properties.Resources.Win95PlusLeoStart;

            asteriskSound = Properties.Resources.Win95PlusLeoAsterisk;
            critStopSound = Properties.Resources.Win95PlusLeoCritStop;
            exclamationSound = Properties.Resources.Win95PlusLeoExclamation;
            progErrorSound = Properties.Resources.Win95PlusLeoProgError;
            questionSound = Properties.Resources.Win95PlusLeoQuestion;

            threeDObjectsColor = Color.FromArgb(191, 165, 159);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.FromArgb(128, 0, 0);
            activeTitleTextColor = Color.FromArgb(225, 255, 255);
            inactiveTitleBarColor = Color.FromArgb(139, 101, 92);
            inactiveTitleTextColor = Color.FromArgb(223, 210, 208);

            selectedBackColor = Color.FromArgb(128, 0, 0);
            selectedTextColor = Color.FromArgb(225, 255, 255);

            defaultWallpaper = Properties.Resources.Win95PlusLeoWallpaper;
            themeName = "Leo";
        }
    }

    public class MysteryTheme : Theme
    {
        public MysteryTheme()
        {
            startSound = Properties.Resources.Win95PlusMysteryStart;
            stopSound = Properties.Resources.Win95PlusMysteryStop;

            asteriskSound = Properties.Resources.Win95PlusMysteryAstrisk;
            critStopSound = Properties.Resources.Win95PlusMysteryCritStop;
            exclamationSound = Properties.Resources.Win95PlusMysteryExclamation;
            progErrorSound = Properties.Resources.Win95PlusMysteryProgError;
            questionSound = Properties.Resources.Win95PlusMysteryQuestion;

            threeDObjectsColor = Color.FromArgb(104, 120, 104);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.FromArgb(225, 255, 240);

            activeTitleBarColor = Color.FromArgb(80, 56, 64);
            activeTitleTextColor = Color.FromArgb(255, 255, 240);
            inactiveTitleBarColor = Color.FromArgb(72, 80, 72);
            inactiveTitleTextColor = Color.FromArgb(104, 120, 104);

            selectedBackColor = Color.FromArgb(184, 120, 64);
            selectedTextColor = Color.White;

            defaultWallpaper = Properties.Resources.Win95PlusMysteryWallpaper;
            themeName = "Mystery";
        }
    }

    public class NatureTheme : Theme
    {
        public NatureTheme()
        {
            startSound = Properties.Resources.Win95PlusNatureStart;
            stopSound = Properties.Resources.Win95PlusNatureStop;

            asteriskSound = Properties.Resources.Win95PlusNatureAstrisk;
            critStopSound = Properties.Resources.Win95PlusNatureCritStop;
            exclamationSound = Properties.Resources.Win95PlusNatureExclamation;
            progErrorSound = Properties.Resources.Win95PlusNatureProgError;
            questionSound = Properties.Resources.Win95PlusNatureQuestion;

            threeDObjectsColor = Color.FromArgb(216, 192, 160);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.FromArgb(240, 232, 216);

            activeTitleBarColor = Color.FromArgb(0, 72, 72);
            activeTitleTextColor = Color.FromArgb(240, 232, 216);
            inactiveTitleBarColor = Color.FromArgb(104, 80, 56);
            inactiveTitleTextColor = Color.FromArgb(0, 0, 0);

            selectedBackColor = Color.FromArgb(176, 144, 112);
            selectedTextColor = Color.FromArgb(0, 0, 0);

            defaultWallpaper = Properties.Resources.Win95PlusNatureWallpaper;
            themeName = "Nature";
        }
    }

    public class ScienceTheme : Theme
    {
        public ScienceTheme()
        {
            startSound = Properties.Resources.Win95PlusScienceStart;
            stopSound = Properties.Resources.Win95PlusScienceStop;

            asteriskSound = Properties.Resources.Win95PlusScienceAsterisk;
            critStopSound = Properties.Resources.Win95PlusScienceCritStop;
            exclamationSound = Properties.Resources.Win95PlusScienceExclamation;
            progErrorSound = Properties.Resources.Win95PlusScienceProgError;
            questionSound = Properties.Resources.Win95PlusScienceQuestion;

            threeDObjectsColor = Color.FromArgb(131, 153, 177);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.FromArgb(0, 128, 128);
            activeTitleTextColor = Color.FromArgb(255, 255, 255);
            inactiveTitleBarColor = Color.FromArgb(160, 160, 164);
            inactiveTitleTextColor = Color.FromArgb(193, 204, 217);

            selectedBackColor = Color.FromArgb(0, 128, 224);
            selectedTextColor = Color.FromArgb(225, 255, 255);

            defaultWallpaper = Properties.Resources.Win95PlusScienceWallpaper;
            themeName = "Science";
        }
    }

    public class SportsTheme : Theme
    {
        public SportsTheme()
        {
            startSound = Properties.Resources.Win95PlusSportsStart;
            stopSound = Properties.Resources.Win95PlusSportsStop;

            asteriskSound = Properties.Resources.Win95PlusSportsAstrisk;
            critStopSound = Properties.Resources.Win95PlusSportsCritStop;
            exclamationSound = Properties.Resources.Win95PlusSportsExclamation;
            progErrorSound = Properties.Resources.Win95PlusSportsProgError;
            questionSound = Properties.Resources.Win95PlusSportsQuestion;

            threeDObjectsColor = Color.FromArgb(176, 224, 160);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.FromArgb(0, 128, 128);
            activeTitleTextColor = Color.FromArgb(0, 0, 0);
            inactiveTitleBarColor = Color.FromArgb(0, 128, 0);
            inactiveTitleTextColor = Color.FromArgb(176, 224, 160);

            selectedBackColor = Color.FromArgb(255, 255, 0);
            selectedTextColor = Color.FromArgb(0, 0, 0);

            defaultWallpaper = Properties.Resources.Win95PlusSportsWallpaper;
            themeName = "Sports";
        }
    }

    public class The60Theme : Theme
    {
        public The60Theme()
        {
            startSound = Properties.Resources.Win95PlusThe60Start;
            stopSound = Properties.Resources.Win95PlusThe60Stop;

            asteriskSound = Properties.Resources.Win95PlusThe60Asterisk;
            critStopSound = Properties.Resources.Win95PlusThe60CritStop;
            exclamationSound = Properties.Resources.Win95PlusThe60Exclamation;
            progErrorSound = Properties.Resources.Win95PlusThe60ProgError;
            questionSound = Properties.Resources.Win95PlusThe60Question;

            threeDObjectsColor = Color.FromArgb(208, 104, 216);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.FromArgb(0, 0, 128);
            activeTitleTextColor = Color.FromArgb(255, 255, 255);
            inactiveTitleBarColor = Color.FromArgb(160, 48, 168);
            inactiveTitleTextColor = Color.FromArgb(232, 184, 240);

            selectedBackColor = Color.FromArgb(0, 255, 0);
            selectedTextColor = Color.FromArgb(0, 0, 0);

            defaultWallpaper = Properties.Resources.Win95PlusThe60Wallpaper;
            themeName = "The60";
        }
    }

    public class TravelTheme : Theme
    {
        public TravelTheme()
        {
            startSound = Properties.Resources.Win95PlusTravelStart;
            stopSound = Properties.Resources.Win95PlusTravelStop;

            asteriskSound = Properties.Resources.Win95PlusTravelAsterisk;
            critStopSound = Properties.Resources.Win95PlusTravelCritStop;
            exclamationSound = Properties.Resources.Win95PlusTravelExclamation;
            progErrorSound = Properties.Resources.Win95PlusTravelProgError;
            questionSound = Properties.Resources.Win95PlusTravelQuestion;

            threeDObjectsColor = Color.FromArgb(144, 128, 112);
            threeDObjectsTextColor = Color.Black;

            buttonFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            windowColor = Color.White;

            activeTitleBarColor = Color.FromArgb(64, 72, 120);
            activeTitleTextColor = Color.FromArgb(224, 224, 216);
            inactiveTitleBarColor = Color.FromArgb(96, 88, 72);
            inactiveTitleTextColor = Color.FromArgb(144, 128, 112);

            selectedBackColor = Color.FromArgb(72, 96, 80);
            selectedTextColor = Color.FromArgb(224, 224, 216);

            defaultWallpaper = Properties.Resources.Win95PlusTravelWallpaper;
            themeName = "Travel";
        }
    }

    public class MoreWinTheme : Default95PlusTheme
    {
        public MoreWinTheme()
        {
            defaultWallpaper = Properties.Resources.Win95PlusMoreWin;
            themeName = "MoreWin";
        }
    }

    public class BadXPTheme: Theme
    {
        public BadXPTheme()
        {
            startSound = Properties.Resources.WinBadXPStart;

            threeDObjectsColor = Color.White;

            selectedBackColor = Color.FromArgb(51, 102, 204);
            selectedTextColor = Color.White;

            defaultWallpaper = Properties.Resources.WinXPWallpaper;
            themeName = "badxp";
        }
    }
}
