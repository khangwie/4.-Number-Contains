using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Number_Contains
{
    internal class Program
    {
        static bool IfNumberContains3(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit == 3)
                    return true;

                number /= 10;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(); // calling nethods whether a number contains 3 digit or Console.MriteLine("Is the number contains 3 digit");
            Console.WriteLine("Is the number contains 3 digits");
            //int nun = 7201432;

            int num = 87501;
            bool contains3 = IfNumberContains3(num);
            if (contains3)
            {
                Console.WriteLine($"The number does not contain ({num}) -> {contains3}");
            }
            else
            {
                Console.WriteLine($"The number does not contain ({num}) -> {contains3}");
                Console.ReadLine();
            }
        }
         
    
    }
}
