using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static List<LuaGlobal?> Includes(LuaGlobal self, string packageName, params string[] args)
        {
            var envs = new List<LuaGlobal?>();
            var scripts = LoadScripts(packageName);

            foreach (var script in scripts)
            {
                envs.Add(Include(self, script, args));
            }

            return envs;
        }
        public static LuaGlobal? Include(LuaGlobal self, string packageName, params string[] args)
        {
            var script = LoadScript(packageName);

            return Include(self, script, args);
        }
        internal static LuaGlobal? Include(LuaGlobal self, Script script, params string[] args)
        {
            using var lua = new Lua();
            var env = lua.CreateEnvironment();

            self[script.Name] = env;

            Run(script, env, args);

            return env;
        }
    }
}
