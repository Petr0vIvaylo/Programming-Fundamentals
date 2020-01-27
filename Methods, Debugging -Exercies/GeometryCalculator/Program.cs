using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string typeOfFigure = Console.ReadLine();
            switch (typeOfFigure)
            {
                case "triangle": Triangle(); break;
                case "square": Sqare(); break;
                case "rectangle": Rectangle(); break;
                case "circle": Circle(); break;

                default:
                    break;
            }
        }
        static void Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", (side*height)/2);
        }
        static void Sqare()
        {
            double sideOfSquare = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",Math.Pow(sideOfSquare,2) );
        }
        static void Rectangle()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", sideA * sideB);
        }
        static void Circle()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Math.PI*Math.Pow(radius,2));
        }
        
    }
    
}
