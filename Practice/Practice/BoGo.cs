using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class BoGo
    {
        static void main(string[] args)
        {
            String input = Console.ReadLine();

            int total = 0;
            int sCount = 0;
            int mCount = 0;
            int lCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                String current = input.Substring(i, 1);

                if (current == "S")
                {
                    total += 2;
                    sCount++;
                }
                if (current == "M")
                {
                    total += 3;
                    mCount++;
                }
                if (current == "L")
                {
                    total += 5;
                    lCount++;
                }
            }

            if (sCount % 2 == 0)
            {
                total -= 2 * (sCount / 2);
            }
            if (mCount % 2 == 0)
            {
                total -= 3 * (mCount / 2);
            }
            if (lCount % 2 == 0)
            {
                total -= 5 * (lCount / 2);
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
