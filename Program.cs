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
            int[] array = { 4, 5, 2, 25, 1, 6, 18, 3};
            int[] result = NextGreaterElement.function(array);
            Console.WriteLine(string.Join(",", result));
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
