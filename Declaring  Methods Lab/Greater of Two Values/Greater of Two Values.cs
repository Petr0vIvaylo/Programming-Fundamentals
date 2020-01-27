using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int inputOne = int.Parse(Console.ReadLine());
                int inputTwo = int.Parse(Console.ReadLine());
                Console.WriteLine(getMaxInt(inputOne,inputTwo));
            }
            else if (type == "char")
            {
                char inputOne = char.Parse(Console.ReadLine());
                char inputTwo = char.Parse(Console.ReadLine());
                Console.WriteLine(getMaxChar(inputOne, inputTwo));
            }
            else
            {
                string inputOne = (Console.ReadLine());
                string inputTwo = (Console.ReadLine());
                if (inputOne.CompareTo(inputTwo)==1)
                {
                    Console.WriteLine(inputOne);
                }
                else
                {
                    Console.WriteLine(inputTwo);
                }
            }
        }
        static int getMaxInt(int inputOne,int inputTwo)
        {
            return Math.Max(inputOne, inputTwo);
        }
        static char getMaxChar(char inputOne,char inputTwo)
        {

            if (inputOne > inputTwo)
            {
                return inputOne;
            }
            else
            {
                return inputTwo;
            }
        }
        static int getMaxString (string inputOne,string inputTwo)
        {
            return inputOne.CompareTo(inputTwo);
        }
    }
}
