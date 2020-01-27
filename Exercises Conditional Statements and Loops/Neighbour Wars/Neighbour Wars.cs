using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int roundCounter = 1;
            int peshoHealth = 100;
            int goshoHealth = 100;

            for (int round = 1; round < 100; round++)
            {
                if (peshoHealth >0 || goshoHealth >0 )
                {
                    if (round % 2 == 1)
                    {
                        goshoHealth -= peshoDamage;
                        if (goshoHealth<=0)
                        {
                            break;
                        }
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                    }
                    else
                    {
                        peshoHealth -= goshoDamage;
                        if (peshoHealth <=0)
                        {
                            break;
                        }
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                    }
                    if (peshoHealth <= 0 || goshoHealth <= 0)
                    {
                        break;
                    }
                    if (round % 3 == 0)
                    {
                        peshoHealth += 10;
                        goshoHealth += 10;
                    }
                    roundCounter++;
                }
            }

            if (peshoHealth > goshoHealth)
            {
                Console.WriteLine("Pesho won in {0}th round.", roundCounter);
            }
            else
            {
                Console.WriteLine("Gosho won in {0}th round.", roundCounter);
            }

        }
    }
}
