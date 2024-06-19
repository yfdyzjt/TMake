using Neo.IronLua;
using TMake.IO;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static List<LuaResult> Run(string packageName, params string[] args)
        {
            var result = new List<LuaResult>();
            var scripts = ScriptFile.Load(packageName);

            foreach (var script in scripts)
            {
                result.Add(Run(script, args));
            }

            return result;
        }
        public static LuaResult Run(Script script, params string[] args)
        {
            using var lua = new Lua();
            var env = lua.CreateEnvironment();

            return Run(script, env, args);
        }
        public static LuaResult Run(Script script, LuaGlobal env, params string[] args)
        {
            env["self"] = env;
            env["args"] = args;

            foreach (var arg in script.Args)
            {
                env[arg.Key] = arg.Value;
            }

            foreach (var package in script.Packages)
            {
                env.RegisterPackage(package.Key, package.Value);
            }

            try
            {
                return env.DoChunk(script.Code, script.Name);
            }
            catch (LuaParseException e)
            {
                throw;
            }
            catch (LuaRuntimeException e)
            {
                throw;
            }
            catch (IOException e)
            {
                throw;
            }
            catch
            {
                throw;
            }
        }
    }
}
