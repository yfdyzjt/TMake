using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static void Run(Script script, params string[] args)
        {
            using var lua = new Lua();
            var env = lua.CreateEnvironment();

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
                env.DoChunk(script.Code, script.Name);
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
