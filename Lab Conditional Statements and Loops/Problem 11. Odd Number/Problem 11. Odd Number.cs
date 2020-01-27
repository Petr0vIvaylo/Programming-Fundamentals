using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 ==1)
            {
                Console.WriteLine("The number is: {0}", Math.Abs(n));
            }
            else
            {
                while (n % 2 == 0)
                {

                    Console.WriteLine("Please write an odd number.");
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 != 0)
                    {
                        Console.WriteLine("The number is: {0}", Math.Abs(number));
                        break;
                    }
                }
                
            }


        }
    }
}
