using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class User_mailing_details
    {
        static void Main(string[]args)
        {
            string name;
            string city;
            string street;
            int pin;
            int housenumber;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter city");
            city = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter street");
            street = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter pin");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter house number");
            housenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("Mailing details of user");
            Console.WriteLine("========================");
            Console.WriteLine("Name={0}", name);
            Console.WriteLine("City={0}", city);
            Console.WriteLine("Street={0}", street);
            Console.WriteLine("Pin={0}", pin);
            Console.WriteLine("House number={0}", housenumber);
            Console.ReadLine();
        }
    }
}
