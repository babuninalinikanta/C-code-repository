using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Sum_of_digits_in_a_number
    {
        static void Main(string[]args)
        {
            int number, digit, sum = 0;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            while(number!=0)
            {
                digit = number % 10;
                sum = sum + digit;
                number /= 10;
            }
            Console.WriteLine("Sum of digits={0}", sum);
            Console.ReadLine();
        }
    }
}
