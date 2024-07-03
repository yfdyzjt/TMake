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
        private static readonly Dictionary<TMakeFileType, string> TypeToFileExt = new()
        {
            { TMakeFileType.Lua, "lua" },
            { TMakeFileType.Sch, "TEditSch" },
            { TMakeFileType.World, "wld" },
        };
        private static readonly Dictionary<string, TMakeFileType> FileExtToType = TypeToFileExt.ToDictionary(k => k.Value, p => p.Key);

        public static string GetFileExt(TMakeFileType type)
        {
            return TypeToFileExt.TryGetValue(type, out var value) ? value : string.Empty;
        }
        public static TMakeFileType GetType(string ext)
        {
            return FileExtToType.TryGetValue(ext, out var value) ? value : TMakeFileType.Other;
        }

        private static readonly Dictionary<TMakeFileType, Type> TypeToClass = new()
        {
            { TMakeFileType.Lua, typeof(Script) },
            { TMakeFileType.Sch, typeof(Schematic) },
            { TMakeFileType.World, typeof(World) },
        };
        private static readonly Dictionary<Type, TMakeFileType> ClassToType = TypeToClass.ToDictionary(k => k.Value, p => p.Key);

        public static Type GetClass(TMakeFileType type)
        {
            return TypeToClass.TryGetValue(type, out var value) ? value : typeof(TMakeFile);
        }
        public static TMakeFileType GetType(Type type)
        {
            return ClassToType.TryGetValue(type, out var value) ? value : TMakeFileType.Other;
        }
    }
}
