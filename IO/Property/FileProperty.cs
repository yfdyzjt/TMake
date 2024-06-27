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
        public static readonly Dictionary<TMakeFileType, string> TypeToFileExt = new()
        {
            { TMakeFileType.Lua, "lua" },
            { TMakeFileType.Sch, "TEditSch" },
            { TMakeFileType.World, "wld" },
        };
        public static readonly Dictionary<string, TMakeFileType> FileExtToType = TypeToFileExt.ToDictionary(k => k.Value, p => p.Key);

        public static readonly Dictionary<TMakeFileType, Type> TypeToClass = new()
        {
            { TMakeFileType.Lua, typeof(Script) },
            { TMakeFileType.Sch, typeof(Schematic) },
            { TMakeFileType.World, typeof(World) },
        };
        public static readonly Dictionary<Type, TMakeFileType> ClassToType = TypeToClass.ToDictionary(k => k.Value, p => p.Key);
    }
}
