using TMake.LuaScript;

namespace TMake.IO
{
    public class TMakeFileFormat
    {
        public string Extension
        {
            get { return Path.GetExtension(FilePath).TrimStart('.'); }
            set { FilePath = Path.Combine(Directory, FileName + "." + value); }
        }
        public string FileName
        {
            get { return Path.GetFileNameWithoutExtension(FilePath); }
            set { FilePath = Path.Combine(Directory, value + "." + Extension); }
        }
        public string Directory
        {
            get { return Path.GetDirectoryName(FilePath) ?? ""; }
            set { FilePath = Path.Combine(value, FileName + "." + Extension); }
        }
        public TMakeFileType Type
        {
            get { return TMakeFileProperty.TMakeFileExt.FirstOrDefault(pair => pair.Value == Extension).Key; }
            set { Extension = TMakeFileProperty.TMakeFileExt[value]; }
        }
        public string FilePath { get; set; } = "";
        public string ScriptName { get; set; } = "";
        public string FunctionName { get; set; } = "";

        public virtual void Load(string filePath) { }
        public virtual List<Script> LoadScript(string scriptPath) { }
        public virtual void Save(string filePath) { }
        public virtual void SaveScript(List<Script> scripts, string scriptPath) { }
    }
    public class TMakeFile
    {
        public static List<T> Loads<T>(string packageName) where T : TMakeFileFormat, new()
        {
            List<T> files = [];

            var tmakeFiles = GetTrueTMakeFile(packageName);

            if (tmakeFiles.Count == 0)
            {
                throw new FileFormatException("Not Find File");
            }
            else
            {
                foreach (var tmakeFile in tmakeFiles)
                {
                    T file = new();

                    file.Load(tmakeFile);

                    files.Add(file);
                }
            }

            return files;
        }
        public static void Save<T>(T file, string packageName) where T : TMakeFileFormat
        {
            var tmakeFiles = GetTrueTMakeFile(packageName);

            if (tmakeFiles.Count == 0)
            {
                file.Save(GetTMakeFile(packageName));
            }
            else
            {
                foreach (var tmakeFile in tmakeFiles)
                {
                    file.Save(tmakeFile);
                }
            }
        }
        private static TMakeFileFormat GetTMakeFile(string packageName)
        {
            var path = Path.GetDirectoryName(Path.IsPathRooted(packageName) ? packageName : Path.GetFullPath(packageName)) ?? "";
            var name = Path.GetFileName(packageName);

            var parts = name.Split(':', 3);
            var heads = parts[0].Split('.', 2);

            var fileName = heads[0];
            var fileExt = heads.Length == 2 ? heads[1] : "*";

            var script = parts.Length == 2 ? parts[1] : "*";
            var function = parts.Length == 3 ? parts[2] : "*";

            return new TMakeFileFormat()
            {
                FilePath = path + fileName + "." + fileExt,
                ScriptName = script,
                FunctionName = function,
            };
        }
        private static List<TMakeFileFormat> GetTrueTMakeFile(string packageName)
        {
            var tmakeFile = GetTMakeFile(packageName);

            var tmakeFiles = new List<TMakeFileFormat>();

            if (tmakeFile.Extension == "*")
            {
                tmakeFiles.AddRange(TMakeFileProperty.TMakeFileExt.SelectMany(type =>
                    Directory.GetFiles(tmakeFile.Directory, tmakeFile.FileName + "." + type.Value)
                    .Select(file => new TMakeFileFormat
                    {
                        FilePath = file,
                        ScriptName = tmakeFile.ScriptName,
                        FunctionName = tmakeFile.FunctionName,
                    })));
            }
            else
            {
                tmakeFiles.AddRange(
                    Directory.GetFiles(tmakeFile.Directory, tmakeFile.FileName + "." + tmakeFile.Extension)
                    .Select(file => new TMakeFileFormat
                    {
                        FilePath = file,
                        ScriptName = tmakeFile.ScriptName,
                        FunctionName = tmakeFile.FunctionName,
                    }));
            }

            return tmakeFiles;
        }
    }
}
