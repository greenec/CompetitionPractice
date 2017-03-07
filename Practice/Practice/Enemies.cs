using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int count = 1;

                Console.Write("How many seats: ");
                int seats = Convert.ToInt32(Console.ReadLine());
                int end = (int) Math.Pow(2, seats - 1);

                for (int i = 0; i < end; i++)
                {
                    String binary = Convert.ToString(i, 2);

                    if (!binary.Contains("00"))
                    {
                        count++;
                    }
                }
                Console.WriteLine("Number of arrangements: " + count);
            }
        }
    }
}
