// Define BINARY_SAVE before release so the player has
// to put some effort into cheating ;)
// During development, leave it undefined to use the
// easily modifiable JSON serialised format
//#define BINARY_SAVE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

#if BINARY_SAVE
using Whoa;
#endif

namespace Histacom2.Engine
{
    public static class SaveSystem
    {
        public static Save CurrentSave { get; set; }
        public static bool DevMode = false;
        public static Form troubleshooter;

        public static Theme currentTheme { get; set; }

        public static bool IsBinarySave =
#if BINARY_SAVE
            true;
#else
            false;
#endif

#if BINARY_SAVE
        private static readonly int magic = 0x76534854; // 'THSv'
#endif

        public static string GameDirectory
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Histacom2");
            }
        }

        public static string DataDirectory
        {
            get
            {
                return Path.Combine(GameDirectory, "Data");
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
#if BINARY_SAVE
        public static string ProfileFile = "main.whoa";
#else
        public static string ProfileFile = "main.json";
#endif

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
                return Path.Combine(ProfileFileSystemDirectory, "CDrive");
            }
        }

        public static string ProfileSettingsDirectory
        {
            get
            {
                return Path.Combine(ProfileMyComputerDirectory, "Documents and Settings");
            }
        }

        public static string ProfileDocumentsDirectory
        {
            get
            {
                return Path.Combine(ProfileMyComputerDirectory, "My Documents");                
            }
        }

        public static string ProfileProgramsDirectory
        {
            get
            {
                return Path.Combine(ProfileMyComputerDirectory, "Program Files");
            }
        }

        public static string ProfileWindowsDirectory
        {
            get
            {
                return Path.Combine(ProfileMyComputerDirectory, "Windows");
            }
        }

        public static void NewGame()
        {        
            var save = new Save();
            save.ExperiencedStories = new List<string>();
            if (DevMode)
            {
                if (ProfileName == "xpbad")
                {
                    save.CurrentOS = "xpbad";
                    save.ThemeName = "badxp";
                    currentTheme = new BadXPTheme();
                }
                else if (ProfileName == "98")
                {
                    save.CurrentOS = "98";
                    save.ThemeName = "default98";
                    currentTheme = new Default98Theme();
                }
                else
                {
                    save.CurrentOS = "95";
                    save.ThemeName = "default95";
                    save.BytesLeft = 536870912;
                    currentTheme = new Default95Theme();
                }
            }
            else
            {
                save.CurrentOS = "95";
                save.ThemeName = "default95";
                save.BytesLeft = 536870912;
                currentTheme = new Default95Theme();
            }
            CurrentSave = save;
                      
            CheckFiles();
            SaveGame();
        }

        public static void CheckFiles()
        {
            Directory.CreateDirectory(GameDirectory);
            Directory.CreateDirectory(DataDirectory);
            Directory.CreateDirectory(AllProfilesDirectory);
            Directory.CreateDirectory(ProfileDirectory);
            Directory.CreateDirectory(ProfileFileSystemDirectory);

            SaveDirectoryInfo(ProfileDirectory, "folders", false, "My Computer", false);            
            SaveDirectoryInfo(ProfileFileSystemDirectory, "CDrive", false, "C:", true);
            if (CurrentSave.CurrentOS == "95" || CurrentSave.CurrentOS == "98") SaveDirectoryInfo(ProfileMyComputerDirectory, "My Documents", false, "My Documents", true);
            if (CurrentSave.CurrentOS == "2000" || CurrentSave.CurrentOS == "ME") SaveDirectoryInfo(ProfileMyComputerDirectory, "Documents and Settings", false, "Documents and Settings", true);                    
            SaveDirectoryInfo(ProfileMyComputerDirectory, "Program Files", true, "Program Files", true);
            SaveDirectoryInfo(ProfileProgramsDirectory, "Accessories", false, "Accessories", true);
            SaveDirectoryInfo(ProfileProgramsDirectory, "Internet Explorer", true, "Internet Explorer", true);
            if (CurrentSave.CurrentOS == "95") SaveDirectoryInfo(ProfileProgramsDirectory, "The Microsoft Network", true, "The Microsoft Network", true);
            SaveDirectoryInfo(ProfileMyComputerDirectory, "Windows", true, "Windows", true);

            CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Accessories"), "wordpad.exe", "wordpad", 16, 183296);
            CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Internet Explorer"), "ie20.exe", "ie", 8, 512);
            CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Internet Explorer"), "lnfinst.exe", "iebrokeninstaller", 8, 512);
            if (CurrentSave.CurrentOS == "95") CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "The Microsoft Network"), "msnver.txt", "5900", 12, 4);
            
            CreateWindowsDirectory();
        }

        public static void CreateWindowsDirectory()
        {
            SaveDirectoryInfo(ProfileWindowsDirectory, "Application Data", true, "Application Data", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "System", true, "System", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Config", true, "Config", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Cursors", true, "Cursors", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Fonts", true, "Fonts", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Help", true, "Help", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Temp", true, "Temp", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Desktop", true, "Desktop", true);
            
            CreateWindowsFile(ProfileWindowsDirectory, "calc.exe", "calc", 13, 59392);
            CreateWindowsFile(ProfileWindowsDirectory, "emm386.exe", "emm386", 10, 125495);
            CreateWindowsFile(ProfileWindowsDirectory, "explorer.exe", "explorer", 0, 204288);
            CreateWindowsFile(ProfileWindowsDirectory, "notepad.exe", "notepad", 14, 34034);
            CreateWindowsFile(ProfileWindowsDirectory, "regedit.exe", "regedit", 15, 120320);
            CreateWindowsFile(ProfileWindowsDirectory, "win.com", "", 10, 22679);
            CreateWindowsFile(ProfileWindowsDirectory, "write.exe", "wordpad", 16, 5120);
        }

        public static void CreateWindowsFile(string filepath, string filename, string contents, int fileicon, int bytes)
        {
            File.WriteAllText(Path.Combine(filepath, filename), contents);
            THFileInfo info = new THFileInfo();
            info.Name = filename;
            info.FileIcon = fileicon;
            info.ByteSize = bytes;
            CurrentSave.BytesLeft -= bytes;
            UpdateDirectoryInfo(filepath, info);
        }

        public static void UpdateDirectoryInfo(string path, THFileInfo newfile)
        {
            SetDOSName(ref newfile);

            if (File.ReadAllText(Path.Combine(path, "_data.info")).Contains(newfile.DOSName)) return;
            FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(path, "_data.info")));
            fsfi.Files.Add(newfile);
            fsfi.ByteSize += newfile.ByteSize;

            string toWrite = JsonConvert.SerializeObject(fsfi, Formatting.Indented);

            File.WriteAllText(Path.Combine(path, "_data.info"), toWrite);
        }

        public static void RemoveFileFromDirectory(string path, string filename)
        {
            FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(path, "_data.info")));
            THFileInfo fi = fsfi.Files.Find((THFileInfo f) => { return f.Name == filename; });
            if (fi == null) return;

            fsfi.ByteSize -= fi.ByteSize;
            CurrentSave.BytesLeft += fi.ByteSize;

            fsfi.Files.Remove(fi);
            string toWrite = JsonConvert.SerializeObject(fsfi, Formatting.Indented);

            File.WriteAllText(Path.Combine(path, "_data.info"), toWrite);
        }

        public static void RemoveSubDirFromDirectory(string path, string dirname)
        {
            FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(path, "_data.info")));
            THDirInfo di = fsfi.SubDirs.Find((THDirInfo f) => { return f.Name == dirname; });
            if (di == null) return;

            // Find the bytesize of the folder

            FileSystemFolderInfo dirfsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(path, "_data.info")));

            fsfi.ByteSize -= dirfsfi.ByteSize;
            CurrentSave.BytesLeft += dirfsfi.ByteSize;

            fsfi.SubDirs.Remove(di);
            string toWrite = JsonConvert.SerializeObject(fsfi, Formatting.Indented);

            File.WriteAllText(Path.Combine(path, "_data.info"), toWrite);
        }

        public static string SetDOSName(ref THFileInfo file)
        {
            file.DOSName = file.Name.ToUpper().Replace("*", "").Replace("+", "").Replace(":", "").Replace(";", "").Replace(" ", "");
            if (file.DOSName.Contains("."))
            {
                string[] dos = file.DOSName.Split('.');

                if (dos.Count() > 2)
                {
                    List<string> dosb = dos.ToList();
                    dosb.RemoveRange(1, dos.Count() - 2);
                    dos = dosb.ToArray();
                }
                dos[1] = dos[1].Substring(0, 3);
                if (dos[0].Length > 8) dos[0] = dos[0].Substring(0, 6) + "~1";

                file.DOSName = dos[0] + "." + dos[1];
            }
            else if (file.DOSName.Length > 8) file.DOSName = file.DOSName.Substring(0, 6) + "~1";
            return file.DOSName;
        }

        public static void RenameDirectory(string path, string dirname, string newname)
        {
            FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(path, "_data.info")));
            THDirInfo di = fsfi.SubDirs.Find((THDirInfo f) => { return f.Name == dirname; });
            if (di == null) return;

            THDirInfo newDi = di;

            newDi.Name = newname;

            THFileInfo tmpfi = new THFileInfo();
            newDi.DOSName = SetDOSName(ref tmpfi);
            fsfi.SubDirs.Remove(di);
            fsfi.SubDirs.Add(newDi);
            string toWrite = JsonConvert.SerializeObject(fsfi, Formatting.Indented);

            File.WriteAllText(Path.Combine(path, "_data.info"), toWrite);
        }

        public static void RenameFile(string path, string filename, string newname)
        {
            FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(path, "_data.info")));
            THFileInfo fi = fsfi.Files.Find((THFileInfo f) => { return f.Name == filename; });
            if (fi == null) return;

            THFileInfo newFi = fi;

            newFi.Name = newname;

            THFileInfo tmpfi = new THFileInfo();
            newFi.DOSName = SetDOSName(ref tmpfi);
            fsfi.Files.Remove(fi);
            fsfi.Files.Add(newFi);
            string toWrite = JsonConvert.SerializeObject(fsfi, Formatting.Indented);

            File.WriteAllText(Path.Combine(path, "_data.info"), toWrite);
        }

        public static void UpgradeFileSystem(string newOS)
        {
            if (newOS == "98")
            {
                // We are upgrading from the old WinClassic file System to the new WinClassic filesystem!
                // All the above OSes share basically the same file layout!
                // (Excluding Documents And Settings) which is 2000 and ME only

                // Add Address Book into existance!

                SaveDirectoryInfo(ProfileProgramsDirectory, "Outlook Express", false, "Outlook Express", true);
                SaveDirectoryInfo(Path.Combine(ProfileWindowsDirectory, "Application Data"), "Microsoft", false, "Microsoft", true);
                SaveDirectoryInfo(Path.Combine(ProfileWindowsDirectory, "Application Data", "Microsoft"), "Address Book", false, "Address Book", true);
                CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Outlook Express"), "WAB.exe", "addressbook", 8, 512);

                // There is no "The Microsoft Network" folder!

                if (Directory.Exists(Path.Combine(ProfileProgramsDirectory, "The Microsoft Network"))) Directory.Delete(Path.Combine(ProfileProgramsDirectory, "The Microsoft Network"), true);
                if (Directory.Exists(Path.Combine(ProfileProgramsDirectory, "12padams"))) Directory.Delete(Path.Combine(ProfileProgramsDirectory, "12padams"), true);
                FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(ProfileProgramsDirectory, "_data.info")));
                foreach (THDirInfo dir in fsfi.SubDirs)
                {
                    if (dir.Name == "The Microsoft Network" || dir.Name == "12padams")
                    {
                        fsfi.SubDirs.Remove(dir);
                        break;
                    }
                }
                CurrentSave.BytesLeft = 916455424;
                string toWrite = JsonConvert.SerializeObject(fsfi, Formatting.Indented);

                File.WriteAllText(Path.Combine(ProfileProgramsDirectory, "_data.info"), toWrite);

                fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(ProfileWindowsDirectory, "_data.info")));

                Directory.Delete(Path.Combine(ProfileWindowsDirectory, "Desktop"), true);
                SaveDirectoryInfo(ProfileWindowsDirectory, "Desktop", true, "Desktop", true);
            }
        }

        public static void SaveDirectoryInfo(string parent, string dirname, bool isProtected, string label, bool allowback, bool updateParent = true)
        {
            if (File.Exists(Path.Combine(parent, dirname, "_data.info")) && Path.Combine(parent, dirname) != ProfileFileSystemDirectory) return;
            Directory.CreateDirectory(Path.Combine(parent, dirname));

            FileSystemFolderInfo info = new FileSystemFolderInfo();

            info.IsProtected = isProtected;
            info.Label = label;

            info.DOSLabel = info.Label.ToUpper().Replace("*", "").Replace("+", "").Replace(":", "").Replace(";", "").Replace(".", "").Replace(" ", "");
            if (info.DOSLabel.Length > 8) info.DOSLabel = info.DOSLabel.Substring(0, 6) + "~1";
            if (label == "C:") info.DOSLabel = "C:";
            info.AllowBack = allowback;
            info.Files = new List<THFileInfo>(256);
            info.SubDirs = new List<THDirInfo>(256);
            info.ByteSize = 0;

            if (updateParent)
            {
                if ((parent != ProfileDirectory))
                {
                    FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(parent, "_data.info")));
                    THDirInfo thd = new THDirInfo();
                    thd.Name = info.Label;
                    thd.DOSName = info.DOSLabel;
                    fsfi.SubDirs.Add(thd);

                    File.WriteAllText(Path.Combine(parent, "_data.info"), JsonConvert.SerializeObject(fsfi, Formatting.Indented));
                }
            }

            string toWrite = JsonConvert.SerializeObject(info, Formatting.Indented);

            File.WriteAllText(Path.Combine(Path.Combine(parent, dirname), "_data.info"), toWrite);
        }

        public static Save ReadSave(string fname)
        {
#if BINARY_SAVE
            using (var fobj = File.OpenRead(fname))
            using (var read = new BinaryReader(fobj))
            {
                if (read.ReadInt32() != magic)
                    throw new InvalidDataException("This is not a Histacom2 binary save");
                return Whoa.Whoa.DeserialiseObject<Save>(fobj, SerialisationOptions.NonSerialized);
            }
#else
            return JsonConvert.DeserializeObject<Save>(File.ReadAllText(fname));
#endif
        }

        public static void WriteSave(string fname, Save save)
        {
#if BINARY_SAVE
            using (var fobj = File.OpenWrite(fname))
            using (var write = new BinaryWriter(fobj))
            {
                write.Write(magic);
                Whoa.Whoa.SerialiseObject(fobj, save, SerialisationOptions.NonSerialized);
            }
#else
            // Serialize the save to JSON.
            File.WriteAllText(fname, JsonConvert.SerializeObject(save, Formatting.Indented));
#endif
        }

        public static void SaveGame()
        {
            WriteSave(Path.Combine(ProfileDirectory, ProfileFile), CurrentSave);
        }

        public static bool LoadSave()
        {
            string savefile = Path.Combine(ProfileDirectory, ProfileFile);
            try
            {
                CurrentSave = ReadSave(savefile);
            }
            catch
            {
                MessageBox.Show("WARNING! It looks like this save is corrupt! We will now open the Save troubleshooter");

                troubleshooter.ShowDialog();
            }
            return true;
        }

        public static byte[] GetAchievements()
        {
            byte[] byt = new byte[] { 0, // 0 - Piracy Ending
                                    0, // 1 - End of Internet Ending
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 20 - Minesweeper Hard Mode
            if (DevMode) File.WriteAllBytes(Path.Combine(DataDirectory, "achieved.thack"), byt);

            if (File.Exists(Path.Combine(DataDirectory, "achieved.thack"))) byt = File.ReadAllBytes(Path.Combine(DataDirectory, "achieved.thack"));
            else File.WriteAllBytes(Path.Combine(DataDirectory, "achieved.thack"), byt);

            return byt;
        }

        public static void SaveAchievement(int achievementID)
        {
            if (!File.Exists(Path.Combine(DataDirectory, "achieved.thack"))) File.WriteAllBytes(Path.Combine(DataDirectory, "achieved.thack"), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            byte[] byt = File.ReadAllBytes(Path.Combine(DataDirectory, "achieved.thack"));
            byt[achievementID] = 1;
            File.WriteAllBytes(Path.Combine(DataDirectory, "achieved.thack"), byt);
        }

        public static void SetTheme()
        {
            switch (CurrentSave.ThemeName)
            {
                case "default95":
                    currentTheme = new Default95Theme();
                    break;
                case "default98":
                    currentTheme = new Default98Theme();
                    break;
                case "dangeranimals":
                    currentTheme = new DangerousCreaturesTheme();
                    break;
                case "insidepc":
                    currentTheme = new InsideComputerTheme();
                    break;
                case "badxp":
                    currentTheme = new BadXPTheme();
                    break;
                case "default95plus":
                    currentTheme = new Default95PlusTheme();
                    break;
                case "goldenera":
                    currentTheme = new GoldenEraTheme();
                    break;
                case "Leo":
                    currentTheme = new LeoTheme();
                    break;
                case "Mystery":
                    currentTheme = new MysteryTheme();
                    break;
                case "Nature":
                    currentTheme = new NatureTheme();
                    break;
                case "Science":
                    currentTheme = new ScienceTheme();
                    break;
                case "Sports":
                    currentTheme = new SportsTheme();
                    break;
                case "The60":
                    currentTheme = new The60Theme();
                    break;
                case "Travel":
                    currentTheme = new TravelTheme();
                    break;
                case "MoreWin":
                    currentTheme = new MoreWinTheme();
                    break;
            }
        }
    }

    public class Save
    {
        // To maintain binary save compatibility,
        // add all new properties/fields to the end and don't remove any.

        public string Username { get; set; }
        public string CurrentOS { get; set; }

        // public Dictionary<string, bool> InstalledPrograms { get; set; } InstallProgram is no longer needed... we have that data in the FileSystem

        public List<string> ExperiencedStories { get; set; }
        public bool FTime95 { get; set; }
        public int mineSweepE { get; set; } = 999;
        public int mineSweepI { get; set; } = 999;
        public int mineSweepH { get; set; } = 999;
        public string ThemeName { get; set; }
        public int BytesLeft { get; set; }
        public Theme customTheme { get; set; }
        public bool FTime98 { get; set; }
        public bool[] installed95 { get; set; } = new bool[7]; // 0: WC98, 1: FTP, 2: SR, 3: EB, 4: SKNDWS, 5: TD0.1, 6: GTN
    }

    public class FileSystemFolderInfo
    {
        public bool IsProtected { get; set; }
        public string Label { get; set; }
        public string DOSLabel { get; set; }
        public bool AllowBack { get; set; }
        public int ByteSize { get; set; }
        public List<THFileInfo> Files { get; set; }
        public List<THDirInfo> SubDirs { get; set; }
    }

    public class THFileInfo
    {
        public string Name { get; set; }
        public string DOSName { get; set; }
        public int FileIcon { get; set; }
        public int ByteSize { get; set; }
    }

    public class THDirInfo
    {
        public string Name { get; set; }
        public string DOSName { get; set; }
    }
}
