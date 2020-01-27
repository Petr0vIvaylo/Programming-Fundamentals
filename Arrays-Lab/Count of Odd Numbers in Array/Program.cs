using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            int[] arrayNumbers = new int[stringArray.Length];

            int counter = 0;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = int.Parse(stringArray[i]);
                if (arrayNumbers[i] % 2 != 0 )
                {
                    counter++;
                    
                }
            }
            Console.WriteLine(counter);
        }
    }
}
