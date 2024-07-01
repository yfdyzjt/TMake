using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static List<LuaResult?> Include(LuaGlobal self, string packageName, params string[] args)
        {
            var result = new List<LuaResult?>();
            var scripts = LoadScripts(packageName);

            foreach (var script in scripts)
            {
                result.Add(Include(self, script, args));
            }

            return result;
        }
        public static LuaResult? Include(LuaGlobal self, Script script, params string[] args)
        {
            using var lua = new Lua();
            var env = lua.CreateEnvironment();

            self[script.Name] = env;

            return Run(script, env, args);
        }
    }
}
