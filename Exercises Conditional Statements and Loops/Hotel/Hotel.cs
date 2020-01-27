using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            int nightsForStudio = nightsCount;
            int nightsForDouble = nightsCount;
            int nightsForSuite = nightsCount;

            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;
            double totalPrice = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                doubleRoom = 65;
                suite = 75;
                if (nightsCount > 7 && month == "May")
                {
                    studio = studio - (studio * 0.05);
                    totalPrice = studio * nightsCount;
                }
                else if (nightsCount > 7 && month == "October" && nightsCount < 14)
                {
                    nightsForStudio--;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                doubleRoom = 72;
                suite = 82;
                if (month == "September" && nightsCount >7 && nightsCount <14)
                {
                    nightsForStudio--;
                }

                if (nightsCount > 14)
                {
                    doubleRoom = doubleRoom - (doubleRoom * 0.1);
                    totalPrice = doubleRoom * nightsCount;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                doubleRoom = 77;
                suite = 89;
                if (nightsCount > 14)
                {
                    suite = suite - (suite * 0.15);
                    totalPrice = suite * nightsCount;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.",studio*nightsForStudio);
            Console.WriteLine("Double: {0:f2} lv.", doubleRoom * nightsForDouble);
            Console.WriteLine("Suite: {0:f2} lv.", suite * nightsForSuite);
        }
    }
}
