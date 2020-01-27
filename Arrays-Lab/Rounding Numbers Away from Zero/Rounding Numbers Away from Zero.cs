using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr =Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondarr = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                secondarr[i] = arr[i];
                arr[i] = Math.Round(arr[i],0 ,MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}",secondarr[i] ,arr[i]);
            }
            
        }
    }
}
