using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal gamePrice;
            decimal budgetLeft = money;
            decimal moneySpent = 0m;
            string gameName = Console.ReadLine();

            while (gameName != "Game Time")
            {
                
                if (gameName == "OutFall 4")
                {
                    gamePrice = 39.99m;
                    if (budgetLeft < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}",gameName);
                        budgetLeft -= gamePrice;
                    }
                    
                    moneySpent += gamePrice;
                }
                else if (gameName == "CS: OG")
                {
                    gamePrice = 15.99m;
                    if (budgetLeft < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", gameName);
                        budgetLeft -= gamePrice;
                    }
                    
                    moneySpent += gamePrice;
                }
                else if (gameName == "Zplinter Zell")
                {
                    gamePrice = 19.99m;
                    if (budgetLeft < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", gameName);
                        budgetLeft -= gamePrice;
                    }
                    
                    moneySpent += gamePrice;
                }
                else if (gameName == "Honored 2")
                {
                    gamePrice = 59.99m;
                    if (budgetLeft < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", gameName);
                        budgetLeft -= gamePrice;
                    }
                    
                    moneySpent += gamePrice;
                }
                else if (gameName == "RoverWatch")
                {
                    gamePrice = 29.99m;
                    if (budgetLeft < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", gameName);
                        budgetLeft -= gamePrice;
                    }
                    
                    moneySpent += gamePrice;
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99m;
                    if (budgetLeft < gamePrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", gameName);
                        budgetLeft -= gamePrice;
                    }
                    
                    moneySpent += gamePrice;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budgetLeft <=0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                
                gameName = Console.ReadLine();
            }
            if (gameName == "Game Time")
            {
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", moneySpent, money - moneySpent);
            }
        }
    }
}
