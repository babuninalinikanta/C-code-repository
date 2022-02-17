using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Number_addition
    {
        static void Main(string[]args)
        {
            //Creating integer type variable
            int num1, num2, result;
            //Displaying message
            Console.WriteLine("Please enter first value");

            //Accepting value in num1
            num1 = Int32.Parse(Console.ReadLine());
            //Displaying message
            Console.WriteLine("Enter second value");
            //Accepting value
            num2 = Int32.Parse(Console.ReadLine());

            result = num1 + num2;//Processing value

            Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, result);//Output

            Console.ReadLine();
        }
    }
}
