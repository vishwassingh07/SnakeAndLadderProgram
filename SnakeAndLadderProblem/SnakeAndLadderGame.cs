using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeAndLadderGame
    {
        int position = 0;
        public int dieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1,7);
            Console.WriteLine("After rolling the die,the number is : " + diePosition);
            return diePosition;
            
        }
    }
}
