using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaring__Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            printHeader();
            printBody();
            printFooter();

        }
        static void printHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void printBody()
        {
            Console.WriteLine("Charged to____________________\n" +
                              "Received by___________________");
        }
        static void printFooter()
        {
            Console.WriteLine("------------------------------" +
                              "\n © SoftUni");
        }

    }
}
