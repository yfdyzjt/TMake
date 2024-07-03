using TMake.IO;

namespace TMake.LuaScript
{
    public class Script : TMakeFile
    {
        public override void Load(string filePath)
        {
            ScriptFile.Load(this, filePath);
        }
        public override void Save(string filePath)
        {
            ScriptFile.Save(this, filePath);
        }

        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public List<KeyValuePair<string, object>> Args { get; set; }
        public List<KeyValuePair<string, Type>> Packages { get; set; }

        public Script()
        {
            Args = [
                new("script", this),
                .. UsingClass("TMake.LuaScript", "Root"),
            ];
            Packages = [
                .. UsingNamespace("TMake.IO"),
                .. UsingNamespace("TMake.Terraria"),
                .. UsingNamespace("TMake.LuaScript"),
            ];
        }
        private static List<KeyValuePair<string, Type>> UsingNamespace(string namespaceName)
        {
            return Reflective.GetTypes(namespaceName)
                .Select(type => new KeyValuePair<string, Type>(type.Name, type))
                .ToList();
        }
        private static List<KeyValuePair<string, object>> UsingClass(string namespaceName, string className)
        {
            return Reflective.GetMethods(namespaceName, className)
                .Select(methodInfo => new KeyValuePair<string, object>(methodInfo.Name, Reflective.CreateDelegate(methodInfo)))
                .ToList();
        }
    }
}
