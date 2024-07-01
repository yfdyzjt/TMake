using System.Reflection;

namespace TMake
{
    public class Command
    {
        public static object? Execute(string methodName, string[] strArgs)
        {
            var objArgs = new List<object>();

            var @delegate = Reflective.CreateDelegate(Reflective.GetMethods("TMake.LuaScript")
                .Where(method => method.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase))
                .First(method => ParameterMatch(method.GetParameters(), strArgs, objArgs)));

            if (@delegate != null)
            {
                return @delegate.DynamicInvoke([.. objArgs]);
            }
            else
            {
                throw new ArgumentException($"Method {methodName} not exist.");
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
