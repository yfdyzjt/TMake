namespace TMake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) args = ["Run", "tmake.lua"];

            var methodName = args[0];
            var strArgs = args.Skip(1).ToArray();

            Command.Execute(methodName, strArgs);
        }
    }
}
