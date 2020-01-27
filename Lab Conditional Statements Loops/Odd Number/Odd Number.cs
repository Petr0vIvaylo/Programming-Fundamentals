using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                   
                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(number));
                    break;

                }
                number = int.Parse(Console.ReadLine());
            }
           
        }
    }
}
