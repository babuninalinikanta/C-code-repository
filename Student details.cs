using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Student_details
    {
        static void Main(string[]args)
        {
            string name;
            int rollnum;
            int age;
            string standard;
            string university_name;
            Console.WriteLine("Enter name of student");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter roll number of student");
            rollnum = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter age of student");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter standard of student");
            standard = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter university name of student");
            university_name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("==================");
            Console.WriteLine("Details of student");
            Console.WriteLine("==================");
            Console.WriteLine("Name={0}", name);
            Console.WriteLine("Roll number={0}", rollnum);
            Console.WriteLine("Age={0}", age);
            Console.WriteLine("Standard={0}", standard);
            Console.WriteLine("Name of university={0}", university_name);
            Console.ReadLine();
        }
    }
}
