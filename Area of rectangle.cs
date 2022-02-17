using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Area_of_rectangle
    {
        static void Main(string[]args)
        {
            int height, width, area;

            Console.Write("Enter height:\t");
            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width:\t");
            width = Convert.ToInt32(Console.ReadLine());

            area = height * width;

            Console.WriteLine("\nArea of rectangle is {0}", area);
            Console.ReadLine();
        }
    }
}
