using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Logical_operators
    {
        static void Main(string[]args)
        {
            string name, password;

            name = "steven";
            password = "steven123";

            //Evaluating both expressions and returns true if both expressions are true
            if(name=="steven" && password=="steven123")
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Unauthorized access");
            }
            Console.ReadLine();
        }
    }
}
