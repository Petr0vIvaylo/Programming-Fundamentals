using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes= int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60)
            {
                minutes = minutes  % 60;
                hours++;
                if (hours >= 23)
                {
                    hours = 0;
                }
            }
            if (minutes <10)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            
        }
    }
}
