using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_Lambda_LINQ___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var dict = new SortedDictionary<double, int>();
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
            foreach (var item in dict)
            {
                Console.WriteLine(string.Join("\r\n", item.Key + " -> " + item.Value).ToString());
            }
            
        }
    }
}
