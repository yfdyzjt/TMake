using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static void Using(LuaGlobal self, string namespaceName)
        {
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetExportedTypes())
                .Where(t => t.Namespace == namespaceName)
                .ToList()
                .ForEach(type => self.RegisterPackage(type.Name, type));
        }
    }
}
