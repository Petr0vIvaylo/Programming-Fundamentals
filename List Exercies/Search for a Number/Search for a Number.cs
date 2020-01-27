using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //List<int> result = new List<int>();

            
                input.RemoveRange(0, numbers[1]);
            
            
                if (input.Contains(numbers[2]) == true)
                {
                    Console.WriteLine("YES!");
                  
                }
                else
                {
                    Console.WriteLine("NO!");
                   
                }
 
            
        }
    }
}
