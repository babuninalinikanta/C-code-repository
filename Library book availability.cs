using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Library_book_availability
    {
        static void Main(string[]args)
        {
            char opt;
        label:
            Console.WriteLine("\n\tMenu");
            Console.WriteLine("\nC or c for Computer books");
            Console.WriteLine("\nM or m for Mathematics books");
            Console.WriteLine("\nH or h for History books");
            Console.WriteLine("\nE or e for English books");
            Console.WriteLine();
            Console.WriteLine("\nEnter your option");
            opt = Convert.ToChar(Console.ReadLine());
            if (opt == 'C' || opt == 'c')
                Console.WriteLine("\nNumber of Computer books=95");
            else if (opt == 'M' || opt == 'm')
                Console.WriteLine("\nNumber of Mathematics books=90");
            else if (opt == 'H' || opt == 'h')
                Console.WriteLine("\nNumber of History books=80");
            else if (opt == 'E' || opt == 'e')
                Console.WriteLine("\nNumber of English books=88");
            else
            {
                Console.WriteLine("\nInvalid option. Please try again");
                goto label;
            }
            Console.ReadLine();
        }
    }
}
