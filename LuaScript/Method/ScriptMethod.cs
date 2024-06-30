using TMake.IO;

namespace TMake.LuaScript
{
    public partial class Script : TMakeFile
    {
        public override void Load(string filePath)
        {
            ScriptFile.Load(this, filePath);
        }
        public override void Save(string filePath)
        {
            ScriptFile.Save(this, filePath);
        }
    }
}
