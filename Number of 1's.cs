using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Number_of_1_s
    {
        static void Main(string[]args)
        {
            long number, count = 0, digit;
            Console.WriteLine("Enter a number");
            number =Convert.ToInt64(Console.ReadLine());
            while(number!=0)
            {
                digit = number % 10;
                if (digit == 1)
                    count++;
                number = number / 10;
            }
            Console.WriteLine("Number of 1's entered={0}", count);
            Console.ReadLine();
        }
    }
}
