using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Even_and_Odd_number_check
    {
        static void Main(string[]args)
        {
            //int number;
            //Console.Write("Enter a number:\t");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //    Console.WriteLine("\n{0} is even number", number);
            //else
            //    Console.WriteLine("\n{0} is odd number", number);
            //Console.WriteLine("\nPress any key to exit");
            //Console.ReadKey();

            int num;
            Console.Write("Enter your number:\t");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("{0} is even number", num);
            }
            else
            {
                Console.WriteLine("{0} is odd number", num);
            }
            Console.ReadLine();
        }
    }
}
