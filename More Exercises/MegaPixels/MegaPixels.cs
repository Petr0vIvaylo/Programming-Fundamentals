using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaPixels
{
    class MegaPixels
    {
        static void Main(string[] args)
        {
            double resolutionWidth = double.Parse(Console.ReadLine());
            double resolutionheight = double.Parse(Console.ReadLine());

            double megaPixels =Math.Round ((resolutionheight * resolutionWidth) / 1000000,1);
            Console.WriteLine("{0}x{1} => {2}MP",resolutionWidth,resolutionheight,megaPixels);

        }
    }
}
