using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Swapping_of_two_numbers
    {
        static void Main()
        {
            int num1, num2, temp;
            Console.Write("Enter first number:\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:\t");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------Before swapping----------");
            Console.WriteLine("num1={0}    num2={1}", num1, num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("---------After swapping-----------");
            Console.WriteLine("num1={0}    num2={1}", num1, num2);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
