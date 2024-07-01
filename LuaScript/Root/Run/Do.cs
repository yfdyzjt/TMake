using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static LuaResult? Do(string code, params string[] args)
        {
            var script = new Script()
            {
                Name = "Script",
                Code = code,
            };

            return Run(script, args);
        }
    }
}
