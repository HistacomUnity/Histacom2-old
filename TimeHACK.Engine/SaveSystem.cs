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

        public static string GameDirectory
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TimeHACK");
            }
        }

        public static string ProfileDirectory
        {
            get
            {
                return Path.Combine(GameDirectory, "Profiles");
            }
        }

        public static bool LoadSave()
        {
            if(File.Exists(Path.Combine(ProfileDirectory, "user.save")))
            {
                //Read base64 string from file
                string b64 = File.ReadAllText(Path.Combine(ProfileDirectory, "user.save"));
                //Get Unicode byte array
                byte[] bytes = Convert.FromBase64String(b64);
                //Decode the Unicode
                string json = Encoding.UTF8.GetString(bytes);
                //Deserialize save object.
                CurrentSave = JsonConvert.DeserializeObject<Save>(json);
                return true;
            }
            else
            {
                NewGame();
                return false;
            }
        }

        public static void NewGame()
        {
            //TODO: User must set a username....somehow
            if (!Directory.Exists(GameDirectory))
                Directory.CreateDirectory(GameDirectory);

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
            string json = JsonConvert.SerializeObject(CurrentSave);
            //Get JSON bytes (Unicode format).
            var bytes = Encoding.UTF8.GetBytes(json);
            //Encode the array into Base64.
            string b64 = Convert.ToBase64String(bytes);
            //Write to disk.
            File.WriteAllText(Path.Combine(ProfileDirectory, "user.save"), b64);
        }
    }

    public class Save
    {
        public string Username { get; set; }
        public Dictionary<string, bool> InstalledPrograms { get; set; }
        public List<string> ExperiencedStories { get; set; }
    }
}
