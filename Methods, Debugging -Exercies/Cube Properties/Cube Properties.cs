using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            switch (type)
            {
                case "face":FaceDiagonalsOfCube(side);break;
                case "space": SpaceDiagonalsOfCube(side);break;
                case "volume":VolumeOfCube(side);break;
                case "area":SurfaceAreaOfCube(side);break;

                default:
                    break;
            }
        }
        static void FaceDiagonalsOfCube(double side)
        {
            double faceDiagonal = Math.Sqrt(2 * side * side);
            Console.WriteLine("{0:F2}",faceDiagonal);
        }
        static void SpaceDiagonalsOfCube(double side)
        {
            double spaceDiagonal = Math.Sqrt(3 * side * side);
            Console.WriteLine("{0:F2}", spaceDiagonal);
        }
        static void VolumeOfCube(double side)
        {
            double volume = Math.Pow(side,3);
            Console.WriteLine("{0:F2}", volume);
        }
        static void SurfaceAreaOfCube(double side)
        {
            double area = 6 * (side * side);
            Console.WriteLine("{0:F2}", area);
        }
    }
}
