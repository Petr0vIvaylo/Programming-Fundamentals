﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            CenterPoints(x1,y1,x2,y2);
        }
        static void CenterPoints(double x1,double y1,double x2,double y2)
        {
            if (x1 <= x2 && y1<=y2)
            {
                Console.WriteLine("({0}, {1})",x1,y1);
                
            }
            else if (x1 > x2 && y1 > y2)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
           
               
            
        }
    }
}
