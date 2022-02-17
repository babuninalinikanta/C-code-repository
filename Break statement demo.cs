using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Break_statement_demo
    {
        static void Main(string[]args)
        {
            int i = 0;
            while(i<100)
            {
                Console.WriteLine(i);
                if(i==20)
                {
                    Console.WriteLine("Breaking the current segment");
                    break;
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
