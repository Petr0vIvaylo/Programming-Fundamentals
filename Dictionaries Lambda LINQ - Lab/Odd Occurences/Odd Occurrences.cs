using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();

            var dict = new Dictionary<string, int>();

            foreach (var number in input)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict[number] = 1;
                }
            }
            var output = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value % 2 !=0)
                {
                    output.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
