using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ').ToArray();
            string[] secondInput = Console.ReadLine().Split(' ').ToArray();

            var lenght = Math.Min(firstInput.Length,secondInput.Length);

            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    leftCount++;
                }
                if (firstInput[firstInput.Length - i -1] == secondInput[secondInput.Length - i -1])
                {
                    rightCount++;
                }
            }
            Console.WriteLine(Math.Max(leftCount,rightCount));
        }
    }
}
