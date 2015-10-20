using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    class Pasta
    {
        static void main(string[] args)
        {
            String input = Console.ReadLine();

            String output = Regex.Replace(input, "(a|e|i|o|u)+([a-z])", "a$2");


            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
