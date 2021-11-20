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
            string input = "abc";
            PermutationOfString permute = new PermutationOfString();
            permute.function(input);
            //permute.list.ForEach(p => Console.WriteLine(p));
            Console.WriteLine(string.Join(" ", permute.list));
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
