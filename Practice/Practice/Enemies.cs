using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Enemies
    {
        public static void main(string[] args)
        {

            int count = 0;

            Console.Write("How many seats: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int n = (int)Math.Pow(input, 2);

            for (int i = 0; i < n - 1; i++)
            {
                String binary = Convert.ToString(i, 2);

                if (!binary.Contains("11"))
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
