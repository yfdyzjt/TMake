using Neo.IronLua;

namespace TMake.Script
{
    public class Script
    {
        public static void Execute()
        {
            using Lua lua = new();
            dynamic eny = lua.CreateEnvironment();
            eny.dochunk("print(\"hello\")", "test.lua");
            Console.WriteLine($"{eny.name}");
        }
    }
}
