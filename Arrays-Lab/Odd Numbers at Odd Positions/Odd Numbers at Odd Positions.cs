using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            int[] arrayNumbers = new int[stringArray.Length];

            

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = int.Parse(stringArray[i]);
                if (i % 2 !=0)
                {
                    if (arrayNumbers[i] % 2 != 0)
                    {
                        Console.WriteLine("Index {0} -> {1}", i, arrayNumbers[i]);

                    }
                }
                
            }
           
        }
    }
}
