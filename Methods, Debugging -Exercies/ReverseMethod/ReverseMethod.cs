using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseMethod
{
    class ReverseMethod
    {
        public static string ReversedInput(string input)
        {
            string reversedInput = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }
            return reversedInput;
        }

        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            
            Console.WriteLine(ReversedInput(input));
        }
    }
}
