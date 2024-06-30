using System.Reflection;

namespace TMake
{
    public class Command
    {
        public static object? Execute(string[] args)
        {
            if (args.Length == 0)
            {
                args = [
                    "Run",
                    "tmake.lua",
                ];
            }

            var methodName = args[0];
            var strargs = new string[args.Length - 1];
            var objargs = new List<object>();

            Array.Copy(args, 1, strargs, 0, strargs.Length);
            var @delegate = Reflective.CreateDelegate(Reflective.GetMethods("TMake.LuaScript")
                .Where(method => method.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase))
                .First(method => ParameterMatch(method.GetParameters(), strargs, objargs)));

            if (@delegate != null)
            {
                return @delegate.DynamicInvoke([.. objargs]);
            }
            else
            {
                throw new ArgumentException($"Method {nameof(@delegate)} not exist.");
            }
        }
        private static bool ParameterMatch(ParameterInfo[] parameters, string[] strargs, List<object> objargs)
        {
            objargs.Clear();

            for (int i = 0; i < parameters.Length; i++)
            {
                Type paramType = parameters[i].ParameterType;

                if (paramType != typeof(string) && paramType != typeof(string[]))
                {
                    return false;
                }
            }
            for (int i = 0; i < parameters.Length; i++)
            {
                Type paramType = parameters[i].ParameterType;

                if (paramType == typeof(string[]))
                {
                    if (i < strargs.Length)
                    {
                        for (int j = i; j < strargs.Length; j++)
                        {
                            objargs.Add(strargs[j]);
                        }
                    }
                    else
                    {
                        objargs.Add(Array.Empty<string>());
                    }
                    return true;
                }
                else if (i < strargs.Length)
                {
                    objargs.Add(strargs[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
