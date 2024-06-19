using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static void Run(Script script, params string[] args)
        {
            using Lua lua = new();
            LuaGlobal global = lua.CreateEnvironment();
            global.DoChunk(script.Code, script.Name, [new("args", args), .. script.DefaultArgs]);
        }
    }
}
