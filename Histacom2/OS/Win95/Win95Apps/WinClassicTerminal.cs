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
using System.Reflection;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Histacom2.Engine;
using System.Globalization;

namespace Histacom2.OS.Win95.Win95Apps
{
    public partial class WinClassicTerminal : UserControl
    {
        public WindowManager wm = new WindowManager();

        public int currentLine = 4;
        public static string prefix = @"C:\WINDOWS>";
        public static string workingDir = $"{SaveSystem.ProfileWindowsDirectory}";
        public string output = "";
        public bool cls = false;
        public WinClassicTerminal(bool readOnly)
        {
            InitializeComponent();

            // Paint the classic borders
            btnCopy.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            btnFont.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            btnMark.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            btnNothing.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            btnPaste.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            btnSettings.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);
            sizeSel.Paint += (sender, args) => Paintbrush.PaintClassicBorders(sender, args, 2);

            // Set the default index to "Auto"
            sizeSel.SelectedIndex = 0;

            // Set the font and append the prefix text
            cmdPrompt.Font = new Font(TitleScreen.pfc.Families[1], 12F, FontStyle.Regular);

            cmdPrompt.BringToFront();

            if (readOnly)
            {
                actionPanel.Hide();
                cmdPrompt.ReadOnly = true;
                if (SaveSystem.CurrentSave.CurrentOS == "xpbad")
                {
                    cmdPrompt.BorderStyle = BorderStyle.None;
                    cmdPrompt.ScrollBars = RichTextBoxScrollBars.Vertical;
                }
            }
            else
            {
                cmdPrompt.AppendText("\nMicrosoft<R> Windows 95\n   <C>Copyright Microsoft Corp 1981-1995.\n\n");
                cmdPrompt.AppendText(prefix);
            }
        }
        /// <summary>
        /// Write text to the Terminal and create a new line. Very similar to the Win32 Console.WriteLine Function.
        /// </summary>
        /// <param name="Text"></param>
        public void WriteLine(string Text)
        {
            cmdPrompt.AppendText(Text + "\n");
            cmdPrompt.Update();
            cmdPrompt.ScrollToCaret();
        }

        /// <summary>
        /// Write text to the Terminal. Very similar to the Win32 Console.Write Function.
        /// </summary>
        /// <param name="Text"></param>
        public void Write(string Text)
        {
            cmdPrompt.AppendText(Text);
            cmdPrompt.Update();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (cmdPrompt.SelectedText.Length > 0)
                Clipboard.SetText(cmdPrompt.SelectedText); // Set the clipboard text to the selection of the RichTextBox
            else
                wm.StartInfobox95("ERROR", "You need to select something to copy.", Engine.Template.InfoboxType.Error, Engine.Template.InfoboxButtons.OK); // Display an error message if the length is 0 
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() != "")
                Write(Clipboard.GetText()); // Write the contents of the Clipboard text in the RichTextBox
            else
                wm.StartInfobox95("ERROR", "You need to have something in your clipboard to paste.", Engine.Template.InfoboxType.Error, Engine.Template.InfoboxButtons.OK); // Display an error message if the clipboard is null/empty
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            wm.StartInfobox95("INFO", "This feature has not been implemented yet. Stay tuned! -Jason", Engine.Template.InfoboxType.Info, Engine.Template.InfoboxButtons.OK);
            //TODO: Well, add the settings...
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //TODO: Add font UC(?)
        }
        
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Return)
            {
                string[] cmd = cmdPrompt.Lines[currentLine].Substring(prefix.Length).Split(' ');

                switch (cmd[0])
                {
                    case "dir":
                        FileSystemFolderInfo dirinfo = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(workingDir, "_data.info")));
                        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                        nfi.NumberDecimalDigits = 0;
                        output = $" Volume in drive C has no label\n Volume Serial Number is 0000-0000\n Directory of {prefix.Replace(">", "")}\n\n";
                        foreach (THDirInfo thd in dirinfo.SubDirs)
                        {
                            string dirline = new string(' ', 50);
                            dirline = dirline.Insert(0, thd.DOSName);
                            dirline = dirline.Insert(15, "<DIR>");
                            output += dirline + Environment.NewLine;
                        }
                        foreach (THFileInfo thfi in dirinfo.Files)
                        {
                            string[] dosname = thfi.DOSName.Split('.');
                            string dirline = new string(' ', 50);
                            dirline = dirline.Insert(0, dosname[0]);
                            dirline = dirline.Insert(9, dosname[1]);
                            dirline = dirline.Insert(26 - thfi.ByteSize.ToString("N", nfi).Length, thfi.ByteSize.ToString("N", nfi));
                            output += dirline + Environment.NewLine;
                        }
                        string fline = new string(' ', 50);
                        fline = fline.Insert(10 - dirinfo.Files.Count.ToString("N", nfi).Length, dirinfo.Files.Count.ToString("N", nfi));
                        fline = fline.Insert(11, "file(s)");
                        fline = fline.Insert(33 - dirinfo.ByteSize.ToString("N", nfi).Length, dirinfo.ByteSize.ToString("N", nfi));
                        fline = fline.Insert(34, "bytes");
                        output += fline + Environment.NewLine;

                        string dline = new string(' ', 50);
                        dline = dline.Insert(10 - dirinfo.SubDirs.Count.ToString("N", nfi).Length, dirinfo.SubDirs.Count.ToString("N", nfi));
                        dline = dline.Insert(11, "dir(s)");
                        dline = dline.Insert(33 - SaveSystem.CurrentSave.BytesLeft.ToString("N", nfi).Length, SaveSystem.CurrentSave.BytesLeft.ToString("N", nfi));
                        dline = dline.Insert(34, "bytes free");
                        output += dline;

                        break;
                    case "cls":
                        currentLine = 0;
                        cmdPrompt.Clear();
                        cls = true;
                        output = prefix;
                        break;
                    default:
                        // Temporary CMD redirect
                        /*
                        Process p = new Process();

                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.WorkingDirectory = startupDir;
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.Arguments = $"/C {cmdPrompt.Lines[currentLine].Substring(prefix.Length)}";
                        p.Start();

                        output = p.StandardOutput.ReadToEnd();
                        */
                        output = "Bad command or file name";

                        break;
                }

                cmdPrompt.Focus();
                cmdPrompt.AppendText($"\n{output}"); // Append the command output
                string[] stringSeparators = new string[] { "\n" };
                string[] lines = output.Split(stringSeparators, StringSplitOptions.None);
                foreach (string s in lines)
                {
                    currentLine++;
                }
                if (!cls)
                {
                    cmdPrompt.AppendText($"\n\n{prefix}"); // Append the text to the RichTextBox
                    currentLine = currentLine + 3;
                }
                cls = false;
            }  
        }
    }
}
