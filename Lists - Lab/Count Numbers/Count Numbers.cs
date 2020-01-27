using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToList();

            input.Sort();
            int counter = 1;
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{input[i]} -> {counter}");
                    counter = 1;
                }
                
            }
            Console.WriteLine("{0}"+ " -> "+"{1}",input[input.Count-1],counter);
        }
    }
}
