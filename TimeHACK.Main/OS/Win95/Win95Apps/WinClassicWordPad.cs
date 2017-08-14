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
        WindowManager wm = new WindowManager();
        
        bool doBold = false;
        bool doItalic = false;
        bool doUnderline = false;

        public WinClassicWordPad()
        {
            InitializeComponent();

            foreach (ToolStripMenuItem item in topmenu.Items)
            {
                item.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
                item.BackColor = Color.Silver;
                item.BackgroundImage = Properties.Resources.sliversilver;
                item.BackgroundImageLayout = ImageLayout.Center;
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }

            // Time to prepare to load all the fonts up for the combo boxes
            foreach (FontFamily font in FontFamily.Families) comboFont.Items.Add(font.Name);

            // Handlers
            this.clearToolStripMenuItem.Click += (sender, args) => mainText.Text = mainText.Text.Remove(mainText.SelectionStart, mainText.SelectedText.Length);
            this.pasteToolStripMenuItem.Click += (sender, args) => mainText.Paste();
            this.btnPaste.Click += (sender, args) => mainText.Paste();
            this.btnCopy.Click += (sender, args) => { if (mainText.SelectedText.Length >= 0) mainText.Copy(); };
            this.copyToolStripMenuItem.Click += (sender, args) => { if (mainText.SelectedText.Length >= 0) mainText.Copy(); };
            this.cutToolStripMenuItem.Click += (sender, args) => { if (mainText.SelectedText.Length >= 0) mainText.Cut(); };
            this.btnCut.Click += (sender, args) => { if (mainText.SelectedText.Length >= 0) mainText.Cut(); };
            this.undoToolStripMenuItem.Click += (sender, args) => mainText.Undo();
            this.selectAllToolStripMenuItem.Click += (sender, args) => mainText.SelectAll();
            this.dateTimeToolStripMenuItem.Click += (sender, args) => mainText.AppendText(DateTime.Now.ToString("HH:mm tt dd/MM/yyyy"));
            this.toolbarToolStripMenuItem.Click += (sender, args) => pnlToolbar.Visible = toolbarToolStripMenuItem.Checked;
            this.formatBarToolStripMenuItem.Click += (sender, args) => pnlFormatBar.Visible = formatBarToolStripMenuItem.Checked;
            this.statusBarToolStripMenuItem.Click += (sender, args) => statusBar.Visible = statusBarToolStripMenuItem.Checked;
            this.exitToolStripMenuItem.Click += (sender, args) => ((Form)this.TopLevelControl).Close();
            this.aboutWordpadToolStripMenuItem.Click += (sender, args) => wm.StartAboutBox95("Wordpad", "Microsoft Wordpad", Properties.Resources.Win95IconWordpad);
            this.btnNew.Click += (sender, args) => mainText.Text = "";
            this.newToolStripMenuItem.Click += (sender, args) => mainText.Text = "";
            this.sendToolStripMenuItem.Click += (sender, args) => wm.StartInfobox95("Wordpad", "An error occured opening send option.", Engine.Template.InfoboxType.Error, Engine.Template.InfoboxButtons.OK);
            this.bulletStyleToolStripMenuItem.Click += (sender, args) => mainText.SelectionBullet = bulletStyleToolStripMenuItem.Checked;
            this.comboFont.SelectedIndexChanged += (sender, args) => SetSelectedTextFont(comboFont.Text);
            this.comboSize.SelectedIndexChanged += (sender, args) => SetSelectedTextSize(comboSize.Text);
        }

        #region Format_Buttons

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (!doBold)
            {
                btnBold.BackgroundImage = null;
                doBold = true;
            } else {
                btnBold.BackgroundImage = Properties.Resources.wordpad_bold;
                doBold = false;
            }
            DoFontStyles();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (!doItalic)
            {
                btnItalic.BackgroundImage = null;
                doItalic = true;
            }
            else
            {
                btnItalic.BackgroundImage = Properties.Resources.wordpad_italic;
                doItalic = false;
            }
            DoFontStyles();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (!doUnderline)
            {
                btnUnderline.BackgroundImage = null;
                doUnderline = true;
            }
            else
            {
                btnUnderline.BackgroundImage = Properties.Resources.wordpad_underline;
                doUnderline = false;
            }
            DoFontStyles();
        }

        #endregion

        #region Designer-Stuff
        
        private void btnBold_MouseEnter(object sender, EventArgs e)
        {
            lblStatus.Text = "Makes the selected text Bold. (toggle)";
        }

        private void btnBold_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "For Help, goto Help -> Help Topics";
        }

        private void btnItalic_MouseEnter(object sender, EventArgs e)
        {
            lblStatus.Text = "Makes the selected text Italic. (toggle)";
        }

        private void btnItalic_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "For Help, goto Help -> Help Topics";
        }

        private void btnUnderline_MouseEnter(object sender, EventArgs e)
        {
            lblStatus.Text = "Makes the selected text Underline. (toggle)";
        }

        private void btnUnderline_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "For Help, goto Help -> Help Topics";
        }
        #endregion

        // Things for Cut/Copy/Paste have been placed in the "Designer-Stuff" region!

        void SetSelectedTextFont(string font)
        {
            // The next two lines convert a string to a Font
            var cvt = new FontConverter();
            Font f = cvt.ConvertFromString(font) as Font;

            mainText.SelectionFont = f;
        }

        void SetSelectedTextSize(string size)
        {
            //  The next few lines will ATTEMPT to convert a string to an Integer
            int SizeInt = Convert.ToInt32(size);

            mainText.SelectionFont = new Font(mainText.SelectionFont.FontFamily, SizeInt, mainText.SelectionFont.Style);
        }

        void DoFontStyles()
        {
            FontStyle Bold = FontStyle.Regular;
            FontStyle Italic = FontStyle.Regular;
            FontStyle Underline = FontStyle.Regular;
            if (doBold) Bold = FontStyle.Bold;
            if (doItalic) Italic = FontStyle.Italic;
            if (doUnderline) Underline = FontStyle.Underline;
            mainText.SelectionFont = new Font(mainText.SelectionFont.FontFamily, mainText.SelectionFont.Size, Bold | Italic | Underline);
        }
    }
}