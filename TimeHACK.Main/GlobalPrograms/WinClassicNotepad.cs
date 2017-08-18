using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;
using static TimeHACK.Engine.FileDialogBoxManager;
using System.IO;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicNotepad : UserControl
    {
        string CurrentFilePath = "";
        public WinClassicNotepad()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Font = new Font(TitleScreen.pfc.Families[0], 16F, FontStyle.Regular);
                item.BackColor = Color.Silver;
                item.BackgroundImage = Properties.Resources.sliversilver;
                item.BackgroundImageLayout = ImageLayout.Center;
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager wm = new WindowManager();
            wm.StartAboutBox95("Notepad", "Microsoft Notepad", Properties.Resources.WinClassicNotepadBig);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainText.SelectedText.Length >= 0) mainText.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainText.SelectedText.Length >= 0) mainText.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Text.Remove(mainText.SelectionStart, mainText.SelectedText.Length);
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string DateTime = System.DateTime.Now.ToString("HH:mm tt dd/MM/yyyy");
            mainText.AppendText(DateTime);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ActivateSaveFileDialog(".txt");
                string selectedPath = Program.OpenFileExplorerAsDialogAndReturnGivenPath();

                MessageBox.Show(selectedPath);
                if (selectedPath != "")
                {
                    mainText.Text = ReadTextFile(selectedPath);
                }
            }
            catch
            {
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFilePath == "")
            {
                // We aren't in a file right now

                SaveAs();
            } else {

                File.Delete(CurrentFilePath);
                SaveSystem.CreateWindowsFile(new FileInfo(CurrentFilePath).Directory.FullName, CurrentFilePath.Split('\\').Last(), mainText.Text, 12, mainText.Text.Length);
            }
        }

        // TO LEMPAMO: THIS FUCTION IS A FUNCTION ON IT'S OWN BECUASE TWO THINGS CALL IT - OK?
        void SaveAs()
        {
            try
            {
                ActivateSaveFileDialog(".txt");
                string selectedPath = Program.OpenFileExplorerAsDialogAndReturnGivenPath();

                if (selectedPath != "")
                {
                    SaveSystem.CreateWindowsFile(new FileInfo(selectedPath).Directory.FullName, selectedPath.Split('\\').Last(), mainText.Text, 12, mainText.Text.Length);
                    CurrentFilePath = selectedPath;
                }              
            }
            catch { }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
    }
}
