using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class goto_statement_demo
    {
        static void Main(string[]args)
        {
            string name;
        label://creating label with colon
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("Press Ctrl+C to exit\n");
            goto label;//Jump to label statement
        }
    }
}
