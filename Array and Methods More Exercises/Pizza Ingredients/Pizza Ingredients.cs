using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaIngredients= Console.ReadLine().Split().ToArray();
            int stringLength = int.Parse(Console.ReadLine());
            
            int counter = 0;
            string[] addetProducts = new string[10];
            for (long i = 0; i < pizzaIngredients.Length; i++)
            {
                if (pizzaIngredients[i].LongCount() == stringLength )
                {
                    Console.WriteLine("Adding {0}.",pizzaIngredients[i]);
                    addetProducts[counter] = pizzaIngredients[i];
                    counter++;

                    if (counter == 10)
                    {
                        break;
                    }
                }
            }
            Array.Resize(ref addetProducts, counter);
            Console.WriteLine("Made pizza with total of {0} ingredients.",counter);
            
            Console.WriteLine("The ingredients are: " + string.Join(", ", addetProducts) + ".");
        }
    }
}
