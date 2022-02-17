using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Multiplication_table
    {
        static void Main()
        {
            int i, num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num == 0)
                return;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("{0} * {1}= {2}", num, i, (num * i));
            }
            Console.ReadLine();
        }
    }
}
