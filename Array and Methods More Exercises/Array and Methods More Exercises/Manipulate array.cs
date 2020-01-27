using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Methods_More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Distinct")
                {
                   input= input.Distinct().ToArray();
                }
                if (command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string element = command[2];
                    input[index] = element;
                }
            }
            Console.WriteLine(string.Join(", ",input));

        }
    }
}
