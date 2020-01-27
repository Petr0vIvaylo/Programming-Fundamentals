using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();


            bool a = word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") ||
                word.EndsWith("sh")
                      || word.EndsWith("x") || word.EndsWith("z");


            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                Console.WriteLine(word + "ies");
            }
            else if (a)
            {
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }

        }
    }
}
