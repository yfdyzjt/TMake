using Neo.IronLua;

namespace TMake.LuaScript
{
    public static partial class Root
    {
        public static List<LuaResult?> Runs(string packageName, params string[] args)
        {
            var result = new List<LuaResult?>();
            var scripts = LoadScripts(packageName);

            foreach (var script in scripts)
            {
                result.Add(Run(script, args));
            }

            return result;
        }
        public static LuaResult? Run(string packageName, params string[] args)
        {
            var script = LoadScript(packageName);

            return Run(script, args);
        }
        public static LuaResult? Run(Script script, params string[] args)
        {
            using var lua = new Lua();
            var env = lua.CreateEnvironment();

            return Run(script, env, args);
        }
        public static LuaResult? Run(Script script, LuaGlobal env, params string[] args)
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
                Console.WriteLine(
                    $"Lua script have a syntactical exception.\r\n" +
                    $"Message: {e.Message}\r\n" +
                    $"Line: {e.Line}");
                return new LuaResult();
            }
            catch (LuaRuntimeException e)
            {
                Console.WriteLine(
                    $"Lua script have a runtime exception.\r\n" +
                    $"Message: {e.Message}\r\n" +
                    $"Line: {e.Line}");
                return new LuaResult();
            }
            catch (IOException e)
            {
                Console.WriteLine(
                    $"Lua script have a file exception.\r\n" +
                    $"Message: {e.Message}\r\n");
                return new LuaResult();
            }
            catch
            {
                throw;
            }
        }
    }
}
