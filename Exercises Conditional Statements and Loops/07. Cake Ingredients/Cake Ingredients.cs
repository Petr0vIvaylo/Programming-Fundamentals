using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient;

            for (int i = 0; i <= 20; i++)
            {
                ingredient = Console.ReadLine();

                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
            }
        }
    }
}
