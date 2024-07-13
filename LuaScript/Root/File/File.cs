using System.IO;
using TMake.IO;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        internal static List<Script> LoadScripts(TMakeFileSeachFormat format, bool validate = true)
        {
            var scripts = new List<Script>();

            if (format.Extension == "*")
            {
                foreach (var type in Enum.GetValues(typeof(TMakeFileType)))
                {
                    var tmpformat = (TMakeFileSeachFormat)format.Clone();
                    tmpformat.Type = (TMakeFileType)type;
                    scripts.AddRange(LoadScripts(tmpformat, false));
                }
            }
            else
            {
                switch (format.Type)
                {
                    case TMakeFileType.Other:
                    case TMakeFileType.Lua:
                        scripts.AddRange(LoadFiles<Script>(format, false));
                        break;
                    case TMakeFileType.Sch:
                        var schs = LoadFiles<Schematic>(format, false);
                        foreach (var sch in schs)
                        {
                            ScriptFile.Load(scripts, sch, format.ScriptName);
                        }
                        break;
                    case TMakeFileType.World:
                        var worlds = LoadFiles<World>(format, false);
                        foreach (var world in worlds)
                        {
                            ScriptFile.Load(scripts, world, format.ScriptName);
                        }
                        break;
                }
            }

            if (scripts.Count == 0 && validate)
                throw new FileFormatException("Not Find File");

            return scripts;
        }
        internal static List<Schematic> LoadSchematics(TMakeFileSeachFormat format)
        {
            var tmpformat = (TMakeFileSeachFormat)format.Clone();
            tmpformat.Type = TMakeFileType.Sch;
            return LoadFiles<Schematic>(tmpformat);
        }
        internal static List<World> LoadWorlds(TMakeFileSeachFormat format)
        {
            var tmpformat = (TMakeFileSeachFormat)format.Clone();
            tmpformat.Type = TMakeFileType.World;
            return LoadFiles<World>(tmpformat);
        }
        private static List<T> LoadFiles<T>(TMakeFileSeachFormat format, bool validate = true) where T : TMakeFile, new()
        {
            var files = new List<T>();
            var filePaths = SeachFilePaths(format);

            if (filePaths.Count == 0 && validate)
                throw new FileFormatException("Not Find File");

            foreach (var filePath in filePaths)
            {
                T file = new();
                file.Load(filePath);
                files.Add(file);
            }

            return files;
        }
        internal static void SaveScript(Script script, TMakeFileSeachFormat format)
        {
            if (format.Extension == "*")
            {
                var tmpformat = (TMakeFileSeachFormat)format.Clone();
                tmpformat.Type = TMakeFileType.Lua;
                SaveScript(script, tmpformat);
            }
            else
            {
                switch (format.Type)
                {
                    case TMakeFileType.Other:
                    case TMakeFileType.Lua:
                        SaveFile(script, format);
                        break;
                    case TMakeFileType.Sch:
                        var schs = LoadFiles<Schematic>(format);
                        foreach (var sch in schs)
                        {
                            ScriptFile.Save(script, sch, format.ScriptName);
                        }
                        SaveFiles(schs, format);
                        break;
                    case TMakeFileType.World:
                        var worlds = LoadFiles<World>(format);
                        foreach (var world in worlds)
                        {
                            ScriptFile.Save(script, world, format.ScriptName);
                        }
                        SaveFiles(worlds, format);
                        break;
                }
            }
        }
        internal static void SaveSchematic(Schematic sch, TMakeFileSeachFormat format)
        {
            var tmpformat = (TMakeFileSeachFormat)format.Clone();
            tmpformat.Type = TMakeFileType.Sch;
            SaveFile(sch, tmpformat);
        }
        internal static void SaveWorld(World world, TMakeFileSeachFormat format)
        {
            var tmpformat = (TMakeFileSeachFormat)format.Clone();
            tmpformat.Type = TMakeFileType.World;
            SaveFile(world, tmpformat);
        }
        private static void SaveFiles<T>(List<T> files, TMakeFileSeachFormat format) where T : TMakeFile, new()
        {
            foreach (var file in files)
            {
                SaveFile(file, format);
            }
        }
        private static void SaveFile<T>(T file, TMakeFileSeachFormat format) where T : TMakeFile, new()
        {
            var filePaths = SeachFilePaths(format);

            if (filePaths.Count == 0)
            {
                file.Save(format.FilePath);
            }
            else
            {
                foreach (var filePath in filePaths)
                {
                    file.Save(filePath);
                }
            }
        }
        private static TMakeFileSeachFormat GetSeachFormat(string packageName)
        {
            var path = Path.GetDirectoryName(Path.GetFullPath(packageName)) ?? string.Empty;
            var name = Path.GetFileName(packageName);

            var parts = name.Split(':', 3);
            var heads = parts[0].Split('.', 2);

            var fileName = heads[0];
            var fileExt = heads.Length >= 2 ? heads[1] : "*";

            var script = parts.Length >= 2 ? parts[1] : "*";
            var function = parts.Length >= 3 ? parts[2] : "*";

            return new TMakeFileSeachFormat()
            {
                FilePath = Path.Combine(path, fileName + "." + fileExt),
                ScriptName = script,
                FunctionName = function,
            };
        }
        private static List<string> SeachFilePaths(TMakeFileSeachFormat format)
        {
            return SeachFileDirectories(format.Directory)
                .SelectMany(dir => Directory.GetFiles(dir, format.FileName + "." + format.Extension))
                .ToList();
        }
        private static List<string> SeachFileDirectories(string dir)
        {
            if (dir.Contains("**"))
            {
                SplitDir(dir, "**", out string dir1, out string dir2, out string dir3);

                return Directory.GetDirectories(dir1, "*", SearchOption.AllDirectories)
                    .SelectMany(subdir => SeachFileDirectories(Path.Combine(subdir, dir3)))
                    .ToList();
            }
            else if (dir.Contains('*') || dir.Contains('?'))
            {
                SplitDir(dir, dir.Contains('*') ? "*" : "?", out string dir1, out string dir2, out string dir3);

                return Directory.GetDirectories(dir1, dir2, SearchOption.TopDirectoryOnly)
                    .SelectMany(subdir => SeachFileDirectories(Path.Combine(subdir, dir3)))
                    .ToList();
            }
            else
            {
                return [dir];
            }
        }
        private static void SplitDir(string dir, string separator, out string dir1, out string dir2, out string dir3)
        {
            string[] parts = dir.Split(separator, StringSplitOptions.None);
            dir1 =
                parts[0].Contains(Path.DirectorySeparatorChar)
                ? parts[0][..parts[0].LastIndexOf(Path.DirectorySeparatorChar)]
                : string.Empty;
            dir2 =
                parts[0].Contains(Path.DirectorySeparatorChar)
                ? parts[0][(parts[0].LastIndexOf(Path.DirectorySeparatorChar) + 1)..]
                : parts[0];
            dir3 =
                parts.Length > 1
                ? parts[1].Contains(Path.DirectorySeparatorChar)
                    ? parts[1][parts[1].IndexOf(Path.DirectorySeparatorChar)..]
                    : string.Empty
                : string.Empty;
        }
    }
}
