using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_shift
{
    class test
    {
        static void Main(string[] args)
        {
            List<int> test = Enumerable.Range(0, 10).ToList();
            test = test.ShiftLeft(1);

            PrintList(test);
            Console.WriteLine("");

            PrintList(test.ShiftLeft(2));

            Console.ReadLine();
        }

        private static void PrintList(List<int> test)
        {
            for (int i = 0; i < test.Count; i++)
            {
                Console.Write(test[i]+" ");
            }
            Console.WriteLine();
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

        public static List<T> ShiftRight<T>(this List<T> list, int shiftBy)
        {
            if (list.Count <= shiftBy)
            {
                return list;
            }

            var result = list.GetRange(list.Count - shiftBy, shiftBy);
            result.AddRange(list.GetRange(0, list.Count - shiftBy));
            return result;
        }
    }
}
