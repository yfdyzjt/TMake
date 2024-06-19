namespace TMake.LuaScript
{
    public class Script
    {
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public string FileName { get; set; } = "";
        public ScriptType Type { get; set; }
        public List<KeyValuePair<string, object>> Args { get; set; } = [];
        public List<KeyValuePair<string, Type>> Packages { get; set; } = [];
    }
}
