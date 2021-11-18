using System;
using System.Collections.Generic;
namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "aabbbccccd";
            string result = RepeatingCharContiguous.function(input);
            Console.WriteLine(result);
            Console.WriteLine("End of main program");
            Console.ReadKey();

            string[] a = { "geeze", "geeksforgeeks", "geeks"};
            Array.Sort(a);
            Console.WriteLine();
        }
    }
}
