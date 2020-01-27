using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsToBuy = int.Parse(Console.ReadLine());

            double subTotal = 0;

            for (int i = 0; i < itemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    Console.WriteLine("Adding {0} {1}s to cart.", itemCount, itemName);
                }
                else
                {
                    Console.WriteLine("Adding {0} {1} to cart.", itemCount, itemName);
                }
                subTotal += itemPrice * itemCount;
            }
            if (subTotal < budget)
            {
                Console.WriteLine("Subtotal: ${0:f2}", subTotal);
                Console.WriteLine("Money left: ${0:f2}", budget - subTotal);
            }
            else
            {
                Console.WriteLine("Subtotal: ${0:f2}", subTotal);
                Console.WriteLine("Not enough. We need ${0:f2} more.",Math.Abs( budget - subTotal));
            }
        }
    }
}
