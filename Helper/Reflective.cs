using System.Linq.Expressions;
using System.Reflection;

namespace TMake
{
    internal static class Reflective
    {
        internal static List<Type> GetTypes(string namespaceName)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetExportedTypes())
                .Where(t => t.Namespace == namespaceName)
                .ToList();
        }
        internal static List<MethodInfo> GetMethods(string namespaceName)
        {
            return GetTypes(namespaceName)
                .SelectMany(type => type
                .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
                .ToList();
        }
        internal static List<MethodInfo> GetMethods(string namespaceName, string className)
        {
            return GetMethods(namespaceName)
                .Where(method => method.GetType().Name == className)
                .ToList();
        }
        internal static Delegate CreateDelegate(MethodInfo method)
        {
            var parameter = method.GetParameters().Select(p => p.ParameterType).ToArray();

            if (method.ReturnType == typeof(void))
            {
                var action = Expression.GetActionType(parameter);
                return Delegate.CreateDelegate(action, method);
            }
            else
            {
                Array.Resize(ref parameter, parameter.Length + 1);
                parameter[^1] = method.ReturnType;

                var func = Expression.GetFuncType(parameter);
                return Delegate.CreateDelegate(func, method);
            }
        }
    }
}
