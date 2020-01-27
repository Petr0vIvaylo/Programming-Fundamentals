using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var contacts = Console.ReadLine().Split().ToList();

            var result = new StringBuilder();

            var name = Console.ReadLine();
            while (!name.Equals("done"))
            {
                var index = contacts.IndexOf(name);
                result.AppendLine($"{name} -> {numbers[index]}");
                name = Console.ReadLine();
            }

            Console.Write(result);

            //string[] phoneNUmbers = Console.ReadLine()
            //    .Split(' ')
            //    .ToArray();
            //string[] names = Console.ReadLine()
            //    .Split(' ')
            //    .ToArray();

            //int counter = 0;
            //string name = "";
            //string[] result = new string[names.Length];
            //while (name != "done")
            //{
            //    name = Console.ReadLine();
            //    if (name == "done")
            //    {
            //        break;
            //    }
            //    for (int i = 0; ; i++)
            //    {
            //        if (names[i]== name)
            //        {
            //            result[i] =names[i]+ "->" + phoneNUmbers[i];
            //            counter++;
            //            break;
            //        }

            //    }

            //}
            //for (int i = 0; i < counter; i++)
            //{

            //    Console.WriteLine(result[result.]);
            //}

        }
    }
}
