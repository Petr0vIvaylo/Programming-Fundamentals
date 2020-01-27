using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            var reversedList = new List<string>();

            foreach (var item in input)
            {
                List<string> num = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                reversedList.AddRange(num);
            }
            Console.WriteLine(string.Join(" ",reversedList));
        }
    }
}
