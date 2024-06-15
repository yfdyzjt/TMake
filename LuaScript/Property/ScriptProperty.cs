namespace TMake.LuaScript
{
    public enum ScriptType : byte
    {
        Lua,
        Sch,
        World,
    }
    public class ScriptProperty
    {
        public static readonly Dictionary<ScriptType, string> FileType = new()
        {
            { ScriptType.Lua, "lua" },
            { ScriptType.Sch, "TEditSch" },
            { ScriptType.World, "wld" }
        };
    }
}
