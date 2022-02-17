using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Logical_XOR_operator
    {
        static void Main(string[]args)
        {
            string name, password;

            name = "Steven";
            password = "demopass";

            //It returns false because both expressions match
            if((name=="Steven") ^ (password=="demopass"))
            {
                Console.WriteLine("Access granted.....");
            }
            else
            {
                Console.WriteLine("Access denied. Aborting.....");
            }
            Console.ReadLine();
        }
    }
}
