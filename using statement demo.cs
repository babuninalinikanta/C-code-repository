using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Check_using:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Execute second");
        }
    }
    class using_statement_demo
    {
        static void Main(string[]args)
        {
            using (Check_using c = new Check_using())
            {
                Console.WriteLine("Executes first");
            }
            Console.WriteLine("Execute third");
            Console.ReadLine();
        }
    }
}
