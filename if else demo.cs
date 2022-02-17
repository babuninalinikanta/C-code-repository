using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class if_else_demo
    {
        static void Main(string[]args)
        {
            int opt, num1, num2;
            float result;
        label:
            Console.WriteLine("\n\tMenu");
            Console.WriteLine("\nPress 1 for addition");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multiplication");
            Console.WriteLine("Press 4 for division");

            Console.Write("\n\nEnter first number:\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter second number:\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter your option:\t");
            opt = Convert.ToInt32(Console.ReadLine());

            if(opt==1)
            {
                result = num1 + num2;
                Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
            }
            else if(opt==2)
            {
                result = num1 - num2;
                Console.WriteLine("\n{0} - {1} = {2}", num1, num2, result);
            }
            else if(opt==3)
            {
                result = num1 * num2;
                Console.WriteLine("\n{0} * {1} = {2}", num1, num2, result);
            }
            else if(opt==4)
            {
                result = (float)(num1 / num2);
                Console.WriteLine("\n{0} / {1} = {2}", num1, num2, result);
            }
            else
            {
                Console.WriteLine("Invalid option. Try again");
                goto label;
            }
            Console.ReadLine();

        }
    }
}
