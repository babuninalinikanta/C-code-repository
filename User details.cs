﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class User_details
    {
        static void Main(string[]args)
        {
            string name;
            string city;
            sbyte age;
            int pin;

            //\n is used for line-break
            Console.WriteLine("Enter your name\n");
            name = Console.ReadLine();

            Console.WriteLine("Enter your city\n");
            city = Console.ReadLine();

            Console.WriteLine("Enter your age\n");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin\n");
            pin = Int32.Parse(Console.ReadLine());

            //Printing message to console
            //formatting output
            Console.WriteLine("==========");
            Console.WriteLine("Your complete address:");
            Console.WriteLine("=========\n");

            Console.WriteLine("Name={0}", name);
            Console.WriteLine("City={0}", city);
            Console.WriteLine("Age={0}", age);
            Console.WriteLine("Pin={0}", pin);
            Console.WriteLine("============");

            Console.ReadLine();


        }
    }
}
