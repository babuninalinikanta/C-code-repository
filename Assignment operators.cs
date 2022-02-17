using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Assignment_operators
    {
        static void Main(string[]args)
        {
            int num1, num2;

            num1 = 10;
            num2 = 5;

            num1 += num2;//Same as num1=num1+num2
            Console.WriteLine("Addition = {0}", num1);

            num1 -= num2;//Same as num1=num1-num2
            Console.WriteLine("\n\nSubtraction = {0}",num1);

            num1 *= num2;//Same as num1=num1*num2
            Console.WriteLine("\n\nMultiplication = {0}", num1);

            num1 %= num2;//Same as num1=num1%num2
            Console.WriteLine("\n\nModulus = {0}", num1);

            Console.ReadLine();
        }
    }
}
