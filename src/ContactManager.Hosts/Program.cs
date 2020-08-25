using System;

namespace ContactManager.Hosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Repl repl = new Repl(Console.In, Console.Out);
            repl.Run();
        }
    }
}
