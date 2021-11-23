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
            int[] array = { 2, 7, 7, 7, 9, 8, 5};
            int[] result = LongestSubarraywithKdistinctelements.function(array, 4);
            Console.WriteLine(string.Join(",", result));
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
