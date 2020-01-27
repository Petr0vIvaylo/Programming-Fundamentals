using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            IsPrime();
        }
        static void IsPrime()
        {
            //Console.Write("n = ");
            long n = long.Parse(Console.ReadLine());
            //Console.Write("m = ");
            //int m = int.Parse(Console.ReadLine());
            //for (long num = n; num <= n; num++)
            //{
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(n);
                //while (divider <= maxDivider)
                //{
                    if (n % divider == 0)

                    {
                        prime = false;
                        //break;
                    }
                    divider++;
               // }
                if (prime == true)
                {
                    Console.WriteLine(prime);
                }
                else
                {
                    Console.WriteLine(prime);
                }
            //}
        }
    }
}
