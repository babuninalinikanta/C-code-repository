using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Power_calculation2
    {
        static void Main(string[]args)
        {
            double num, power;
            Console.Write("Enter a number:\t");
            num = double.Parse(Console.ReadLine());
            Console.Write("Enter the power up to which the exponent will be raised:\t");
            power = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} to the power {1} gives {2}", num, power, Math.Pow(num, power).ToString());
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
