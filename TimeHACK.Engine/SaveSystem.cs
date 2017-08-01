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

namespace TimeHACK.Engine
{
    public static class SaveSystem
    {
        public static Save CurrentSave { get; set; }
        public static FileSystemFolderInfo filesystemflinfo { get; set; }
        public static bool DevMode = false;
        public static Form troubleshooter;

        public static Theme currentTheme { get; set; }

#if BINARY_SAVE
        private static readonly byte[] magic = Encoding.UTF8.GetBytes("THSv");
        private static readonly IOrderedEnumerable<System.Reflection.PropertyInfo> properties = typeof(Save).GetProperties().OrderBy(p => (p.GetCustomAttributes(typeof(OrderAttribute), false).SingleOrDefault() as OrderAttribute).Order);
#endif

        public static string GameDirectory
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TimeHACK");
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
            if (DevMode == true)
            {
                if (ProfileName == "98")
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
            SaveDirectoryInfo(ProfileProgramsDirectory, "The Microsoft Network", true, "The Microsoft Network", true);
            SaveDirectoryInfo(ProfileMyComputerDirectory, "Windows", true, "Windows", true);

            CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Accessories"), "wordpad.exe", "wordpad");
            CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Internet Explorer"), "ie20.exe", "ie");
            CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Internet Explorer"), "lnfinst.exe", "iebrokeninstaller");
            CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "The Microsoft Network"), "msnver.txt", "5900");
            
            CreateWindowsDirectory();
        }

        public static void CreateWindowsDirectory()
        {
            SaveDirectoryInfo(ProfileWindowsDirectory, "System", true, "System", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Config", true, "Config", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Cursors", true, "Cursors", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Fonts", true, "Fonts", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Help", true, "Help", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Temp", true, "Temp", true);
            SaveDirectoryInfo(ProfileWindowsDirectory, "Desktop", true, "Desktop", true);

            CreateWindowsFile(ProfileWindowsDirectory, "calc.exe", "calc", 13, 59392);
            CreateWindowsFile(ProfileWindowsDirectory, "explorer.exe", "explorer", 0, 204288);
            CreateWindowsFile(ProfileWindowsDirectory, "notepad.exe", "notepad", 14, 34034);
            CreateWindowsFile(ProfileWindowsDirectory, "regedit.exe", "regedit", 15, 120320);
        }

        public static void CreateWindowsFile(string filepath, string filename, string contents, int fileicon = 8, int bytes = 512)
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
            newfile.DOSName = newfile.Name.ToUpper().Replace("*", "").Replace("+", "").Replace(":", "").Replace(";", "").Replace(" ", "");
            string[] dos = newfile.DOSName.Split('.');

            if (dos.Count() > 2)
            {
                List<string> dosb = dos.ToList();
                dosb.RemoveRange(1, dos.Count() - 2);
                dos = dosb.ToArray();
            }
            dos[1] = dos[1].Substring(0, 3);
            if (dos[0].Length > 8) dos[0] = dos[0].Substring(0, 6) + "~1";

            newfile.DOSName = dos[0] + "." + dos[1];

            if (File.ReadAllText(Path.Combine(path, "_data.info")).Contains(newfile.DOSName)) return;
            FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(path, "_data.info")));
            fsfi.Files.Add(newfile);
            fsfi.ByteSize += newfile.ByteSize;

            string toWrite = JsonConvert.SerializeObject(fsfi, Formatting.Indented);

            File.WriteAllText(Path.Combine(path, "_data.info"), toWrite);
        }

        public static void UpgradeFileSystem(string oldOS, string newOS)
        {
            switch (oldOS)
            {
                case "95":
                    if (newOS == "98" || newOS == "2000" || newOS == "ME")
                    {
                        // We are upgrading from the old WinClassic file System to the new WinClassic filesystem!
                        // All the above OSes share basically the same file layout!
                        // (Excluding Documents And Settings) which is 2000 and ME only

                        // Add Address Book into existance!

                        SaveDirectoryInfo(ProfileProgramsDirectory, "Outlook Express", false, "Outlook Express", true);
                        CreateWindowsFile(Path.Combine(ProfileProgramsDirectory, "Outlook Express"), "WAB.exe", "addressbook");

                        // There is no "The Microsoft Network" folder!

                        if (Directory.Exists(Path.Combine(ProfileProgramsDirectory, "The Microsoft Network"))) Directory.Delete(Path.Combine(ProfileProgramsDirectory, "The Microsoft Network"), true);
                    }
                    break;
            }
        }

        public static void SaveDirectoryInfo(string parent, string dirname, bool isProtected, string label, bool allowback)
        {
            if (Directory.Exists(Path.Combine(parent, dirname)) && Path.Combine(parent, dirname) != ProfileFileSystemDirectory) return;
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

            if (parent != ProfileDirectory)
            {
                FileSystemFolderInfo fsfi = JsonConvert.DeserializeObject<FileSystemFolderInfo>(File.ReadAllText(Path.Combine(parent, "_data.info")));
                THDirInfo thd = new THDirInfo();
                thd.Name = info.Label;
                thd.DOSName = info.DOSLabel;
                fsfi.SubDirs.Add(thd);

                File.WriteAllText(Path.Combine(parent, "_data.info"), JsonConvert.SerializeObject(fsfi, Formatting.Indented));
            }

            string toWrite = JsonConvert.SerializeObject(info, Formatting.Indented);

            File.WriteAllText(Path.Combine(Path.Combine(parent, dirname), "_data.info"), toWrite);
        }

#if BINARY_SAVE
        // Be careful with this... it trusts that the calling code has already checked
        // that T can be written by BinaryWriter.
        // No generics, because that'd be near-impossible to read back.
        private static void WriteList<T>(BinaryWriter write, List<T> list)
        {
            if (list == null)
                write.Write(0);
            else
            {
                write.Write(list.Count);
                foreach (T obj in list)
                    ((dynamic)write).Write(obj);
            }
        }

        private static List<T> ReadList<T>(BinaryReader read, string reader)
        {
            int count = read.ReadInt32();
            var ret = new List<T>(count);
            var function = typeof(BinaryReader).GetMethod(reader);
            for (int i = 0; i < count; i++)
                ret.Add((T) function.Invoke(read, new object[] { }));
            return ret;
        }

        private static void WriteBitfield(Stream fobj, IEnumerable<bool> bools)
        {
            sbyte bit = 7;
            int cur = 0;
            var bitfields = new byte[bools.Count() / 8 + 1];
            foreach (bool mybool in bools)
            {
                if (mybool)
                    bitfields[cur] |= (byte) (1 << bit);
                bit--;
                if (bit < 0)
                {
                    bit = 7;
                    cur++;
                }
            }
            fobj.Write(bitfields, 0, bitfields.Length);
        }

        private static List<bool> ReadBitfield(Stream fobj, int count)
        {
            sbyte bit = 7;
            int cur = 0;
            var bitfields = new byte[count / 8 + 1];
            var bools = new List<bool>(count);
            byte val = (byte) fobj.ReadByte();
            fobj.Read(bitfields, 0, bitfields.Length);
            for (int i = 0; i < count; i++)
            {
                bools.Add(((val >> bit) & 1) == 1);
                bit--;
                if (bit < 0)
                {
                    bit = 7;
                    cur++;
                }
            }
            return bools;
        }
#endif

        public static Save ReadSave(string fname)
        {
#if BINARY_SAVE
            using (var fobj = File.OpenRead(fname))
            {
                var save = new Save();
                var header = new byte[magic.Length];
                var read = new BinaryReader(fobj);
                fobj.Read(header, 0, magic.Length);
                if (!magic.SequenceEqual(header))
                    throw new InvalidDataException("This is not a TimeHACK binary save");
                int numprops = read.ReadInt32();
                var bools = new List<System.Reflection.PropertyInfo>();
                // Holy code duplication, Batman.
                // If you know a better way to get C# to do this, I'm all ears.
                foreach (var property in properties.Take(numprops))
                {
                    if (property.PropertyType == typeof(string))
                        property.SetValue(save, read.ReadString());
                    else if (property.PropertyType == typeof(int))
                        property.SetValue(save, read.ReadInt32());
                    else if (property.PropertyType == typeof(uint))
                        property.SetValue(save, read.ReadUInt32());
                    else if (property.PropertyType == typeof(long))
                        property.SetValue(save, read.ReadInt64());
                    else if (property.PropertyType == typeof(ulong))
                        property.SetValue(save, read.ReadUInt64());
                    else if (property.PropertyType == typeof(short))
                        property.SetValue(save, read.ReadInt16());
                    else if (property.PropertyType == typeof(ushort))
                        property.SetValue(save, read.ReadUInt16());
                    else if (property.PropertyType == typeof(byte))
                        property.SetValue(save, read.ReadByte());
                    else if (property.PropertyType == typeof(sbyte))
                        property.SetValue(save, read.ReadSByte());
                    else if (property.PropertyType == typeof(char))
                        property.SetValue(save, read.ReadChar());
                    else if (property.PropertyType == typeof(float))
                        property.SetValue(save, read.ReadSingle());
                    else if (property.PropertyType == typeof(double))
                        property.SetValue(save, read.ReadDouble());
                    else if (property.PropertyType == typeof(decimal))
                        property.SetValue(save, read.ReadDecimal());

                    else if (property.PropertyType == typeof(List<string>))
                        property.SetValue(save, ReadList<string>(read, "ReadString"));
                    else if (property.PropertyType == typeof(List<int>))
                        property.SetValue(save, ReadList<string>(read, "ReadInt32"));
                    else if (property.PropertyType == typeof(List<uint>))
                        property.SetValue(save, ReadList<string>(read, "ReadUInt32"));
                    else if (property.PropertyType == typeof(List<long>))
                        property.SetValue(save, ReadList<string>(read, "ReadInt64"));
                    else if (property.PropertyType == typeof(List<ulong>))
                        property.SetValue(save, ReadList<string>(read, "ReadUInt64"));
                    else if (property.PropertyType == typeof(List<short>))
                        property.SetValue(save, ReadList<string>(read, "ReadInt16"));
                    else if (property.PropertyType == typeof(List<ushort>))
                        property.SetValue(save, ReadList<string>(read, "ReadUInt16"));
                    else if (property.PropertyType == typeof(List<byte>))
                        property.SetValue(save, ReadList<string>(read, "ReadByte"));
                    else if (property.PropertyType == typeof(List<sbyte>))
                        property.SetValue(save, ReadList<string>(read, "ReadSByte"));
                    else if (property.PropertyType == typeof(List<char>))
                        property.SetValue(save, ReadList<string>(read, "ReadChar"));
                    else if (property.PropertyType == typeof(List<float>))
                        property.SetValue(save, ReadList<string>(read, "ReadSingle"));
                    else if (property.PropertyType == typeof(List<double>))
                        property.SetValue(save, ReadList<string>(read, "ReadDouble"));
                    else if (property.PropertyType == typeof(List<decimal>))
                        property.SetValue(save, ReadList<string>(read, "ReadDecimal"));

                    // Remember to read this boolean from the bitfield at the end.
                    else if (property.PropertyType == typeof(bool))
                        bools.Add(property);

                    else if (property.PropertyType == typeof(List<bool>))
                        property.SetValue(save, ReadBitfield(fobj, read.ReadInt32()));

                    // RIP
                    else
                        throw new InvalidDataException("There is no deserialisation method specified for " + property.PropertyType.ToString());
                }

                // Let's read the ultra tiny bitfield.
                var loaded = ReadBitfield(fobj, bools.Count);
                foreach (var item in bools.Zip(loaded, (p, b) => new { Property = p, Value = b }))
                    item.Property.SetValue(save, item.Value);

                return save;
            }
#else
            return JsonConvert.DeserializeObject<Save>(File.ReadAllText(fname));
#endif
        }

        public static void WriteSave(string fname, Save save)
        {
#if BINARY_SAVE
            using (var fobj = File.OpenWrite(fname))
            {
                var write = new BinaryWriter(fobj);
                var bools = new List<bool>();
                fobj.Write(magic, 0, magic.Length);
                write.Write(properties.Count()); // The number of properties basically acts as the version number.

                foreach (var property in properties)
                {
                    if (property == null)
                        continue;

                    // Types that can be written by BinaryWriter, except booleans.
                    if (property.PropertyType == typeof(string))
                    {
                        var val = property.GetValue(save) as string;
                        if (val == null)
                            write.Write("");
                        else
                            write.Write(val);
                    }
                    else if (property.PropertyType == typeof(int))
                        write.Write((int) property.GetValue(save));
                    else if (property.PropertyType == typeof(uint))
                        write.Write((uint) property.GetValue(save));
                    else if (property.PropertyType == typeof(long))
                        write.Write((long) property.GetValue(save));
                    else if (property.PropertyType == typeof(ulong))
                        write.Write((ulong) property.GetValue(save));
                    else if (property.PropertyType == typeof(short))
                        write.Write((short) property.GetValue(save));
                    else if (property.PropertyType == typeof(ushort))
                        write.Write((ushort) property.GetValue(save));
                    else if (property.PropertyType == typeof(byte))
                        write.Write((byte) property.GetValue(save));
                    else if (property.PropertyType == typeof(sbyte))
                        write.Write((sbyte) property.GetValue(save));
                    else if (property.PropertyType == typeof(char))
                        write.Write((char) property.GetValue(save));
                    else if (property.PropertyType == typeof(float))
                        write.Write((float) property.GetValue(save));
                    else if (property.PropertyType == typeof(double))
                        write.Write((double) property.GetValue(save));
                    else if (property.PropertyType == typeof(decimal))
                        write.Write((double) property.GetValue(save));

                    // ... and their lists.
                    else if (property.PropertyType == typeof(List<string>))
                        WriteList(write, property.GetValue(save) as List<string>);
                    else if (property.PropertyType == typeof(List<int>))
                        WriteList(write, property.GetValue(save) as List<int>);
                    else if (property.PropertyType == typeof(List<uint>))
                        WriteList(write, property.GetValue(save) as List<uint>);
                    else if (property.PropertyType == typeof(List<long>))
                        WriteList(write, property.GetValue(save) as List<long>);
                    else if (property.PropertyType == typeof(List<ulong>))
                        WriteList(write, property.GetValue(save) as List<ulong>);
                    else if (property.PropertyType == typeof(List<short>))
                        WriteList(write, property.GetValue(save) as List<short>);
                    else if (property.PropertyType == typeof(List<ushort>))
                        WriteList(write, property.GetValue(save) as List<ushort>);
                    else if (property.PropertyType == typeof(List<byte>))
                        WriteList(write, property.GetValue(save) as List<byte>);
                    else if (property.PropertyType == typeof(List<sbyte>))
                        WriteList(write, property.GetValue(save) as List<sbyte>);
                    else if (property.PropertyType == typeof(List<char>))
                        WriteList(write, property.GetValue(save) as List<char>);
                    else if (property.PropertyType == typeof(List<float>))
                        WriteList(write, property.GetValue(save) as List<float>);
                    else if (property.PropertyType == typeof(List<double>))
                        WriteList(write, property.GetValue(save) as List<double>);
                    else if (property.PropertyType == typeof(List<decimal>))
                        WriteList(write, property.GetValue(save) as List<decimal>);

                    // Booleans - they go in the bitfield at the end.
                    else if (property.PropertyType == typeof(bool))
                        bools.Add((bool) property.GetValue(save));

                    // List of booleans - it gets its own bitfield.
                    else if (property.PropertyType == typeof(List<bool>))
                    {
                        var val = property.GetValue(save) as List<bool>;
                        if (val == null)
                            write.Write(0);
                        else
                        {
                            write.Write(val.Count());
                            WriteBitfield(fobj, val);
                        }
                    }

                    // Now what?
                    else
                        throw new InvalidDataException("There is no serialisation method specified for " + property.PropertyType.ToString());
                }

                // In order to save space, we store bools in a bitfield at the end.
                // One byte can store 8 bools, saving a whopping 7 bytes which can then be used for
                // extremely short text documents or something.
                WriteBitfield(fobj, bools);
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
            byte[] byt = new byte[] { 0, 0 };
            if (DevMode) File.WriteAllBytes(Path.Combine(DataDirectory, "achieved.thack"), byt);

            if (File.Exists(Path.Combine(DataDirectory, "achieved.thack"))) byt = File.ReadAllBytes(Path.Combine(DataDirectory, "achieved.thack"));
            else File.WriteAllBytes(Path.Combine(DataDirectory, "achieved.thack"), byt);

            return byt;
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
            }
        }
    }


    // This lets us preserve the order of properties.
    // Thanks to "ghord" from StackOverflow.
    public sealed class OrderAttribute : Attribute
    {
        private readonly int order_;
        public OrderAttribute([CallerLineNumber]int order = 0)
        {
            order_ = order;
        }
        public int Order { get { return order_; } }
    }

    public class Save
    {
        // To maintain binary save compatibility,
        // add all new properties to the end and don't remove any.
        // Also, every property needs an "Order" attribute.

        [Order]
        public string Username { get; set; }

        [Order]
        public string CurrentOS { get; set; }

        // public Dictionary<string, bool> InstalledPrograms { get; set; } InstallProgram is no longer needed... we have that data in the FileSystem

        [Order]
        public List<string> ExperiencedStories { get; set; }

        [Order]
        public bool FTime95 { get; set; }

        [Order]
        public string ThemeName { get; set; }

        [Order]
        public int BytesLeft { get; set; }

        [Order]
        public Theme customTheme { get; set; }
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
