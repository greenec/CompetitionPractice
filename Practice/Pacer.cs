using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Pacer
    {
        public static void Main(string[] args)
        {
            Console.Write("Interval distance in meters: ");
            int meters = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target mile pace: ");
            String pace = Console.ReadLine();

            int mins = pace.Substring(0, pace.IndexOf(":"));

            Console.WriteLine(mins);
        }
    }
}
