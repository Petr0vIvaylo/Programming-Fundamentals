using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[n];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }


            int[] reversedArray = new int[numbersArray.Length];

            for (int index = 0; index < numbersArray.Length; index++)
            {
                reversedArray[numbersArray.Length- index - 1] = numbersArray[index];
            }
            // Print the reversed array
            for (int index = 0; index < numbersArray.Length; index++)
            {
                Console.Write(reversedArray[index] + " ");
            }
        }

    }
}
