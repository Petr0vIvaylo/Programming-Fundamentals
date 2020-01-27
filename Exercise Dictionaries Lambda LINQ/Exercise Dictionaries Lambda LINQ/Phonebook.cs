using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Dictionaries_Lambda_LINQ
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {

                    phonebook[input[1]] = input[2];

                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine(string.Join (" -> ", input[1], phonebook[input[1]]));
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",input[1]);
                    }
                }
                input = Console.ReadLine().Split();
            }
            
        }
    }
}
