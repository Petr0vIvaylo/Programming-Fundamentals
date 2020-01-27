using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (Math.Abs(input[j] - input[i]) == number)
                    {
                        counter++;
                    }
                }
               input.di
            }
            Console.WriteLine(counter);
        }
    }
}
