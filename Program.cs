using System;
using System.Collections.Generic;
namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "gfg";
            DistinctSubsequences distinct = new DistinctSubsequences();
            List<string> result = distinct.function(s);
            Console.WriteLine(result.ToString());
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
