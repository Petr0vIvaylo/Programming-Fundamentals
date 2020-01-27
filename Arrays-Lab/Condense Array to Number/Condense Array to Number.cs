using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int condensedArray = array.Length ;

            do
            {
                for (int i = 0; i < condensedArray - 1; i++)
                {
                    array[i] = array[i] + array[i + 1];
                }
                condensedArray--;


            } while (condensedArray > 1);

            Console.WriteLine(array[0]);
            
            
        }
    }
}
