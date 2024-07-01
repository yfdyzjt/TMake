using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static void Using(LuaGlobal self, string namespaceName)
        {
            Reflective.GetTypes(namespaceName)
                .ForEach(type => self.RegisterPackage(type.Name, type));
        }
    }
}
