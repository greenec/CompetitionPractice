using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void main(string[] args)
        {
            int remainder = 1;
            List<int> digits = new List<int>();
            List<int> remainders = new List<int>();

            remainders.Add(1);

            Console.Write("Enter a positive integer: ");
            int input = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                remainder *= 10;

                digits.Add(remainder / input);
                remainder = remainder % input;

                if (remainder == 0)
                {
                    Console.Write("0.");
                    for (int i = 0; i < digits.Count; i++)
                    {
                        Console.Write(digits[i]);
                    }
                    Console.Read();
                    break;
                }

                if (remainders.Contains(remainder))
                {
                    int index = remainders.IndexOf(remainder);
                    Console.Write("0.");
                    for (int i = 0; i < index; i++)
                    {
                        Console.Write(digits[i]);
                    }
                    Console.Write("[");
                    for (int i = index; i < digits.Count; i++)
                    {
                        Console.Write(digits[i]);
                    }
                    Console.Write("]");
                    Console.Read();
                    break;
                }
                remainders.Add(remainder);
            }
        }
    }
}
