using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplyer = int.Parse(Console.ReadLine());
            int result = 0;
            do
            {
                
                    result = n * multiplyer;
                    Console.WriteLine("{0} X {1} = {2}", n, multiplyer, result);
                multiplyer++;
                
            } while (multiplyer <=10);
            

        }
    }
}
