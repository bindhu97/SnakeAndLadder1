using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder1
{
    internal class ExactWinningPosition
    {
        public void Exact()
        {
            int position = 0;
            int WINNINGPOSITION = 100;
            while (position <= WINNINGPOSITION)
            {
                Random rand = new Random();
                int diceValue = (int)(rand.NextInt64(6) + 1);
                Console.WriteLine("Dice Value is  " + diceValue);
                int option = (int)rand.NextInt64(3);
                if (position == WINNINGPOSITION)
                {
                    Console.WriteLine("You won the game");

                    break;
                }
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        position += diceValue;
                        Console.WriteLine("Current Position is " + position);

                        if (position > 100)
                        {
                            position = position - diceValue;
                            Console.WriteLine("Current Position is " + position);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        position -= diceValue;
                        Console.WriteLine("Current Position is " + position);

                        if (position < 0)
                        {
                            position = 0;
                            Console.WriteLine("Current Position is " + position);
                        }
                        break;
                    default:
                        Console.WriteLine("Not Correct");
                        break;
                }
            }
        }
    }
}
