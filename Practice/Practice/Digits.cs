using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder = 1;
            List<int> digits = new List<int>();
            List<int> remainders = new List<int>();

            Console.Write("Enter a positive integer: ");
            int input = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                remainder *= 10;

                if (remainder == 0)
                {
                    Console.Write("0.");
                    printList(digits);
                    Console.Read();
                    break;
                }

                if (remainders.Contains(remainder % input))
                {
                    Console.Write("0.[");
                    printList(digits);
                    Console.Write("]");
                    Console.Read();
                    break;
                }
                digits.Add(remainder / input);
                remainder = remainder % input;
                remainders.Add(remainder);
            }
        }
        static void printList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
        }
    }
}
