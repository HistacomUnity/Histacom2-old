using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine;
using Histacom2.Engine.Template;

namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class WinClassicThemePanel : UserControl
    {
        public WinClassicThemePanel()
        {
            InitializeComponent();
            applyButton.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            cancelButton.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            okButton.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)comboBox1.SelectedItem)
            {
                case "Default":
                    pictureBox2.BackgroundImage = null;
                    break;
                case "Dangerous Creatures":
                    pictureBox2.BackgroundImage = Properties.Resources.DCTheme_BG;
                    break;
                case "Inside Your Computer":
                    pictureBox2.BackgroundImage = Properties.Resources.ICTheme_BG;
                    break;
            }
        }

        private void WinClassicThemePanel_Load(object sender, EventArgs e)
        {
            switch (SaveSystem.CurrentSave.ThemeName)
            {
                case "default95":
                    comboBox1.SelectedItem = "Default";
                    break;
                case "dangeranimals":
                    comboBox1.SelectedItem = "Dangerous Creatures";
                    break;
                case "insidepc":
                    comboBox1.SelectedItem = "Inside Your Computer";
                    break;
                case "default95plus":
                    comboBox1.SelectedItem = "Windows 95 Default Plus";
                    break;
                case "goldenera":
                    comboBox1.SelectedItem = "The Golden Era";
                    break;
                case "Leo":
                    comboBox1.SelectedItem = "Leonardo da Vinci";
                    break;
                case "Mystery":
                    comboBox1.SelectedItem = "Mystery";
                    break;
                case "Nature":
                    comboBox1.SelectedItem = "Nature";
                    break;
                case "Science":
                    comboBox1.SelectedItem = "Science";
                    break;
                case "Sports":
                    comboBox1.SelectedItem = "Sports";
                    break;
                case "The60":
                    comboBox1.SelectedItem = "The 60's USA";
                    break;
                case "Travel":
                    comboBox1.SelectedItem = "Travel";
                    break;
                case "MoreWin":
                    comboBox1.SelectedItem = "More Windows";
                    break;

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ChangeTheme();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ChangeTheme();
            ParentForm.Close();
        }

        private void ChangeTheme()
        {
            switch ((string)comboBox1.SelectedItem)
            {
                case "Default":
                    SaveSystem.CurrentSave.ThemeName = "default95";
                    SaveSystem.currentTheme = new Default95Theme();
                    TitleScreen.frm95.desktopicons.BackgroundImage = null;
                    break;
                case "Dangerous Creatures":
                    SaveSystem.CurrentSave.ThemeName = "dangeranimals";
                    SaveSystem.currentTheme = new DangerousCreaturesTheme();
                    TitleScreen.frm95.desktopicons.BackgroundImage = new Bitmap(Properties.Resources.DCTheme_BG, TitleScreen.frm95.Width, TitleScreen.frm95.Height);
                    break;
                case "Inside Your Computer":
                    SaveSystem.CurrentSave.ThemeName = "insidepc";
                    SaveSystem.currentTheme = new InsideComputerTheme();
                    TitleScreen.frm95.desktopicons.BackgroundImage = new Bitmap(Properties.Resources.ICTheme_BG, TitleScreen.frm95.Width, TitleScreen.frm95.Height);
                    break;
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is WinClassic)
                {
                    if (((WinClassic)f).isActive)
                    {
                        ((WinClassic)f).programtopbar.BackColor = SaveSystem.currentTheme.activeTitleBarColor;
                        ((WinClassic)f).Title.ForeColor = SaveSystem.currentTheme.activeTitleTextColor;
                    }
                    else
                    {
                        ((WinClassic)f).programtopbar.BackColor = SaveSystem.currentTheme.inactiveTitleBarColor;
                        ((WinClassic)f).Title.ForeColor = SaveSystem.currentTheme.inactiveTitleTextColor;
                    }
                    f.Invalidate();
                    ((WinClassic)f).programContent.Invalidate();
                    ((WinClassic)f).top.Invalidate();
                    ((WinClassic)f).toprightcorner.Invalidate();
                    ((WinClassic)f).right.Invalidate();
                    ((WinClassic)f).bottomrightcorner.Invalidate();
                    ((WinClassic)f).bottom.Invalidate();
                    ((WinClassic)f).bottomleftcorner.Invalidate();
                    ((WinClassic)f).left.Invalidate();
                    ((WinClassic)f).topleftcorner.Invalidate();
                    foreach (Control c in ((WinClassic)f).progContent.Controls) c.Invalidate();
                    ((WinClassic)f).progContent.BackColor = SaveSystem.currentTheme.threeDObjectsColor;
                }
            }
            TitleScreen.frm95.taskbar.Invalidate();
            TitleScreen.frm95.clockPanel.Invalidate();
        }
    }
}
