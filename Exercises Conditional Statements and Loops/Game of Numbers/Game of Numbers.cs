using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationCounter = 0;
            int lastDigitOne = 0;
            int lastDigitTwo = 0;
            bool magicNumberFound = false;


            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinationCounter++;
                    if (i + j == magicNumber)
                    {
                        lastDigitOne = i;
                        lastDigitTwo = j;
                        magicNumberFound = true;
                    }

                }
            }
                if (magicNumberFound )
                {
                    Console.WriteLine("Number found! {0} + {1} = {2}", lastDigitOne, lastDigitTwo, magicNumber);
                }
                else
                {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
                }
            
        }
    }
}
