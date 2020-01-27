using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int combinations = 0;
            int maxboundary = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {

                    if (maxboundary >= sum)
                    {
                        break;
                    }
                    maxboundary += (i * j) * 3;
                    combinations++;
                }
            }
                if (maxboundary >= sum)
                {
                    Console.WriteLine("{0} combinations", combinations);
                    Console.WriteLine("Sum: {0} >= {1}", maxboundary, sum);
                }
                else
                {
                    Console.WriteLine("{0} combinations", combinations);
                    Console.WriteLine("Sum: {0}", maxboundary);
                }


            
        }
    }
}
