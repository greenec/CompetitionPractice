﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice
{
    class Marbles
    {

        public static int getGCF(int x, int y)
        {
            int max = (int)Math.Max(x, y);

            for (int i = max; i >= 1; i--)
            {
                if (x % i == 0 && y % i == 0)
                    return i;
            }

            return 1;
        }

        public static void main(string[] args)
        {
            Console.Write("Numerator and denominator: ");
            //int numerator = Convert.ToInt32(input.Substring(0, input.IndexOf(" ")));
            //int denominator = Convert.ToInt32(input.Substring(input.IndexOf(" ")));
            int[] input = Console.ReadLine().Split(' ').ToList().Select(n2 => Convert.ToInt32(n2)).ToArray();
            int numerator = input[0], denominator = input[1];

            int gcf1 = getGCF(numerator, denominator);
            numerator /= gcf1;
            denominator /= gcf1;

            // Find some k, n such that
            //
            // k^2 - k
            // -------
            // n^2 - n
            //
            // can be reduced to numerator / denominator

            int n = 2;

            bool found = false;
            while (!found)
            {
                for (int k = 1; k < n; k++)
                {
                    int num = k * k - k;
                    int den = n * n - n;

                    int gcf = getGCF(num, den);
                    num /= gcf;
                    den /= gcf;

                    if (num == numerator && den == denominator)
                    {
                        Console.WriteLine(k + " black and " + (n - k) + " white");
                        found = true;
                        break;
                    }
                }
                n++;
            }

            //Console.WriteLine(black);
            //Console.WriteLine(white);

            Console.ReadLine();
        }
    }
}