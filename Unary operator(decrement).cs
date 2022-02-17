using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Unary_operator_decrement_
    {
        static void Main(string[]args)
        {
            int i = 5;//Initialization
            Console.WriteLine("The value of i is {0}",i);

            i--;//i decremented by one. It is post-decrement

            Console.WriteLine("\nNow the value of i is {0}", i);

            Console.ReadLine();
        }
    }
}
