using TMake.Terraria;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static Script LoadScript(string packageName)
        {
            var scripts = LoadScripts(packageName);
            if (scripts.Count > 1)
                throw new FileFormatException("Find Too Many Files");

            return scripts[0];
        }
        public static List<Script> LoadScripts(string packageName)
        {
            var format = GetSeachFormat(packageName);
            return LoadScripts(format);
        }
        public static Schematic LoadSchematic(string packageName)
        {
            var schematics = LoadSchematics(packageName);
            if (schematics.Count > 1)
                throw new FileFormatException("Find Too Many Files");

            return schematics[0];
        }
        public static List<Schematic> LoadSchematics(string packageName)
        {
            var format = GetSeachFormat(packageName);
            return LoadSchematics(format);
        }
        public static World LoadWorld(string packageName)
        {
            var worlds = LoadWorlds(packageName);
            if (worlds.Count > 1)
                throw new FileFormatException("Find Too Many Files");

            return worlds[0];
        }
        public static List<World> LoadWorlds(string packageName)
        {
            var format = GetSeachFormat(packageName);
            return LoadWorlds(format);
        }
    }
}