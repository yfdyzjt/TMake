namespace TMake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) args = ["Run", "tmake.lua"];

            Command.Execute(args[0], args.Skip(1).ToArray());
        }
    }
}
