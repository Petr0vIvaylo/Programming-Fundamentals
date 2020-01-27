using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string name = Console.ReadLine();

            while (name != "stop")
            {
                string eMail = Console.ReadLine();
                result[name] = eMail;
                name = Console.ReadLine();
            }

            var fixedMails = result.Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk"))).ToDictionary(kvp => kvp.Key , kvp =>kvp.Value);

            foreach (KeyValuePair<string,string> mail in fixedMails)
            {
                
                    Console.WriteLine(string.Join(" -> ",mail.Key,mail.Value));
                
            }
            
        }
    }
}
