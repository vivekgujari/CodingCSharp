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
            SnakeAndLadder game = new SnakeAndLadder();
            game.MinDiceThrownToWin();
            Console.WriteLine($"Minimum dice thrown to win game is {game.min}");
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
