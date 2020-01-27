using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Methods_More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            
            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                if (command == "END")
                {
                    break;
                }
                switch (command)
                {
                    case "Distinct": input = input.Distinct().ToArray();break;

                    case "Reverse":Array.Reverse(input);break;


                    case "Replace":
                       
                        int index = int.Parse(tokens[1]);
                        string element = tokens[2];
                        if (index >= input.Length || index < 0)
                        {
                            Console.WriteLine("Invalid input!");

                        }
                        else
                        {
                        input[index] = element;
                        }
                        break;


                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                } 
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}

