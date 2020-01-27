using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> numbersAsString = Console.ReadLine()
                .Split(' ')
                .ToList();
            
            
           List<string> reversedNumbers = new List<string>();
           
           for (int i = 0; i < numbersAsString.Count; i++)
           {
               string reversedNumber = string.Empty;
               for (int j = numbersAsString[i].Length - 1; j >= 0; j--)
               {
                   reversedNumber += numbersAsString[i][j];
               }
               reversedNumbers.Add(reversedNumber);
           }
           
           List<double> numbersToSum = reversedNumbers.Select(double.Parse).ToList();
           
           Console.WriteLine(numbersToSum.Sum());

        }
    }
}
