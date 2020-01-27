using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            printHeader(n);
            for (int i = 0; i < n-2; i++)
            {
                printBody(n);
            }
            
            printHeader(n);
        }
        static void printHeader(int n)
        {
            Console.WriteLine(new string('-',2*n) );
        }
        static void printBody(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
