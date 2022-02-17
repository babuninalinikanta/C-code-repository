using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Even_and_odd_number_checking
    {
        static void Main(string[]args)
        {
            int num;
            Console.Write("Enter a number:\t");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("\n{0} is an even number", num);
            else
                Console.WriteLine("\n{0} is an Odd number", num);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
