using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            double[] numbersArr = { numbers.Length };

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = double.Parse(numbers[i]);
            }
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] *= p;
            }

            for (int i = 0; i < numbersArr.Length; i++)
            {
                Console.Write("{0} ", numbersArr[i]);
            }

            
        }
    }
}
