using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Area_of_circle
    {
        static void Main(string[]args)
        {
            double pi = 3.14;
            double radius, area;
            Console.Write("Enter the radius of circle:\t");
            radius = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(radius, 2);
            Console.WriteLine("Area of circle={0}", area);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
