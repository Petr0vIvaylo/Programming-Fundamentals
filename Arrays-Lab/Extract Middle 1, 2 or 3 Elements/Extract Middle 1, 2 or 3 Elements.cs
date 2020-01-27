using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length % 2 == 0)
            {
                Console.WriteLine(string.Join(", ", array[(array.Length / 2) - 1],array[array.Length / 2]));
            }
            else if (array.Length % 2 != 0 && array.Length >1)
            {
                Console.WriteLine(string.Join(", ",array[array.Length/2-1],array[array.Length/2],array[array.Length/2+1]));
            }
            else 
            {
                Console.WriteLine("{ "+array[0]+" }");
            }
        }
    }
}
