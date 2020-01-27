using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            FindPrimesInRange(n, m);
            
            
        }
        static List<int> FindPrimesInRange(int n,int m)
        {
            
            var primes = new List<int>();
            for (int num = n; num <= m; num++)
            {
                
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num % divider == 0)    
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    
                    primes.Add(num);
                }
            }
            Console.WriteLine(string.Join(", ",primes)); 
            return primes;
        }
    }
}
