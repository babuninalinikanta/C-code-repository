using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Switch_case_demo
    {
        static void Main(string[]args)
        {
            int opt, num1, num2;
            float result;

        label:

            Console.WriteLine("\n\tMenu");
            Console.WriteLine("\nPress 1 for addition");
            Console.WriteLine("\nPress 2 for subtraction");
            Console.WriteLine("\nPress 3 for multiplication");
            Console.WriteLine("\nPress 4 for division");

            Console.Write("\n\nEnter first number:\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter second number:\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter your option:\t");
            opt = Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("\n{0} - {1} = {2}", num1, num2, result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("\n{0} * {1} = {2}", num1, num2, result);
                    break;
                case 4:
                    result =(float) num1 / num2;
                    Console.WriteLine("\n{0} / {1} = {2}", num1, num2, result);
                    break;
                default:
                    Console.WriteLine("\nInvalid option.Please Try again");
                    goto label;
            }
            Console.ReadLine();
        }
    }
}
