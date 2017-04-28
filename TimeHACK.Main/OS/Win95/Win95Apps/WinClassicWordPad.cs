using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using TimeHACK.Engine;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicWordPad : UserControl
    {
        bool btnBoldSelected = true;
        bool btnItalicSelected;
        bool btnUnderlineSelected;
        bool doBold;
        bool doItalic;
        bool doUnderline;
        public WinClassicWordPad()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem item in topmenu.Items)
            {
                item.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                item.BackColor = Color.Silver;
                item.BackgroundImage = Properties.Resources.sliversilver;
                item.BackgroundImageLayout = ImageLayout.None;
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }

            // Time to prepare to load all the fonts up for the combo boxes

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                // Added to the ComboBox here

                comboFont.Items.Add(font.Name);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (btnBoldSelected == false)
            {
                btnBold.BackgroundImage = null;
                btnBoldSelected = true;
                
            } else {
                btnBold.BackgroundImage = Properties.Resources.sliversilver;
                btnBoldSelected = false;
            }
            doBold = btnBoldSelected;
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            btnItalic.BackColor = Color.DimGray; // This is here to fix a "have to double click" bug!
            if (btnItalicSelected == false)
            {
                btnItalic.BackgroundImage = Properties.Resources.sliversilver;
                btnItalicSelected = true;
            }
            else
            {
                btnItalic.BackgroundImage = null;
                btnItalicSelected = false;
            }
            doItalic = btnItalicSelected;
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            btnUnderline.BackColor = Color.DimGray; // This is here to fix a "have to double click" bug!
            if (btnUnderlineSelected == false)
            {
                btnUnderline.BackgroundImage = Properties.Resources.sliversilver;
                btnUnderlineSelected = true;
            }
            else
            {
                btnUnderline.BackgroundImage = null;
                btnUnderlineSelected = false;
            }
            doUnderline = btnUnderlineSelected;
        }

        #region Designer-Stuff
        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlToolbar.Visible = toolbarToolStripMenuItem.Checked;
        }

        private void formatBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlFormatBar.Visible = formatBarToolStripMenuItem.Checked;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
        #endregion

        private void aboutWordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            wm.startAboutBox95("Wordpad", "Microsoft Wordpad", Properties.Resources.WinClassicWordpad);
        }
    }
}
