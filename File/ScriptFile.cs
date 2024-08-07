﻿using System.Drawing;
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

                var script = new Script();

                Load(script, sign);

                script.Type = type;
                script.FilePath = area.FilePath;
                script.Args.AddRange([new(typeName, area), new("area", area)]);

                scripts.Add(script);
            }
        }
        public static Sign Load<T>(Script script, T area, Point pos = default) where T : ITileArea
        {
            var sign = Tool.GetSign(area, pos);
            Load(script, sign);
            return sign;
        }
        public static void Load(Script script, string filePath)
        {
            script.Name = Path.GetFileNameWithoutExtension(filePath);
            script.Code = File.ReadAllText(filePath);

            script.FilePath = filePath;
        }
        public static void Load(Script script, Sign sign)
        {
            script.Name = LoadScriptName(sign);
            script.Code = LoadScriptCode(sign);

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
        public static Sign Save<T>(Script script, T area, Point pos = default) where T : ITileArea
        {
            var sign = Tool.PlaceSign(area, pos, FrameProperty.GetFrameData((ushort)TileID.Signs, "Wall"));
            Save(script, sign);
            return sign;
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
        private static void SaveScriptName(Sign sign, string name)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            sign.Text = "tmake" + ":" + name + Environment.NewLine +
                (lines.Length == 2 ? lines[1] : string.Empty);
        }
        private static string LoadScriptName(Sign sign)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            var heads = lines[0].StartsWith("tmake") ? lines[0].Split(':', 2) : [];
            return heads.Length == 2 ? heads[1] : string.Empty;
        }
        private static void SaveScriptCode(Sign sign, string code)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            sign.Text = lines[0] + Environment.NewLine + code
                .Replace("\n", "&#10")
                .Replace("\r", "&#13")
                .Replace("\t", "&#09");
        }
        private static string LoadScriptCode(Sign sign)
        {
            var lines = sign.Text.Split(["\r\n", "\r", "\n"], 2, StringSplitOptions.None);
            return lines.Length == 2 ? lines[1]
                .Replace("&#10", "\n")
                .Replace("&#13", "\r")
                .Replace("&#09", "\t")
                : string.Empty;
        }
        private static List<Sign> GetMatcheSigns(List<Sign> signs, string pattern)
        {
            return signs.Where(sign => LoadScriptName(sign) != string.Empty && IsMatche(LoadScriptName(sign), pattern)).ToList();
        }
        private static bool IsMatche(string str, string pattern)
        {
            return new Regex("^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$").IsMatch(str);
        }
    }
}
