using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Odd" && inputLine != "Even")
            {
                string[] inputParameters = inputLine.Split(' ').ToArray();
                string command = inputParameters[0];
                if (command == "Delete")
                {
                    int numberToDelete = int.Parse(inputParameters[1]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == numberToDelete)
                        {
                            input.RemoveAt(i);
                            i--;
                        }
                       
                    }
                }
                if (command == "Insert")
                {
                    int element = int.Parse(inputParameters[1]);
                    int index = int.Parse(inputParameters[2]);
                    input.Insert(index,element);
                }
                inputLine = Console.ReadLine();
            }
            if (inputLine == "Odd")
            {
                input = input.Where(x => x % 2 != 0).ToList();
                Console.WriteLine(string.Join(" ", input));
            }
            else if (inputLine == "Even")
            {
                input = input.Where(x => x % 2 == 0).ToList();
                Console.WriteLine(string.Join(" ", input));
            }

        }
    }
}
