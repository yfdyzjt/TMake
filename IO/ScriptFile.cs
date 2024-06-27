using System.Drawing;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using TMake.LuaScript;
using TMake.Terraria;

namespace TMake.IO
{
    public static class ScriptFile
    {
        public static void Load<T>(List<Script> scripts, T area, string scriptName) where T : TMakeFile, ITileArea
        {
            var signs = GetMatcheSigns(area.Sign, scriptName);

            foreach (var sign in signs)
            {
                var type = TMakeFileProperty.GetType(typeof(T));
                var typeName = type.ToString().ToLower();

                var script = new Script
                {
                    Type = type,
                    FileName = area.FilePath,
                    Args = [
                        new(typeName, area),
                        new("area", area),
                    ],
                };

                Load(script, sign);

                scripts.Add(script);
            }
        }
        public static void Load<T>(Script script, T area, Point pos = default) where T : ITileArea
        {
            Load(script, Tool.GetSign(area, pos, true));
        }
        public static void Load(Script script, string filePath)
        {
            script.Name = Path.GetFileNameWithoutExtension(filePath);
            script.Code = File.ReadAllText(filePath);

            GetDefaultArgs(script);

            script.FilePath = filePath;
        }
        public static void Load(Script script, Sign sign)
        {
            script.Name = LoadScriptName(sign);
            script.Code = LoadScriptCode(sign);

            GetDefaultArgs(script);

            script.Args.Add(new("sign", sign));
        }
        public static void Save<T>(List<Script> scripts, T area, string scriptName) where T : ITileArea
        {
            foreach (var script in scripts)
            {
                Save(script, area, scriptName);
            }
        }
        public static void Save<T>(Script script, T area, string scriptName) where T : ITileArea
        {
            var signs = GetMatcheSigns(area.Sign, scriptName);

            if (signs.Count == 0)
            {
                Save(script, area, new Point(0, 0));
            }
            else
            {
                foreach (var sign in signs)
                {
                    Save(script, sign);
                }
            }
        }
        public static void Save<T>(Script script, T area, Point pos = default) where T : ITileArea
        {
            var sign = Tool.PlaceSign(area, pos, SpriteProperty.GetSpriteData("Sign", "Wall"));
            Save(script, sign);
        }
        public static void Save(Script script, string filePath)
        {
            File.WriteAllText(filePath, script.Code);
        }
        public static void Save(Script script, Sign sign)
        {
            SaveScriptName(sign, script.Name);
            SaveScriptCode(sign, script.Code);
        }
        private static void GetDefaultArgs(Script script)
        {
            script.Args.AddRange([
                new("script", script),
                ..UsingClass("TMake.LuaScript","Root"),
                ]);
            script.Packages.AddRange([
                ..UsingNamespace("TMake.IO"),
                ..UsingNamespace("TMake.Terraria"),
                ..UsingNamespace("TMake.LuaScript"),
                ]);
        }
        private static List<KeyValuePair<string, Type>> UsingNamespace(string namespaceName)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetExportedTypes())
                .Where(t => t.Namespace == namespaceName)
                .ToList()
                .Select(type => new KeyValuePair<string, Type>(type.Name, type)).ToList();
        }
        private static List<KeyValuePair<string, object>> UsingClass(string namespaceName, string className)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetExportedTypes())
                .First(t => t.Namespace == namespaceName && t.Name == className)
                .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(methodInfo => new KeyValuePair<string, object>(methodInfo.Name, CreateDelegateFromMethodInfo(methodInfo)))
                .ToList();
        }
        private static Delegate CreateDelegateFromMethodInfo(MethodInfo method)
        {
            var parameter = method.GetParameters().Select(p => p.ParameterType).ToArray();

            if (method.ReturnType == typeof(void))
            {
                var action = Expression.GetActionType(parameter);
                return Delegate.CreateDelegate(action, method);
            }
            else
            {
                Array.Resize(ref parameter, parameter.Length + 1);
                parameter[^1] = method.ReturnType;

                var func = Expression.GetFuncType(parameter);
                return Delegate.CreateDelegate(func, method);
            }
        }
        private static void SaveScriptName(Sign sign, string name)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            sign.Text = "tmake" + ":" + name + Environment.NewLine +
                (lines.Length == 2 ? lines[1] : "");
        }
        private static string LoadScriptName(Sign sign)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            var heads = lines[0].StartsWith("tmake") ? lines[0].Split(':', 2) : [];
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
        private static List<Sign> GetMatcheSigns(List<Sign> signs, string pattern)
        {
            return signs.Where(sign => IsMatche(LoadScriptName(sign), pattern)).ToList();
        }
        private static bool IsMatche(string str, string pattern)
        {
            return new Regex("^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$").IsMatch(str);
        }
    }
}
