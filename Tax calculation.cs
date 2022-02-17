using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Tax_calculation
    {
        static void Main(string[]args)
        {
            double money, percentage, totaltax=0;            
            Console.Write("Enter the amount of money:\t");
            money = Convert.ToDouble(Console.ReadLine());
            if(money<10000)
            {
                percentage = 5;
                totaltax = (money * percentage) / 100;                
            }
            else if(money>=10000 && money<=100000)
            {
                percentage = 8;
                totaltax = (money * percentage) / 100;                
            }
            else if(money>100000)
            {
                percentage = 8.5;
                totaltax = (money * percentage) / 100;                
            }
            Console.WriteLine("Total tax={0}", totaltax);
            Console.ReadLine();
        }
    }
}
