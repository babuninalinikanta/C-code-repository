using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class throw_statement_demo
    {
        static void Main(string[]args)
        {
            int num1, num2, result;

            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(num2==0)
                {
                    throw new Exception("Can not divide by zero exception\n\n");
                }
                result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:" + e.ToString());
            }
            Console.ReadLine();
        }
    }
}
