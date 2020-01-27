using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(height,width));
        }
        static double GetTriangleArea(double height,double width)
        {
            return (width * height) / 2;
        }
    }
}
