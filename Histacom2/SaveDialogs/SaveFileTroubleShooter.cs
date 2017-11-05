using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Histacom2.Engine;
using System.IO;

namespace Histacom2.SaveDialogs
{
    public partial class SaveFileTroubleShooter : Form
    {
        public string log;
        Save savedata;
        public SaveFileTroubleShooter()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveFileTroubleShooter_Load(object sender, EventArgs e)
        {
            BeginScan();
        }

        void WriteToLog(string toWrite)
        {
            log += toWrite + Environment.NewLine;
        }

        void BeginScan()
        {
            WriteToLog("Started scanning profile: " + SaveSystem.ProfileName);

            // Check if the main.save file exists

            string savefile = Path.Combine(SaveSystem.ProfileDirectory, SaveSystem.ProfileFile);
            string oldsavefile = Path.Combine(SaveSystem.ProfileDirectory, "old" + SaveSystem.ProfileFile);

            if (!File.Exists(savefile))
            {
                WriteToLog($"ISSUE FOUND! File {SaveSystem.ProfileFile} doesn't exist");

                WriteToLog("Creating one...");

                SaveSystem.NewGame();

                WriteToLog("Created one!");

                EndScan(true);
                return;
            } else {
                WriteToLog($"File {SaveSystem.ProfileFile} does exist - checking contents");
                bool readable = false;

                try
                {
                    savedata = SaveSystem.ReadSave(savefile);
                    readable = true;
                } catch
                {
                    WriteToLog("Save file cannot be read - scanning each line and examining them...");
                    // Take a little look at the file?

                    // But first let's just create a measure of how the JSON SHOULD look
                    if (!SaveSystem.IsBinarySave)
                    {
                        if (File.Exists(oldsavefile)) File.Delete(oldsavefile);
                        File.Copy(savefile, oldsavefile);

                        SaveSystem.NewGame();
                        string[] fileLines = File.ReadAllText(oldsavefile).Split('\n');
                        string[] shouldBeLines = File.ReadAllText(savefile).Split('\n');
                        int i = 0;

                        string newJson = "";

                        foreach (string element in fileLines)
                        {
                            element.Replace("\n", "").Replace("\r", "");
                        }

                        foreach (string line in fileLines)
                        {
                            if (!line.StartsWith("{"))
                            {
                                if (!line.StartsWith("}"))
                                {
                                    try {
                                        // We will attempt to deserialize this line

                                        Newtonsoft.Json.JsonConvert.DeserializeObject("{" + $"{Environment.NewLine}{line}{Environment.NewLine}" + "}");

                                        // It worked! This line is not the problem!

                                        newJson += $"{Environment.NewLine}{fileLines[i]}";

                                        WriteToLog($"The line {fileLines[i]} is fine!");
                                    } catch {
                                        // If it failed to read this line the this is the line that's causing problems!

                                        try { newJson += $"{Environment.NewLine}{shouldBeLines[i]}";
                                            WriteToLog($"ISSUE FOUND! The line {fileLines[i]} was corrupt - it has been reset to default settings!");
                                        } catch { WriteToLog($"ISSUE FOUND! A line was unneeded - it has been removed as it should!"); } // The reason I'm catching that is in case someone adds a line at the end of the file or something
                                    }
                                }
                            }
                            i++;
                        }

                        // After all that let's see if we fixed the file - but first, add the "{" and "}" in!

                        newJson = "{" + $"{Environment.NewLine}{newJson}{Environment.NewLine}" + "}";

                        // Now let's test it

                        try
                        {
                            savedata = Newtonsoft.Json.JsonConvert.DeserializeObject<Save>(newJson);

                            WriteToLog("Save file successfully recovered!");

                            File.WriteAllText(savefile, newJson);
                            readable = true;

                            if (File.Exists(oldsavefile)) File.Delete(oldsavefile);
                            EndScan(true);
                        } catch {
                            // It's unusable...

                            WriteToLog($"ISSUE FOUND! File {SaveSystem.ProfileFile} is unreadable");

                            WriteToLog("Sorry, there is no repairing it easily, your data will be lost");

                            string backupfile = savefile + ".bak";

                            if (Directory.Exists(backupfile)) Directory.Delete(backupfile);

                            File.Copy(savefile, backupfile);
                            SaveSystem.NewGame();

                            // Make sure the username is set

                            SaveSystem.CurrentSave.Username = SaveSystem.ProfileName;
                            SaveSystem.SaveGame();

                            WriteToLog($"The corrupt file has been stored in {backupfile}");

                            EndScan(true);
                        }
                    }
                }


                // Check the values if it was readable

                if (readable) CheckValues();
                    
            }

            string folderspath = Path.Combine(SaveSystem.ProfileDirectory, "folders");

            if (!Directory.Exists(folderspath))
            {
                WriteToLog("ISSUE FOUND! Directory 'folders' doesn't exist! Creating one...");
                Directory.CreateDirectory(folderspath);
                SaveSystem.CheckFiles();
                EndScan(true);
            }

            EndScan(true);
        }

        private void CheckValues()
        {
            foreach (var field in typeof(Save).GetFields())
            {
                if (field.GetValue(savedata) is string) if (field.GetValue(savedata).ToString() == null) { field.SetValue(savedata, ""); continue; }
                if (field.GetValue(savedata) is Theme) if (field.GetValue(savedata) == null) { field.SetValue(savedata, new Default95Theme()); continue; }
                if (field.GetValue(savedata) is List<string>) if (field.GetValue(savedata) == null) { field.SetValue(savedata, new List<string>()); }
            }
        }

        void EndScan(bool successful)
        {
            pnlResolved.Visible = true;
            label1.Hide();
            if (successful)
            {
                label2.Text = "The issue has been resolved.";

                textBox1.Text = log;
            } else {
                label2.Text = "The issue has not been resolved, sorry.";
                textBox1.Text = log;
            }
        }
    }
}
