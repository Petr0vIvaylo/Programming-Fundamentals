using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string resourse = Console.ReadLine();

            while (resourse != "stop")
            {
                
                int quantity = int.Parse(Console.ReadLine());
                
                if (!result.ContainsKey(resourse))
                {
                    result[resourse] = 0;
                }
                result[resourse] += quantity;
                
                resourse = Console.ReadLine();
               
            }
            foreach (KeyValuePair <string, int> kvp in result)
            {
                Console.WriteLine(string.Join(" -> ",kvp.Key,kvp.Value));
            }

        }
    }
}
