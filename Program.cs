using System;
using System.Collections.Generic;
using Coding.DataStructures;
using DataStructures;
namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AB";
            string str2 = "CD";
            PrintInterLeavingOfStrings.function(str1, str2);
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
