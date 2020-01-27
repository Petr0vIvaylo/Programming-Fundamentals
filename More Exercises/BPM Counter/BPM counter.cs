using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars =Math.Round (numberOfBeats / 4,1);
            double seconds = numberOfBeats * 60.0 / bpm;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;
            Console.Write("{0} bars - ", bars);
            Console.WriteLine($"{minutes}m {Math.Floor(seconds)}s");
            
        }
    }
}
