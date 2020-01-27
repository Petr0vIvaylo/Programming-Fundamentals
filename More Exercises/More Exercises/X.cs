using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Exercises
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n/2; i++)
            {
                for (int leftSpace = 0; leftSpace < i; leftSpace++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int midSpace = 0; midSpace < n-2-i*2; midSpace++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
            }

            Console.Write(new string(' ', n / 2));
            Console.WriteLine("x");

            for (int i = 0; i < n / 2; i++)
            {
                for (int leftSpace = n/2-1; leftSpace > i; leftSpace--)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int midSpace = 0; midSpace <= i * 2; midSpace++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
            }
        }
    }
}
