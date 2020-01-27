using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> input= Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = input.Count;
            for (int i = count-1; i >= 0; i--)
            {
                if (input[i] < 0)
                {
                    input.Remove(input[i]);
                }
            }
            if (input.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                input.Reverse();
                Console.WriteLine(string.Join(" ", input));
            }
            
        }
    }
}
