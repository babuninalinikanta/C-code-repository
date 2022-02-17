using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Reverse_of_a_number
    {
        static void Main(string[]args)
        {
            int number, reverse=0;
            Console.Write("Enter a number:\t");
            number = int.Parse(Console.ReadLine());
            Console.Write("Reverse of the number is:");
            while(number!=0)
            {
                reverse = number % 10;
                Console.Write(reverse);
                number = number / 10;
            }            
            Console.ReadLine();
        }
    }
}
