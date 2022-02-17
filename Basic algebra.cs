using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp
{
    class Basic_algebra
    {
        static void Main(string[]args)
        {
            double a, b;
            int result;
            Console.Write("Enter the value of a\t");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of b\t");
            b = double.Parse(Console.ReadLine());
            result = Convert.ToInt32(Math.Pow(a, 2) + Math.Pow(b, 2) + 2 * a * b);
            Console.WriteLine("\n({0} + {1})^2 gives {2}", a, b, result);
            Console.ReadLine();
        }
    }
}
