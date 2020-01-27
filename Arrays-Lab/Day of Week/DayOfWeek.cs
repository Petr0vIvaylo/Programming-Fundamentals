using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Invalid Day!"
                                   ,  "Monday"
                                   , "Tuesday"
                                   , "Wednesday"
                                   , "Thursday"
                                   , "Friday"
                                   , "Saturday"
                                   , "Sunday"
            };

            if (dayNumber <0 || dayNumber >7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[dayNumber]);
            }
                
            

        }
    }
}
