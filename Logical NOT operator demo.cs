using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Logical_NOT_operator_demo
    {
        static void Main(string[]args)
        {
            string username, password;

            Console.Write("Enter user name:\t");
            username = Console.ReadLine();
            Console.Write("Enter password:\t");
            password = Console.ReadLine();

            if(!(username=="Steven" && password=="demopass"))
            {
                Console.WriteLine("\nLogin successful");
            }
            else
            {
                Console.WriteLine("Unauthorized access. Aborting.....");
            }
            Console.ReadLine();
        }
    }
}
