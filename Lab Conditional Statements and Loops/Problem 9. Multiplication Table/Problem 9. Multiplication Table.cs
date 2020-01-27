using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiply = 0;

            for (int i = 1; i <= 10; i++)
            {
                multiply = i * n;
                Console.WriteLine("{0} X {1} = {2}" ,n , i ,multiply);
            }
        }
    }
}
