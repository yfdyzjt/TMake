using System.Drawing;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static void CopyScript(string fromPackageName, string toPackageName)
        {
            var script = LoadScript(fromPackageName);
            SaveScript(script, toPackageName);
        }
    }
}
