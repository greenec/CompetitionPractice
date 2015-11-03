using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice
{
    class Point
    {
        public Vector v;
        public int count;
        public int gcf;

        public Point (int x, int y)
        {
            count = 1;

            gcf = getGCF(x, y);

            v.X = x / gcf;
            v.Y = y / gcf;
        }

        public int getGCF(int x, int y)
        {
            int max = (int)Math.Max(x, y);

            for (int i = max; i >= 1; i--)
            {
                if (x % i == 0 && y % i == 0)
                    return i;
            }

            return 1;
        }
    }

    class Sight
    {
        public static void main(string[] args)
        {
            List<Point> points = new List<Point>();
            List<Point> output = new List<Point>();

            Console.Write("Enter a positive integer: ");
            int gridSize = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= gridSize; i++)
            {
                for (int k = 0; k <= gridSize; k++)
                {
                    Point pt = new Point(i, k);

                    bool found = false;
                    for (int p = 0; p < points.Count; p++)
                    {
                        if (pt.v == points[p].v)
                            found = true;
                    }

                    if (!found)
                        points.Add(pt);
                }
            }

            Console.WriteLine(points.Count - 1);
            Console.ReadLine();
        }
    }
}