using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Arithmetic_operators
    {
        static void Main(string[]args)
        {
            int num1, num2;
            int add, sub, mul;
            float div;

            //Accepting values from users
            Console.Write("Enter first number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter second number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Processing values
            //Used + operator for adding values
            add = num1 + num2;
            //Used - operator for subtracting values
            sub = num1 - num2;
            //Used * operator for multiplying values
            mul = num1 * num2;
            //Used / operator for dividing values
            div = (float)num1 / num2;

            //Displaying output
            Console.WriteLine("\n\n=====================\n");
            Console.WriteLine("Addition\t\t{0}", add);
            Console.WriteLine("Subtraction\t\t{0}", sub);
            Console.WriteLine("Multiplication\t\t{0}", mul);
            Console.WriteLine("Division\t\t{0}", div);
            Console.WriteLine("\n=======================\n");

            Console.ReadLine();
        }
    }
}
