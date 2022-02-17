using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Checked_statement_demo
    {
        static void Main(string[]args)
        {
            int num;
            //Assign maximum value
            num = int.MaxValue;
            try
            {
                checked
                {
                    //forces stack overflow exception
                    num = num + 1;
                    Console.WriteLine(num);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
