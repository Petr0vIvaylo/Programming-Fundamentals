using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input= Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            int index = 0;
            bool numberFound = false;
            for (int i = input.Length-1; i >=0; i--)
            {
                if (input[i] ==number)
                {
                    index = i;
                    numberFound = true;
                    break;
                }
            }
            long sum = 0;
            if (numberFound)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += input[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
