﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse( Console.ReadLine());
            printSign(n);
        }
        static void printSign(int n)
        {
            if (n>0)
            {
                Console.WriteLine("The number {0} is positive.",n);
            }
            else if (n<0)
            {
                Console.WriteLine("The number {0} is negative.",n);
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
