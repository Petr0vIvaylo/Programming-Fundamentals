using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(ReiseToPower(number, power));
        }
        static double ReiseToPower(double number , double power)
        {
            return Math.Pow(number, power);
        }
    }
}
