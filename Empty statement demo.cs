using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Empty_statement_demo
    {
        public bool print()
        {
            Console.WriteLine("Steven Clark");
            return true;
        }
        static void Main(string[]args)
        {
            int i = 0;
            Empty_statement_demo obj = new Empty_statement_demo();
            while(obj.print())
            {
                ;//Empty statement
            }
            Console.WriteLine("i={0}", i);
            Console.ReadLine();
        }
    }
}
