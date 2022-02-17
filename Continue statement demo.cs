using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Continue_statement_demo
    {
        static void Main(string[]args)
        {
            int i = 0;
            while(i<10)
            {
                i++;
                if(i<6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
