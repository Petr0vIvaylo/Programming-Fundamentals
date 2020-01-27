using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours= int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int afterHalfHour= hours;
            int mintesAfrterHalfHour = minutes + 30;
            if (mintesAfrterHalfHour >= 60)
            {
                mintesAfrterHalfHour %= 60;
            }
            

            if (minutes + 30 >= 60)
            {
                afterHalfHour++;
            }
            if (afterHalfHour>=23)
            {
                afterHalfHour = 0;
            }
            Console.WriteLine("{0}:{1:d2}", afterHalfHour, mintesAfrterHalfHour );
            

        }
    }
}
