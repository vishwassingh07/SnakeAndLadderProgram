using System;
namespace SnakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Snake And Ladder Program");
            SnakeAndLadderGame gameplay = new SnakeAndLadderGame();
            gameplay.Game();
            Console.WriteLine();
        }
    }
}