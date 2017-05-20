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
        public static Save CurrentSave { get; private set; }
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
            if (!Directory.Exists(GameDirectory))
                Directory.CreateDirectory(GameDirectory);

            if (!Directory.Exists(AllProfilesDirectory))
                Directory.CreateDirectory(AllProfilesDirectory);

            if (!Directory.Exists(ProfileDirectory))
                Directory.CreateDirectory(ProfileDirectory);

            var save = new Save();
            save.ExperiencedStories = new List<string>();
            save.InstalledPrograms = new Dictionary<string, bool>();
            CurrentSave = save;
            SaveGame();
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
        public Dictionary<string, bool> InstalledPrograms { get; set; }
        public List<string> ExperiencedStories { get; set; }
    }
}
