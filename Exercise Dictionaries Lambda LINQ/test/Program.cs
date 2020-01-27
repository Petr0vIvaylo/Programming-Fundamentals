using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBallNumber = int.Parse(Console.ReadLine());

            double[] snowballSnow= new double[snowBallNumber];
            double[] snowballTime= new double[snowBallNumber];
            double[] snowballQuality= new double[snowBallNumber];

            double[] snowballValue = new double[snowBallNumber];

            for (int i = 0; i < snowBallNumber; i++)
            {
                 snowballSnow[i] = double.Parse(Console.ReadLine());
                 snowballTime[i] = double.Parse(Console.ReadLine());
                 snowballQuality[i] = double.Parse(Console.ReadLine());

                snowballValue[i] =(double) Math.Pow((snowballSnow[i] / snowballTime[i]),snowballQuality[i]);
            }

            int count = 0;

            for (int i = 0; i < snowballValue.Length; i++)
            {
                if (snowballValue[i] == snowballValue.Max())
                {
                    count = i;
                }
            }

            Console.WriteLine($"{ snowballSnow[count]} : { snowballTime[count]} = { snowballValue[count]} ({ snowballQuality[count]})");
        }
    }
}
