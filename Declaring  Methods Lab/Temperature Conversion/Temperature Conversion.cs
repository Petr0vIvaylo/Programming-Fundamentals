﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",fahrenheitToCelsius(fahrenheit));
        }
        static double fahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;

        }
    }
}
