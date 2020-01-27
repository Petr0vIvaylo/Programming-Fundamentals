using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int multiply = 0;


            if (m<=10)
            {
                for (int i = m; i <= 10; i++)
                {
                    multiply = i * n;
                    Console.WriteLine("{0} X {1} = {2}", n, i, multiply);
                }
            }
            else
            {
                Console.WriteLine("{0} X {1} = {2}", n, m, n*m);
            }


        }
    }
}
