using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeAndLadderGame
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0, dieCount = 0;
        public void Game()
        {
            Console.WriteLine("Game has started.....");

            

            while (position < 100)
            {
                Console.WriteLine("Player position is : {0} ", position);
                Random random = new Random();
                int diePosition = random.Next(1, 7);
                dieCount++;
                Console.WriteLine("After rolling the die,the number is : {0}", diePosition);
                Console.WriteLine("Position of Player is : {0}", position);
                int option = random.Next(0, 3);

                switch (option)
                {
                    case NO_PLAY:
                        position += 0;
                        Console.WriteLine("Player stays in the same position");
                        break;
                    case SNAKE:
                        position -= diePosition;
                        Console.WriteLine("Player got a snake : {0} ", position);
                        if (position < 0)
                        {
                            position = 0;
                        }
                        break;
                    case LADDER:
                        int roll = diePosition;
                        position += roll;
                        if(position > 100)
                        {
                            position -= roll;
                        }
                        Console.WriteLine("Player got a ladder : {0} ", position);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            Console.WriteLine($"number of times die rolled is {dieCount}");
        }
    }
}
