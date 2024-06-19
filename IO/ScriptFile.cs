using System.Reflection;
using System.Text.RegularExpressions;
using TMake.LuaScript;
using TMake.Terraria;

namespace TMake.IO
{
    public class ScriptFile
    {
        public static List<Script> Load(string path, string name)
        {
            GetScriptNames(name,
                out string scriptFileName,
                out string scriptFileExt,
                out string scriptName);

            List<string> fileNames = GetFileNames(path, scriptFileName, scriptFileExt);

            List<Script> scripts = [];

            foreach (var fileName in fileNames)
            {
                var fileType = GetScriptType(fileName);

                if (fileType == ScriptType.Lua)
                {
                    var script = new Script
                    {
                        Name = Path.GetFileNameWithoutExtension(fileName),
                        Code = File.ReadAllText(fileName),
                        Type = ScriptType.Lua,
                        FileName = fileName,
                        DefaultArgs = [
                                .. GetDefaultArgs(),
                            ]
                    };
                    script.DefaultArgs.Add(new("script", script));
                    scripts.Add(script);
                }
                else if (fileType == ScriptType.Sch)
                {
                    var sch = SchematicFile.Load(fileName);
                    var signs = GetMatcheSigns(sch.Sign, scriptName);
                    foreach (var sign in signs)
                    {
                        var script = new Script
                        {
                            Name = name,
                            Type = ScriptType.Sch,
                            FileName = fileName,
                            Code = LoadScriptCode(sign),
                            DefaultArgs = [
                                .. GetDefaultArgs(),
                                new KeyValuePair<string, object>("sign", sign),
                                new KeyValuePair<string, object>("sch", sch),
                                new KeyValuePair<string, object>("area", sch),
                            ]
                        };
                        script.DefaultArgs.Add(new("script", script));
                        scripts.Add(script);
                    }
                }
                else if (fileType == ScriptType.World)
                {
                    var world = WorldFile.Load(fileName);
                    var signs = GetMatcheSigns(world.Sign, scriptName);
                    foreach (var sign in signs)
                    {
                        var script = new Script
                        {
                            Name = name,
                            Type = ScriptType.World,
                            FileName = fileName,
                            Code = LoadScriptCode(sign),
                            DefaultArgs = [
                                .. GetDefaultArgs(),
                                new KeyValuePair<string, object>("sign", sign),
                                new KeyValuePair<string, object>("world", world),
                                new KeyValuePair<string, object>("area", world),
                            ],
                        };
                        script.DefaultArgs.Add(new("script", script));
                        scripts.Add(script);
                    }
                }
            }

            return scripts;
        }
        public static void Save(Script script, string path)
        {
            Save(script, path, script.Name);
        }
        public static void Save(Script script, string path, string name)
        {
            GetScriptNames(name,
                out string scriptFileName,
                out string scriptFileExt,
                out string scriptName);

            List<string> fileNames = GetFileNames(path, scriptFileName, scriptFileExt);

            if (fileNames.Count == 0)
            {
                File.WriteAllText(Path.Combine(path, scriptFileName + ".lua"), script.Code);
            }
            else
            {
                foreach (var fileName in fileNames)
                {
                    var fileType = GetScriptType(fileName);

                    if (fileType == ScriptType.Lua)
                    {
                        File.WriteAllText(Path.Combine(path, scriptFileName + ".lua"), script.Code);
                    }
                    else if (fileType == ScriptType.Sch)
                    {
                        var sch = SchematicFile.Load(fileName);
                        var signs = GetMatcheSigns(sch.Sign, scriptName);

                        if (signs.Count == 0)
                        {
                            signs.Add(Tool.PlaceSign(sch, new(0, 0), SpriteProperty.GetSpriteData("Sign", "Wall")));
                        }

                        foreach (var sign in signs)
                        {
                            SaveScriptName(sign, script.Name);
                            SaveScriptCode(sign, script.Code);
                        }

                        SchematicFile.Save(sch, fileName);
                    }
                    else if (fileType == ScriptType.World)
                    {
                        var world = WorldFile.Load(fileName);
                        var signs = GetMatcheSigns(world.Sign, scriptName);

                        if (signs.Count == 0)
                        {
                            signs.Add(Tool.PlaceSign(world, new(0, 0), SpriteProperty.GetSpriteData("Sign", "Wall")));
                        }

                        foreach (var sign in signs)
                        {
                            SaveScriptName(sign, script.Name);
                            SaveScriptCode(sign, script.Code);
                        }

                        WorldFile.Save(world, fileName);
                    }
                }
            }
        }
        private static List<KeyValuePair<string, object>> GetDefaultArgs()
        {
            return [
                ..UsingNamespace("IO"),
                ..UsingNamespace("Terraria"),
                ..UsingNamespace("LuaScript"),
                ];
        }
        private static List<KeyValuePair<string, object>> UsingNamespace(string namespaceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.Namespace == namespaceName).ToList();
            return types.Select(type => new KeyValuePair<string, object>(type.Name, type)).ToList();
        }
        private static void GetScriptNames(string name, out string scriptFileName, out string scriptFileExt, out string scriptName)
        {
            var parts = name.Split('.', 2);
            var heads = parts[0].Split(':', 2);

            scriptFileName = heads[0];
            scriptFileExt = heads.Length == 2 ? heads[1] : "*";
            scriptName = parts.Length == 2 ? parts[1] : "*";
        }
        private static List<string> GetFileNames(string path, string scriptFileName, string scriptFileExt = "*")
        {
            List<string> fileNames = [];

            if (scriptFileExt == "*")
            {
                foreach (var type in ScriptProperty.FileType)
                {
                    fileNames.AddRange(Directory.GetFiles(path, scriptFileName + "." + type.Value));
                }
            }
            else
            {
                fileNames.AddRange(Directory.GetFiles(path, scriptFileName + "." + scriptFileExt));
            }

            return fileNames;
        }
        private static ScriptType GetScriptType(string fileName)
        {
            var name = Path.GetExtension(fileName).TrimStart('.');
            return ScriptProperty.FileType.FirstOrDefault(pair => pair.Value == name).Key;
        }
        private static List<Sign> GetMatcheSigns(List<Sign> signs, string pattern)
        {
            return signs.Where(sign => IsMatche(LoadScriptName(sign), pattern)).ToList();
        }
        private static void SaveScriptName(Sign sign, string name)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            sign.Text = "tmake" + "." + name + Environment.NewLine +
                (lines.Length == 2 ? lines[1] : "");
        }
        private static string LoadScriptName(Sign sign)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            var heads = lines[0].StartsWith("tmake") ? lines[0].Split('.', 2) : [];
            return heads.Length == 2 ? heads[1] : "";
        }
        private static void SaveScriptCode(Sign sign, string code)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            sign.Text = lines[0] + Environment.NewLine +
                code.Replace("\n", "&#10").Replace("\r", "&#13");
        }
        private static string LoadScriptCode(Sign sign)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            return lines.Length == 2 ? lines[1].Replace("&#10", "\n").Replace("&#13", "\r") : "";
        }
        private static bool IsMatche(string str, string pattern)
        {
            return new Regex("^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$").IsMatch(str);
        }
    }
}
