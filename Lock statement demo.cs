using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Lock_statement_demo
    {
        public void printname()
        {
            Console.WriteLine("Steven Clark");
        }
        static void Main(string[]args)
        {
            Lock_statement_demo obj = new Lock_statement_demo();
            //Creating lock segment. The resources which are used in lock segment can't be used by another thread until it releases
            lock(obj)
            {
                obj.printname();
            }
            Console.ReadLine();
        }
    }
}
