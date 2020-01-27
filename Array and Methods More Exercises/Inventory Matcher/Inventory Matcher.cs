using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split().ToArray();
            long[] quantitie = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] productPrice = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string product = string.Empty;

            while ((product=Console.ReadLine()) !="done")
            {
                for (int i = 0; i < productNames.Length; i++)
                {
                    if (product == productNames[i])
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}",
                            productNames[i],productPrice[i],quantitie[i]);
                    }
                }
            }
        }
    }
}
