﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=2* n; i+=2)
            {
                sum += i;
                    Console.WriteLine(i);
                
            }
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
