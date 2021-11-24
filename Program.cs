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
            int[] array = { -2, -3, 4, -1, -2, 1, 5, -3};
            int[] result = LargestSumContiguous.function(array);
            Console.WriteLine(string.Join(",", result));
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
