using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[n];
            int arraySum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
                arraySum += numbersArray[i];
            }
            Console.WriteLine(arraySum);
        }
    }
}
