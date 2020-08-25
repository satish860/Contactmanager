using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContactManager.Hosts
{
    public class Repl
    {
        private readonly TextReader input;
        private readonly TextWriter output;

        public Repl(TextReader reader, TextWriter writer)
        {
            this.input = reader;
            this.output = writer;
        }

        public void Run()
        {
            bool quitseen = false;
            while (!quitseen)
            {
                output.Write("> ");
                output.Flush();
                var readline = input.ReadLine();
                if(Commands.Quit==readline)
                {
                    quitseen = true;
                    Console.WriteLine("Thanks!! Thats all is coded!!");
                }
            }
        }
    }

    internal struct Commands
    {
        //public const string Add = "add";
        //public const string Remove = "remove";
        //public const string Find = "find";
        public const string Quit = "quit";
        //public const string Error = "error";
        //public const string List = "list";
        //public const string Load = "load";
        //public const string Save = "save";
        //public const string Dump = "dump";
        //public const string Undo = "undo";
    }
}
