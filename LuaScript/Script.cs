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

        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public List<KeyValuePair<string, object>> Args { get; set; } = [];
        public List<KeyValuePair<string, Type>> Packages { get; set; } = [];
    }
}
