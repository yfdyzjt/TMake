using TMake.IO;

namespace TMake.LuaScript
{
    public class Script : TMakeFileFormat
    {
        public override void Load(TMakeFileFormat tmakeFile)
        {
            ScriptFile.Load(this, tmakeFile.FilePath);
        }
        public override void Save(TMakeFileFormat tmakeFile)
        {
            ScriptFile.Load(this, tmakeFile.FilePath);
        }
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public List<KeyValuePair<string, object>> Args { get; set; } = [];
        public List<KeyValuePair<string, Type>> Packages { get; set; } = [];
    }
}
