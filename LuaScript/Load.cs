using TMake.IO;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static List<T> Load<T>(string packageName) where T : TMakeFileFormat, new()
        {

        }
    }
}
