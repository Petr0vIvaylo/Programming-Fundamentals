using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            var input = Console.ReadLine().ToLower().Split(separators,StringSplitOptions.RemoveEmptyEntries);

            var result = input.Distinct().Where(word => (word.Length < 5));
            Console.WriteLine(string.Join(", ",result.OrderBy(word => word)));
        }
    }
}
