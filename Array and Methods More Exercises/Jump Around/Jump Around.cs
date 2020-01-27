using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // 3 7 12 2 10
            int index = 0;
            long sum = 0;
            
            while (true)
            {
                int currentIndex = index;
                sum += input[index];
                index += input[index];

                if (index > input.Length-1)
                {
                    
                    index = currentIndex - input[currentIndex]; ;
                    if (index < 0 )
                    {
                        break;
                    }
                }
                
                
            }
            Console.WriteLine(sum);
        }
    }
}
