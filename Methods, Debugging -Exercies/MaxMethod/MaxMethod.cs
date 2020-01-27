using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNum= int.Parse( Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thurdNum = int.Parse(Console.ReadLine());

            if (GetMax(firstNum, secondNum, thurdNum) < thurdNum)
            {
                Console.WriteLine(thurdNum);
            }
            else
            {
                Console.WriteLine(GetMax(firstNum, secondNum, thurdNum));
            }
           
        }
        static int GetMax(int a,int b,int c)
        {
            return Math.Max(a, b);
            
        }
    }
}
