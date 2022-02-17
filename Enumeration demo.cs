using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //Creating enumeration for storing day.
    public enum attendance
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class Enumeration_demo
    {
        static void Main(string[]args)
        {
            attendance present = attendance.Monday;//Valid
            Console.WriteLine(present);

            //attendance absent = attendance.Sunday;//Invalid
            Console.ReadLine();
        }
    }
}
