using System;
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
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            string result = FindLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
            string printResult = "";

            if (result == "first")
            {
                 printResult = ClosestToZeroPoint(x1, y1, x2, y2);
            }
            else
            {
                 printResult = ClosestToZeroPoint(x3, y3, x4, y4);
            }
        }

        static void ClosestToZeroPoint()
        {

        }


        static string FindLongestLine(double x1, double y1, double x2, double y2, double x3, double y3
            , double x4, double y4)
        {
            double first = Math.Sqrt(x2 - x1 * x2 - x1 + y2 - y1 * y2 - y1);
            double second = Math.Sqrt(x4 - x3 * x4 - x3 + y4 - y3 * y4 - y3);
            if (first < second)
            {
                return "first";
            }
            else
            {
                return "second";
            }
        }
    }
}