using System;
using System.Collections.Generic;
using Coding.DataStructures;
using Coding.Sorting;
using DataStructures;
namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 7, 3, 6, 5, 1};
            MergeSort.Sort(array);
            Console.WriteLine(string.Join(",", array));
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
