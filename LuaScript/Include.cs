using Neo.IronLua;
using System.Text.RegularExpressions;
using TMake.IO;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static LuaResult Include(LuaGlobal self, Script script, params string[] args)
        {
            var prefix = script.Name + ".";
            string pattern1 = @"\bfunction\s+(\w+)\s*\(";
            string pattern2 = @"(?<!\.)\b(\w+)\(";

            List<string> functionNames = Regex.Matches(script.Code, pattern1).Cast<Match>()
                .Select(match => match.Groups[1].Value).ToList();

            script.Code = Regex.Replace(script.Code, pattern2, match =>
            functionNames.Contains(match.Groups[1].Value) ?
            prefix + match.Groups[1].Value :
            match.Groups[1].Value);

            return Run(script, self, args);
        }
        public static List<LuaResult> Include(LuaGlobal self, string packageName, params string[] args)
        {
            var result = new List<LuaResult>();
            var scripts = ScriptFile.Load(packageName);

            foreach (var script in scripts)
            {
                result.Add(Include(self, script, args));
            }

            return result;
        }
    }
}
