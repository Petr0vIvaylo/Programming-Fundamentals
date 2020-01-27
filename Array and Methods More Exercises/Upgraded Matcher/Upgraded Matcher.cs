using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split().ToArray();
            decimal[] quantitieAvalable = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            decimal[] productPrice = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string[] product = Console.ReadLine().Split().ToArray();

            while ((product[0]) != "done")
            {  
                for (int i = 0; i < productNames.Length; i++)
                {
                   decimal quantitie = decimal.Parse(product[1]);
                    if (product[0] == productNames[i])
                    {
                        try
                        {
                            if (quantitie <= quantitieAvalable[i])
                            {
                                Console.WriteLine("{0} x {1} costs {2:f2}",
                                productNames[i], quantitie, productPrice[i] * quantitie);
                                quantitieAvalable[i] -= quantitie;
                            }
                            else //if (quantitieAvalable[i]==0)
                            {
                                Console.WriteLine("We do not have enough {0}", product[0]);
                            }
                        }
                        catch (Exception)
                        {
                           Console.WriteLine("We do not have enough {0}", product[0]); 
                        }
                    }
                }
                product = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
