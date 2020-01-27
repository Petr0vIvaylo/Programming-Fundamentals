using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = {',', ';', ':', '.', '!','(', ')', '"', '\'', '\\', '/', '[', ']' ,' '};
            var words = Console.ReadLine()
                .Split(separators,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in words)
            {
                var upperCaseChars = 0;
                var lowerCaseChars = 0;
               
                foreach (var letter in word)
                {
                    if (char.IsUpper(letter))
                    {
                        upperCaseChars++;
                    }
                    else if (char.IsLower(letter))
                    {
                        lowerCaseChars++;
                    }
                    
                }
                if (upperCaseChars == word.Length)
                {
                    upperCase.Add(word);
                }
                else if (lowerCaseChars == word.Length)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
                
            }
            Console.WriteLine("Lower-case: "+string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
