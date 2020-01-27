using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0 && i % 2 !=0)
                {
                    Console.WriteLine("Index {0} -> {1}",i,input[i]);
                }
            }
            
        }
    }
}
