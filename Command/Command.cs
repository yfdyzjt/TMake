namespace TMake
{
    public class Command
    {
        public static void Execute(string[] cmdargs)
        {
            if (cmdargs.Length == 0)
            {
                cmdargs = [
                    "Run",
                    "tmake.lua",
                ];
            }

            var methodName = cmdargs[0];
            var callargs = new string[cmdargs.Length - 1];
            Array.Copy(cmdargs, 1, callargs, 0, callargs.Length);

            var @delegate = Reflective.CreateDelegate(Reflective.GetMethods("TMake.LuaScript")
                .First(method => method.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase)));

            if (@delegate != null)
            {
                @delegate.DynamicInvoke(callargs);
            }
            else
            {
                throw new ArgumentException($"Method {nameof(@delegate)} not exist.");
            }
        }
    }
}
