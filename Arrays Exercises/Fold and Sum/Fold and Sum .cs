using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Length / 4;

            int[] firstElements = input.Take(k).Reverse().ToArray();
            int[] secondElements = input.Reverse().Take(k).ToArray();

            int[] firstRow = firstElements.Concat(secondElements).ToArray();
            int[] secondRow = input.Skip(k).Take(2 * k).ToArray();


            int[] sum = new int[2 * k];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
