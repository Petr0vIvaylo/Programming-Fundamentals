using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && IsDivisibleBySeven(i) && HoldsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int i)
        {
            bool isPalindrome = false;
            int reversed = 0;
            int oldNumber = i;
            int loops = i.ToString().Length;
            int power = i.ToString().Length - 1;
            for (int j = 0; j < loops; j++)
            {
                reversed += (i % 10) * (int)Math.Pow(10, power);
                power--;
                i /= 10;
            }
            if (reversed == oldNumber)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            return isPalindrome;
        }

        static bool IsDivisibleBySeven(int i)
        {
            bool isDivisibleBySeven = false;
            int sum = 0;
            while (i != 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                isDivisibleBySeven = true;
            }
            return isDivisibleBySeven;

        }

        static bool HoldsEvenDigit(int i)
        {
            bool holdsEvenDigit = false;
            while (i != 0)
            {
                int currentLastDigit = i % 10;
                if (currentLastDigit % 2 == 0)
                {
                    holdsEvenDigit = true;
                    return holdsEvenDigit;
                }
                i /= 10;
            }
            return holdsEvenDigit;
        }
    }
}
