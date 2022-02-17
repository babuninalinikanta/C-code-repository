using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Logical_operator2
    {
        static void Main(string[]args)
        {
            string username, userpassword;

        label://creating label
            Console.Write("\n\nEnter your login name:\t");
            username = Console.ReadLine();

            Console.Write("Enter your password:\t");
            userpassword = Console.ReadLine();

            try
            {
                if((username=="Steven"||username=="Clark") && (userpassword=="demopass"))
                {
                    Console.WriteLine("\nLogin successful.");
                }
                else
                {
                    Console.WriteLine("\nUnauthorized Access. Aborting.....");
                }

                Console.Write("\n\nPress Y or y to continue. Press N or n to exit:\t");
                char ans = Convert.ToChar(Console.ReadLine());
                if(ans=='Y' || ans=='y')
                {
                    goto label;
                }
                else
                {
                    Console.WriteLine("Press Enter key for aborting...");
                    Console.ReadLine();
                    return;
                }
            }
            catch
            {

            }

        }
    }
}
