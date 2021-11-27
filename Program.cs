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
            MinKnightSteps KnightGame = new MinKnightSteps();
            KnightGame.MinStepsByKnight(4, 3, 2, 5);
            Console.WriteLine($"Minimum steps to reach target is {KnightGame.min}");
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
