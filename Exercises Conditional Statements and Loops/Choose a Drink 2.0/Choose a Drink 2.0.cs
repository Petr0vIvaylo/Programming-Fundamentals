using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_02

{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double drinkPrice = 0;
            if (profesion == "Athlete")
            {
                drinkPrice = quantity * 0.7;
                Console.WriteLine("The Athlete has to pay {0:F2}.",drinkPrice);
            }
            else if (profesion == "Businessman" || profesion == "Businesswoman")
            {
                if (profesion == "Businessman")
                {
                    drinkPrice = quantity;
                    Console.WriteLine("The Businessman has to pay {0:F2}.", drinkPrice);
                }
                else
                {
                    drinkPrice = quantity;
                    Console.WriteLine("The Businesswoman has to pay {0:F2}.", drinkPrice);
                }
                
            }
            else if (profesion == "SoftUni Student")
            {
                drinkPrice = quantity * 1.7;
                Console.WriteLine("The SoftUni Student has to pay {0:F2}.",drinkPrice);
            }
            else
            {
                drinkPrice = quantity * 1.2;
                Console.WriteLine("The {0} has to pay {1:F2}.",profesion,drinkPrice);
            }

        }
    }
}
