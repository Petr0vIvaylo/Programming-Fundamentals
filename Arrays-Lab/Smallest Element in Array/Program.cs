using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            int[] arrayNumbers =new int[stringArray.Length];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = int.Parse(stringArray[i]);
            }
            int minValue = int.MaxValue;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] < minValue)
                {
                    minValue = arrayNumbers[i];
                }
            }
            Console.WriteLine(minValue);

        }
    }
}
