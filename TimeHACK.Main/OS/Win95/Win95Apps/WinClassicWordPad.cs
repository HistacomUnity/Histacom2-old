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
                item.BackgroundImageLayout = ImageLayout.Center;
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }

            // Time to prepare to load all the fonts up for the combo boxes

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                // Added to the ComboBox here

                comboFont.Items.Add(font.Name);
            }
        }

        #region Format_Buttons

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
            DoFontStyles();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
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
            DoFontStyles();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
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
            DoFontStyles();
        }

        #endregion

        #region Designer-Stuff
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertDateTime();
        }
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

        private void aboutWordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.startAboutBox95("Wordpad", "Microsoft Wordpad", Properties.Resources.WinClassicWordpad);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.startInfobox95("Wordpad", "An error occured opening send option.", null);
        }

        void Cut()
        {
            if (mainText.SelectedText.Length >= 0) {
                mainText.Cut();
            }     
        }

        void Copy()
        {
            if (mainText.SelectedText.Length >= 0)
            {
                mainText.Copy();
            }
        }

        void Paste()
        {
            mainText.Paste();
        }

        void Clear()
        {
            mainText.Text = mainText.Text.Remove(mainText.SelectionStart, mainText.SelectedText.Length);
        }

        void SelectAll()
        {
            mainText.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void bulletStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.SelectionBullet = bulletStyleToolStripMenuItem.Checked;
        }

        private void comboFont_SelectedIndexChanged(object sender, EventArgs e)
        {           
            SetSelectedTextFont(comboFont.Text);
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedTextSize(comboSize.Text);
        }
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

        void NewFile()
        {
            mainText.Text = "";
        }

        void Undo()
        {
            mainText.Undo();
        }

        void InsertDateTime()
        {
            string DateTime = System.DateTime.Now.ToString("HH:mm tt dd/MM/yyyy");
            mainText.AppendText(DateTime);
        }

        // Things for Cut/Copy/Paste have been placed in the "Designer-Stuff" region!

        void SetSelectedTextFont(String font)
        {
            // The next two lines convert a String to a Font
            var cvt = new FontConverter();
            Font f = cvt.ConvertFromString(font) as Font;

            mainText.SelectionFont = f;
        }

        void SetSelectedTextSize(String size)
        {
            //  The next few lines will ATTEMPT to convert a String to an Integer
            int SizeInt = Convert.ToInt32(size);

            mainText.SelectionFont = new Font(mainText.SelectionFont.FontFamily, SizeInt, mainText.SelectionFont.Style);
        }

        void DoFontStyles()
        {
            FontStyle Bold = FontStyle.Regular;
            FontStyle Italic = FontStyle.Regular;
            FontStyle Underline = FontStyle.Regular;
            if (doBold == true)
            {
                Bold = FontStyle.Bold;
            }
            if (doItalic == true)
            {
                Italic = FontStyle.Italic;
            }
            if (doUnderline == true)
            {
                Underline = FontStyle.Underline;
            }
            mainText.SelectionFont = new Font(mainText.SelectionFont.FontFamily, mainText.SelectionFont.Size, Bold | Italic | Underline);
        }
    }
}