using Neo.IronLua;
using System.Drawing;
using System.Text;
using TMake.Terraria;

namespace TMake.File
{
    public class ScriptFile
    {
        public static string Load(string filename)
        {
        }
        public static void Save(LuaChunk luaTable, string filename)
        {

        }
        public static void Save(LuaChunk luaTable, string filename, Point position)
        {

        }
        public static void Save<T>(string code, T area, Point position) where T : ITileArea
        {
        }
    }
}
