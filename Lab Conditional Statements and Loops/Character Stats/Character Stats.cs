using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = (Console.ReadLine());
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}",name);
            Console.Write("Health: |");
            for (int health = 0; health < currentHealth; health++)
            {
                Console.Write("|");
            }
            for (int health = 0; health <  Math.Abs(maxHealth- currentHealth) ; health++)
            {
                Console.Write(".");
            }
            Console.Write("|");
            Console.WriteLine();


            Console.Write("Energy: |");
            for (int energy = 0; energy < currentEnergy; energy++)
            {
                Console.Write("|");
            }
            for (int energy = 0; energy < Math.Abs(maxEnergy - currentEnergy); energy++)
            {
                Console.Write(".");
            }
            Console.Write("|");
            Console.WriteLine();
        }
    }
}
