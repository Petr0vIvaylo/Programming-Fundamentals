using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumbers = int.Parse(Console.ReadLine());
            int secondNumbers = int.Parse(Console.ReadLine());
            int thurdNumbers = int.Parse(Console.ReadLine());
            int fourthNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}",
                firstNumbers,secondNumbers,thurdNumbers,fourthNumbers);

        }
    }
}
