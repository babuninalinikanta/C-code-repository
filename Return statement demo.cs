using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Return_statement_demo
    {
        public int add(int num1,int num2)
        {
            //Returns the addition of num1 and num2
            return num1 + num2;
        }
        static void Main(string[]args)
        {
            Return_statement_demo obj = new Return_statement_demo();
            int result;
            //Calling the function add that will return 9 to the result variable.
            result = obj.add(3, 6);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
