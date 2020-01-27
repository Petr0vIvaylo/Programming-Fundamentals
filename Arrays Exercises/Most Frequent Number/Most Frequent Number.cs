using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            int maxEqualElements = 0;
            int lastElementOfMax = 0;

            for (int i = 0; i <= numbers.Length/2 -1 ; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (maxEqualElements <= counter)
                    {
                        maxEqualElements = counter;
                        lastElementOfMax = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }

            }

            //if (maxEqualElements > 1)
            //{
            //    for (int i = 0; i < maxEqualElements; i++)
            //    {
            //        Console.Write(lastElementOfMax + " ");
            //    }
            //    Console.WriteLine();
            //}
            Console.Write(lastElementOfMax + " ");
        }

    
    }
}
