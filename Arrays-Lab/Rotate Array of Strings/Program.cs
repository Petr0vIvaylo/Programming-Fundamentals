using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            string[] reversedArray = new string[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                reversedArray[(i+1)% stringArray.Length] = stringArray[i];
            }
            Console.WriteLine(string.Join(" ",reversedArray));

        }
    }
}
