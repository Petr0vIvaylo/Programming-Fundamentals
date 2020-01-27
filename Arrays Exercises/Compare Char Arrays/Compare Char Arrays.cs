using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var arrayTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int lenght = Math.Max(arrayOne.Length, arrayTwo.Length);

            for (int i = 0; i < lenght - 1; i++)
            {
                if (arrayOne[0] <= arrayTwo[0])
                {
                    if (arrayOne.Length <= arrayTwo.Length)
                    {
                        Console.WriteLine(string.Join("", arrayOne));
                        Console.WriteLine(string.Join("", arrayTwo));
                        break;
                    }
                    else if (arrayOne.Length > arrayTwo.Length)
                    {
                        Console.WriteLine(string.Join("", arrayTwo));
                        Console.WriteLine(string.Join("", arrayOne));
                        break;
                    }
                }
                else if (arrayOne[0] > arrayTwo[0])
                {
                    if (arrayOne.Length <= arrayTwo.Length)
                    {
                        Console.WriteLine(string.Join("", arrayTwo));
                        Console.WriteLine(string.Join("", arrayOne));
                        break;
                    }
                    else if (arrayOne.Length > arrayTwo.Length)
                    {
                        Console.WriteLine(string.Join("", arrayTwo));
                        Console.WriteLine(string.Join("", arrayOne));
                        break;
                    }

                }
            }

        }
    }
}