using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TimeHACK.Engine
{
    public static class SaveSystem
    {
        public static Save CurrentSave { get; set; }
        public static FileSystemFolderInfo filesystemflinfo { get; set; }
        public static Boolean DevMode = false;

        public static string GameDirectory
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TimeHACK");
            }
        }

        public static string AllProfilesDirectory
        {
            get
            {
                return Path.Combine(GameDirectory, "Profiles");
            }
        }

        public static string ProfileName = "";
        public static string ProfileFile = "main.save";

        public static string ProfileDirectory
        {
            get
            {
                return Path.Combine(GameDirectory, Path.Combine("Profiles", ProfileName));
            }
        }

        public static string ProfileFileSystemDirectory
        {
            get
            {
                return Path.Combine(ProfileDirectory, "folders");
            }
        }

        public static string ProfileMyComputerDirectory
        {
            get
            {
                return Path.Combine(ProfileFileSystemDirectory, "Computer");
            }
        }

        public static string ProfileSettingsDirectory
        {
            get
            {
                    return Path.Combine(ProfileMyComputerDirectory, "Settings");
            }
        }

        public static string ProfileDocumentsDirectory
        {
            get
            {
                return Path.Combine(ProfileMyComputerDirectory, "Doc");                
            }
        }

        public static string ProfileProgramsDirectory
        {
            get
            {
                return Path.Combine(ProfileMyComputerDirectory, "Prog");
            }
        }

        public static string ProfileWindowsDirectory
        {
            get
            {
                return Path.Combine(ProfileMyComputerDirectory, "Win");
            }
        }

        public static bool LoadSave()
        {
            // ON A FINAL RELEASE USE THE "FINAL RELEASE THINGS"
            #region Final Release Things
            //Read base64 string from file
            //string b64 = File.ReadAllText(Path.Combine(ProfileDirectory, ProfileFile));
            //Get Unicode byte array
            //byte[] bytes = Convert.FromBase64String(b64);
            //Decode the Unicode
            //string json = Encoding.UTF8.GetString(bytes);
            //Deserialize save object.
            #endregion
            // USE THE THINGS IN THE "DEVELOPER THINGS" FOR A DEVELOPMENT RELEASE
            #region Developer Things
            string json = File.ReadAllText(Path.Combine(ProfileDirectory, ProfileFile));
            #endregion
            CurrentSave = JsonConvert.DeserializeObject<Save>(json);
            return true;
        }

        public static void NewGame()
        {

            //TODO: User must set a username....somehow            

            var save = new Save();
            save.ExperiencedStories = new List<string>();
            save.CurrentOS = "95";
            CurrentSave = save;

            CheckFiles();
            SaveGame();
        }

        public static void CheckFiles()
        {
            if (!Directory.Exists(GameDirectory))
                Directory.CreateDirectory(GameDirectory);

            if (!Directory.Exists(AllProfilesDirectory))
                Directory.CreateDirectory(AllProfilesDirectory);

            if (!Directory.Exists(ProfileDirectory))
                Directory.CreateDirectory(ProfileDirectory);

            if (!Directory.Exists(ProfileFileSystemDirectory))
                Directory.CreateDirectory(ProfileFileSystemDirectory);

            SaveDirectoryInfo(ProfileFileSystemDirectory, false, "My Computer", false);            
            SaveDirectoryInfo(ProfileMyComputerDirectory, false, "Win95", true);
            if (CurrentSave.CurrentOS == "95") SaveDirectoryInfo(ProfileDocumentsDirectory, false, "My Documents", true);
            if (CurrentSave.CurrentOS != "95") SaveDirectoryInfo(ProfileSettingsDirectory, false, "Documents and Settings", true);
            SaveDirectoryInfo(ProfileProgramsDirectory, true, "Program Files", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, true, "Windows", true);
        }

        public static void SaveDirectoryInfo(String directory, Boolean isProtected, String label, Boolean allowback)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            FileSystemFolderInfo info = new FileSystemFolderInfo();

            info.Isprotected = isProtected;
            info.label = label;
            info.allowback = allowback;

            string toWrite = JsonConvert.SerializeObject(info, Formatting.Indented);

            File.WriteAllText(Path.Combine(directory, "_data.info"), toWrite);
        }


        public static void SaveGame()
        {
            //Serialize the save to JSON.
            string json = JsonConvert.SerializeObject(CurrentSave, Formatting.Indented);

            // ADD THE TWO LINES OF CODE BELOW ON A FINAL RELEASE
            //Get JSON bytes (Unicode format).
            //var bytes = Encoding.UTF8.GetBytes(json);
            //Encode the array into Base64.
            //string b64 = Convert.ToBase64String(bytes);
            //Write to disk.

            // CHANGE THE "JSON" TO "B64" ON A FINAL RELEASE!
            File.WriteAllText(Path.Combine(ProfileDirectory, ProfileFile), json);
        }
    }

    public class Save
    {
        public string Username { get; set; }

        public string CurrentOS { get; set; }
        // public Dictionary<string, bool> InstalledPrograms { get; set; } InstallProgram is no longer needed... we have that data in the FileSystem
        public List<string> ExperiencedStories { get; set; }
    }

    public class FileSystemFolderInfo
    {
        public Boolean Isprotected { get; set; }
        public String label { get; set; }
        public Boolean allowback { get; set; }
    }
}
