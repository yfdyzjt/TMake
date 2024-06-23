using TMake.LuaScript;
using TMake.Terraria;

namespace TMake.IO
{
    public enum TMakeFileType : byte
    {
        Other,
        Lua,
        Sch,
        World,
    }
    public class TMakeFileProperty
    {
        public static readonly Dictionary<TMakeFileType, string> Type2FileExt = new()
        {
            { TMakeFileType.Lua, "lua" },
            { TMakeFileType.Sch, "TEditSch" },
            { TMakeFileType.World, "wld" },
        };
        public static readonly Dictionary<string, TMakeFileType> FileExt2Type = Type2FileExt.ToDictionary(k => k.Value, p => p.Key);

        public static readonly Dictionary<TMakeFileType, Type> Type2Class = new()
        {
            { TMakeFileType.Lua, typeof(Script) },
            { TMakeFileType.Sch, typeof(SchematicFile) },
            { TMakeFileType.World, typeof(World) },
        };
        public static readonly Dictionary<Type, TMakeFileType> Class2Type = Type2Class.ToDictionary(k => k.Value, p => p.Key);
    }
}
