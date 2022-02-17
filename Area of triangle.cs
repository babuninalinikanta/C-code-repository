using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Area_of_triangle
    {
        static void Main(string[]args)
        {
            double side1, side2, side3,s;
            double area;
            Console.Write("Enter first side:\t");
            side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second side:\t");
            side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter third side:\t");
            side3 = double.Parse(Console.ReadLine());
            s = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            Console.Write("Area of triangle is:\t{0}", area);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
