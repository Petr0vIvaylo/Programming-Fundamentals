using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGalery
{
    class PhotoGalery
    {
        static void Main(string[] args)
        {
            int pictureNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            double resolutionWidth  = double.Parse(Console.ReadLine());
            double resolutionHeight = double.Parse(Console.ReadLine());

            string memorySize = "";
            string formatSize="";

            if (photoSize < 1000 )
            {
                memorySize = "B";
            }
            else if ( photoSize < 1000000)
            {
                memorySize = "KB";
                photoSize = photoSize / 1000;
            }
            else
            {
                memorySize = "MB";
                photoSize =photoSize / 1000000;
            }

            if (resolutionWidth == resolutionHeight)
            {
                formatSize = "(square)";
            }
            else if (resolutionWidth > resolutionHeight)
            {
                formatSize = "(landscape)";
            }
            else if (resolutionHeight > resolutionWidth)
            {
                formatSize = "(portrait)";
            }
            


            Console.WriteLine("Name: DSC_{0:D4}.jpg", pictureNumber);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:D2}:{4:D2}", day,month,year,hours,minutes);
            Console.WriteLine("Size: {0}{1}",photoSize,memorySize);
            Console.WriteLine("Resolution: {0}x{1} {2}", resolutionWidth,resolutionHeight, formatSize);


        }
    }
}
