using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            int smallHall = 2500;
            int terrace = 5000;
            int greatHall = 7500;

            if (ppl <= 50)
            {
                if (package == "Normal")
                {
                    double cost = (smallHall + 500.0) - ((smallHall + 500.0) * 0.05);
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", cost/ppl);
                }
                else if (package == "Gold")
                {
                    double cost = (smallHall + 750.0) - ((smallHall + 750.0) * 0.1);
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
                else if (package == "Platinum")
                {
                    double cost = (smallHall + 1000.0) - ((smallHall + 1000.0) * 0.15);
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
            }

            else if (ppl > 50 && ppl <=100)
            {
                if (package == "Normal")
                {
                    double cost = (terrace + 500.0) - ((terrace + 500.0) * 0.05);
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
                else if (package == "Gold")
                {
                    double cost = (terrace + 750.0) - ((terrace + 750.0) * 0.1);
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
                else if (package == "Platinum")
                {
                    double cost = (terrace + 1000.0) - ((terrace + 1000.0) * 0.15);
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
            }

            else if (ppl >100 && ppl <= 120)
            {
                if (package == "Normal")
                {
                    double cost = (greatHall + 500.0) - ((greatHall + 500.0) * 0.05);
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
                else if (package == "Gold")
                {
                    double cost = (greatHall + 750.0) - ((greatHall + 750.0) * 0.1);
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
                else if (package == "Platinum")
                {
                    double cost = (greatHall + 1000.0) - ((greatHall + 1000.0) * 0.15);
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", cost / ppl);
                }
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
