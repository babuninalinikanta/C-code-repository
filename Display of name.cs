using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Display_of_name
    {
        static void Main(string[]args)
        {
            string name;//Variable for storing string value

            //Displaying message for entering value
            Console.WriteLine("Please enter your name");

            //Accepting and holding values in name variable
            name = Console.ReadLine();

            //Displaying output
            Console.WriteLine("Hello {0} in your first C# program", name);

            //Holding console screen
            Console.ReadLine();
        }
    }
}
