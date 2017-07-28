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
using TimeHACK.Engine;
using System.Globalization;

namespace TimeHACK.OS.Win95.Win95Apps
{
    public partial class WinClassicTerminal : UserControl
    {
        public Engine.WindowManager wm = new Engine.WindowManager();

        public int currentLine = 4;
        public static string prefix = @"C:\WINDOWS>";
        public static string workingDir = $"{Engine.SaveSystem.ProfileWindowsDirectory}";
        public string output = "";

        public WinClassicTerminal(bool readOnly)
        {
            InitializeComponent();

            // Paint the classic borders
            btnCopy.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnFont.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnMark.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnNothing.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnPaste.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            btnSettings.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);
            sizeSel.Paint += (sender, args) => Engine.Paintbrush.PaintClassicBorders(sender, args, 2);

            // Set the default index to "Auto"
            sizeSel.SelectedIndex = 0;

            // Set the font and append the prefix text
            cmdPrompt.Font = new Font(TitleScreen.pfc.Families[1], 12F, FontStyle.Regular);

            cmdPrompt.BringToFront();

            if (readOnly)
            {
                actionPanel.Hide();
                cmdPrompt.ReadOnly = true;
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
            this.Update();
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
                wm.StartInfobox95("ERROR", "You need to select something to copy.", Properties.Resources.Win95Error); // Display an error message if the length is 0 
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() != "")
                Write(Clipboard.GetText()); // Write the contents of the Clipboard text in the RichTextBox
            else
                wm.StartInfobox95("ERROR", "You need to have something in your clipboard to paste.", Properties.Resources.Win95Error); // Display an error message if the clipboard is null/empty
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            wm.StartInfobox95("INFO", "This feature has not been implemented yet. Stay tuned! -Jason", Properties.Resources.Win95Info);
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
                        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                        nfi.NumberDecimalDigits = 0;
                        output = $" Volume in drive C has no label\n Volume Serial Number is 0000-0000\n Directory of {prefix.Replace(">", "")}\n\n";
                        foreach (THDirInfo thd in JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(workingDir, "_data.info"))).SubDirs)
                        {
                            string dirline = new string(' ', 50);
                            dirline = dirline.Insert(0, thd.DOSName);
                            dirline = dirline.Insert(15, "<DIR>");
                            output += dirline + Environment.NewLine;
                        }
                        foreach (THFileInfo thfi in JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(workingDir, "_data.info"))).Files)
                        {
                            string[] dosname = thfi.DOSName.Split('.');
                            string dirline = new string(' ', 50);
                            dirline = dirline.Insert(0, dosname[0]);
                            dirline = dirline.Insert(9, dosname[1]);
                            dirline = dirline.Insert(26 - thfi.ByteSize.ToString("N", nfi).Length, thfi.ByteSize.ToString("N", nfi));
                            output += dirline + Environment.NewLine;
                        }
                        
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

                int numLines = output.Split('\n').Length; // Get the number of lines from the command output
                currentLine = currentLine + 2 + numLines; // Set the current line to equals the previous line plus 2 plus the number of lines from the command

                cmdPrompt.AppendText($"\n\n{prefix}"); // Append the text to the RichTextBox
            }  
        }
    }
}
