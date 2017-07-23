using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeHACK.Engine;
using System.IO;

namespace TimeHACK.SaveDialogs
{
    public partial class SaveFileTroubleShooter : Form
    {
        public string log;
        Save savedata;
        string json;
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

            string savefile = Path.Combine(SaveSystem.ProfileDirectory, "main.save");

            if (!File.Exists(savefile))
            {
                WriteToLog("ISSUE FOUND! File main.save doesn't exist");

                WriteToLog("Creating one...");

                SaveSystem.NewGame();

                WriteToLog("Created one!");

                EndScan(true);
                return;
            } else {
                WriteToLog("File main.save does exist - checking contents");

                try
                {
                    savedata = SaveSystem.ReadSave(savefile);

                } catch
                {
                    WriteToLog("ISSUE FOUND! File main.save is unreadable");

                    WriteToLog("Sorry, there is no repairing it easily, your data will be lost");

                    string backupfile = Path.Combine(SaveSystem.ProfileDirectory, "main.backup");

                    if (Directory.Exists(backupfile)) Directory.Delete(backupfile);

                    File.Copy(savefile, backupfile);
                    SaveSystem.NewGame();

                    // Make sure the username is set

                    SaveSystem.CurrentSave.Username = SaveSystem.ProfileName;

                    WriteToLog($"The corrupt file has been stored in {backupfile}");

                    EndScan(true);
                }
                

                // Check the values

                if (savedata.CurrentOS == null || savedata.CurrentOS == "")
                {
                    WriteToLog("ISSUE FOUND! Data for CurrentOS is null! Giving default value...");
                    savedata.CurrentOS = "95";
                    EndScan(true);
                }

                if (savedata.ExperiencedStories == null)
                {
                    WriteToLog("ISSUE FOUND! Data for ExperiencedStories is null! Giving default value...");
                    savedata.ExperiencedStories = new List<string>();
                }

                if (savedata.ThemeName == null || savedata.ThemeName == "")
                {
                    WriteToLog("ISSUE FOUND! Data for ThemeName is null! Giving default value...");
                    savedata.ThemeName = "95normal";
                }
            }

            string folderspath = Path.Combine(SaveSystem.ProfileDirectory, "folders");

            if (!Directory.Exists(folderspath))
            {
                WriteToLog("ISSUE FOUND! Directory 'folders' doesn't exist! Creating one...");
                Directory.CreateDirectory(folderspath);
                SaveSystem.CheckFiles();
            }


        }

        void EndScan(bool successful)
        {
            pnlResolved.Visible = true;
            if (successful == true)
            {
                label2.Text = "The issue has been resolved.";
                // Set CurrentSave to the resolved one

                SaveSystem.CurrentSave = savedata;

                // Set the main.save file to the resolved one

                SaveSystem.WriteSave(Path.Combine(SaveSystem.ProfileDirectory, "main.save"), savedata);

                textBox1.Text = log;
            } else {
                label2.Text = "The issue has not been resolved, sorry";
                textBox1.Text = log;
            }
        }
    }
}
