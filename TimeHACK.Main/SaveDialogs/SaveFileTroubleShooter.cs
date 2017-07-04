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
        public String log;
        Save savedata = new Save();
        String json;
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

        void WriteToLog(String toWrite)
        {
            log += toWrite + Environment.NewLine;
        }

        void BeginScan()
        {
            WriteToLog("Started scanning profile: " + SaveSystem.ProfileName);

            // Check if the main.save file exists

            if (!File.Exists(Path.Combine(SaveSystem.ProfileDirectory, "main.save")))
            {
                WriteToLog("ISSUE FOUND! File main.save doesn't exist");

                WriteToLog("Creating one...");

                SaveSystem.NewGame();

                WriteToLog("Created one!");

                EndScan(true);
                return;
            } else {
                WriteToLog("File main.save does exist - checking contents");

                // Read the main.save file
                json = File.ReadAllText(Path.Combine(SaveSystem.ProfileDirectory, "main.save"));

                savedata = Newtonsoft.Json.JsonConvert.DeserializeObject<Save>(json);

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

            if (!Directory.Exists(Path.Combine(SaveSystem.ProfileDirectory, "folders")))
            {
                WriteToLog("ISSUE FOUND! Directory 'folders' doesn't exist! Creating one...");
                Directory.CreateDirectory(Path.Combine(SaveSystem.ProfileDirectory, "folders"));
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

                File.WriteAllText(Path.Combine(SaveSystem.ProfileDirectory, "main.save"), Newtonsoft.Json.JsonConvert.SerializeObject(savedata));

                textBox1.Text = log;
            } else {
                label2.Text = "The issue has not been resolved, sorry";
                textBox1.Text = log;
            }
        }
    }
}
