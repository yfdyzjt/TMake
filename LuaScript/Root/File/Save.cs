using TMake.IO;
using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static void SaveScript(Script script)
        {
            SaveScript(script, (TMakeFileSeachFormat)(TMakeFile)script);
        }
        public static void SaveScript(Script script, string packageName)
        {
            var format = GetSeachFormat(packageName);
            SaveScript(script, format);
        }
        public static void SaveSchematic(Schematic sch)
        {
            SaveSchematic(sch, (TMakeFileSeachFormat)(TMakeFile)sch);
        }
        public static void SaveSchematic(Schematic sch, string packageName)
        {
            var format = GetSeachFormat(packageName);
            SaveSchematic(sch, format);
        }
        public static void SaveWorld(World world)
        {
            SaveWorld(world, (TMakeFileSeachFormat)(TMakeFile)world);
        }
        public static void SaveWorld(World world, string packageName)
        {
            var format = GetSeachFormat(packageName);
            SaveWorld(world, format);
        }
    }
}
