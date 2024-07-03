using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static void FormatArgs(LuaGlobal self, params string[] pairs)
        {
            var args = (string[])self["args"];
            for (int i = 0; i < pairs.Length && i < args.Length; i++)
            {
                var parts = pairs[i].Split(':', 2);

                string name = parts[0].Trim();
                string type = parts.Length == 2 ? parts[1].Trim() : string.Empty;

                if (type == string.Empty)
                {
                    self[name] = args[i];
                }
                else
                {
                    try
                    {
                        Type targetType = Type.GetType(type, true, true) ?? typeof(string);
                        self[name] = Convert.ChangeType(args[i], targetType);
                    }
                    catch
                    {
                        self[name] = args[i];
                    }
                }
            }
        }
    }
}
