using TMake.IO;

namespace TMake.LuaScript
{
    public partial class Script : TMakeFile
    {
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public List<KeyValuePair<string, object>> Args { get; set; } = [];
        public List<KeyValuePair<string, Type>> Packages { get; set; } = [];
    }
}
