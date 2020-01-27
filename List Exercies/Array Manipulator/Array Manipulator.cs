using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string inputCommand = Console.ReadLine();

            while (true)
            {
                var command =inputCommand.Split(' ').ToList();

                if (command[0] == "add")
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    numbers.Insert(index, element);
                }
                else if (command[0] == "addMany")
                {
                    int index = int.Parse(command[1]); 
                    command.RemoveRange(0, 2);
                    var elements = new List<int>(command.Count);
                    for (int i = 0; i < command.Count; i++)
                    {
                       elements.Add( int.Parse(command[i]));
                    }
                    numbers.InsertRange(index, elements);
                }
                else if (command[0] == "contains")
                {
                    int index = int.Parse(command[1]);
                    if (numbers.Contains(index) == true)
                    {
                        Console.WriteLine(numbers.IndexOf(index));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (command[0] == "remove")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "shift")
                {
                    int index = int.Parse(command[1]);
                    numbers = numbers.ShiftLeft(index); 
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count-1; i+=2)
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        i--;
                    }
                    
                }
                else if (command[0] == "print")
                {
                    Console.WriteLine("["+string.Join(", ",numbers)+"]");
                    break;
                }
                inputCommand = Console.ReadLine();
            }
        }



        
    }
}
public static class ShiftList
{
    public static List<T> ShiftLeft<T>(this List<T> list, int shiftBy)
    {
        if (list.Count <= shiftBy)
        {
            return list;
        }

        var result = list.GetRange(shiftBy, list.Count - shiftBy);
        result.AddRange(list.GetRange(0, shiftBy));
        return result;
    }
}

