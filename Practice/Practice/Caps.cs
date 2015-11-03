using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Caps
    {
        public static void main(string[] args)
        {
            String input = Console.ReadLine() + " ";
            String rev = "";
            String output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    rev += input[i];
                }

                else if (!Char.IsUpper(input[i]) && rev.Length > 0)
                {
                    for (int k = rev.Length; k > 0; k--)
                    {
                        output += rev[k - 1];
                    }
                    rev = "";
                    output += input[i];
                }

                else
                {
                    output += input[i];
                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}