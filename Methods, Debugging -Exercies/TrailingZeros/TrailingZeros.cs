using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TrailingZeros
{
    class TrailingZeros
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = Factorials(n);
            Console.WriteLine(CountingZeros(result));
        }

        static BigInteger Factorials(int n)
        {
            BigInteger factorial = 1;

            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }

            return factorial;
        }
        static BigInteger CountingZeros(BigInteger result)
        {
            int counter = 0;
            while (true)
            {
                if (result % 10 == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                result /= 10;
            }
            return counter;
        }
    }
}
