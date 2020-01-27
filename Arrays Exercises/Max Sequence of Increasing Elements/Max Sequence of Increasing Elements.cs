using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] increasingNumbers = new int[numbers.Length];

            int counter = 0;
            int maxEqualElements = 0;
            int lastElementOfMax = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    counter++;
                    if (maxEqualElements <= counter)
                    {
                        maxEqualElements = counter;
                        lastElementOfMax = numbers[i];
                        increasingNumbers[i-1] = lastElementOfMax;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            
            if (maxEqualElements > 1)
            {
                for (int j = 0; j < maxEqualElements; j++)
                {
                    Console.Write(increasingNumbers[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

