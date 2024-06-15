using System.Text.RegularExpressions;
using TMake.LuaScript;
using TMake.Terraria;

namespace TMake.IO
{
    public class ScriptFile
    {
        public static List<Script> Load(string name, string path)
        {
            List<Script> scripts = [];

            var parts = name.Split('.', 2);
            var heads = parts[0].Split(':', 2);

            var headName = heads[0];
            var headExt = heads.Length == 2 ? heads[1] : "*";
            var scriptName = parts.Length == 2 ? parts[1] : "*";

            List<string> fileNames = [];
            if (headExt == "*")
            {
                foreach (var type in ScriptProperty.FileType)
                {
                    fileNames.AddRange(Directory.GetFiles(path, headName + "." + type.Value));
                }
            }
            else
            {
                fileNames.AddRange(Directory.GetFiles(path, headName + "." + headExt));
            }

            foreach (var file in fileNames)
            {
                var fileType = LoadScriptType(file);

                if (fileType == ScriptType.Lua)
                {
                    var script = new Script
                    {
                        Name = Path.GetFileNameWithoutExtension(file),
                        Code = File.ReadAllText(file),
                        Type = ScriptType.Lua,
                        FileName = file
                    };
                    scripts.Add(script);
                }
                else if (fileType == ScriptType.Sch)
                {
                    var sch = SchematicFile.Load(file);
                    var signs = sch.Sign;
                    var script = LoadScript(signs, scriptName);
                    foreach (var s in script)
                    {
                        s.Type = ScriptType.Sch;
                        s.FileName = file;
                        s.DefaultArgs.Add(new KeyValuePair<string, object>("Sch", sch));
                        s.DefaultArgs.Add(new KeyValuePair<string, object>("Area", sch));
                    }
                    scripts.AddRange(script);
                }
                else if (fileType == ScriptType.World)
                {
                    var world = WorldFile.Load(file);
                    var signs = world.Sign;
                    var script = LoadScript(signs, scriptName);
                    foreach (var s in script)
                    {
                        s.Type = ScriptType.World;
                        s.FileName = file;
                        s.DefaultArgs.Add(new KeyValuePair<string, object>("World", world));
                        s.DefaultArgs.Add(new KeyValuePair<string, object>("Area", world));
                    }
                    scripts.AddRange(script);
                }
            }

            return scripts;
        }
        private static List<Script> LoadScript(List<Sign> signs, string pattern)
        {
            List<Script> scripts = [];
            foreach (var sign in signs)
            {
                var name = LoadScriptName(sign);
                if (IsMatche(name, pattern))
                {
                    var code = LoadScriptCode(sign);
                    var script = new Script
                    {
                        Name = name,
                        Code = code.Replace("\\n", "\n").Replace("\\r", "\r"),
                        DefaultArgs = [new KeyValuePair<string, object>("Sign", sign)]
                    };
                    scripts.Add(script);
                }
            }
            return scripts;
        }
        private static ScriptType LoadScriptType(string fileName)
        {
            var name = Path.GetExtension(fileName).TrimStart('.');
            return ScriptProperty.FileType.FirstOrDefault(pair => pair.Value == name).Key;
        }
        private static string LoadScriptName(Sign sign)
        {
            var line = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None)[0];
            var head = line.StartsWith("tmake") ? line.Split('.', 2) : [];
            return head.Length == 2 ? head[1] : "";
        }


        private static string LoadScriptCode(Sign sign)
        {
            var line = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            return line.Length == 2 ? line[1] : "";
        }
        private static bool IsMatche(string str, string pattern)
        {
            return new Regex("^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$").IsMatch(str);
        }
    }
}
