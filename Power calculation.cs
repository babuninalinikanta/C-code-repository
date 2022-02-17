using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Power_calculation
    {
        static void Main(string[]args)
        {
            int num, power,result=1,i;
            Console.Write("Enter a number:\t");
            num = int.Parse(Console.ReadLine());
            Console.Write("Enter the power upto which the exponent will be raised:\t");
            power = int.Parse(Console.ReadLine());
            if (power == 0)
                result = 1;
            for(i=1;i<=power;i++)
            {
                result = result * num;
            }
            Console.WriteLine("\n{0} to the power {1} gives {2}", num, power, result);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
