using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extendet_Array_Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int counter = 1;

            for (int i = input.Length - 1; i > 0; i--)
            {
                if (input[i]==input[i-1] )
                {
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine($"{input[i]} {input[i]} {input[i]}");
                        break;
                    }
                }
                else
                {
                    counter = 1;
                }
                
            }
            

        }
    }
}
