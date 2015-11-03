using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Pacer
    {
        public static void main(string[] args)
        {
            Console.Write("Interval distance in meters: ");
            int meters = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target mile pace: ");
            String pace = Console.ReadLine();

            int mins = Convert.ToInt32(pace.Substring(0, pace.IndexOf(":")));
            int secs = Convert.ToInt32(pace.Substring(pace.IndexOf(":") + 1));

            int div = 1609 / meters;
            secs = secs + (mins * 60);

            secs /= div;

            String output = secs / 60 + ":" + secs % 60;

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}