using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int j = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(j);
                sum += j;
                j += 2;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
