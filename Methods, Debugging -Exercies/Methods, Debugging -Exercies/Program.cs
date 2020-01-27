using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods__Debugging__Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(greetings(name) +"{0}!",name);
        }
        static string greetings(string greeting)
        {
            return  "Hello, "; 
        }
    }
}
