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
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = input.Length / 4;
            //List<int> firstRow = new List<int>();
            //List<int> secondRow = new List<int>();

            
            int[] row1left = input.Take(k).Reverse().ToArray();
            int[] row1right = input.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = input.Skip(k).Take(2 * k).ToArray();

            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
