using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder1
{
    internal class ChecksForOption
    {
        public void checkoption()
        {
            int position = 0;
            Random rand = new Random();
            int diceValue = (int)(rand.NextInt64(6) + 1);
            Console.WriteLine("Dice Value is " + diceValue);


            int option = (int)rand.NextInt64(3);
            if (option == 0)
            {
                Console.WriteLine("No Play");
            }
            else if (option == 1)
            {
                Console.WriteLine("Ladder");
                position += diceValue;
                Console.WriteLine("Current Position is " + position);
            }
            else
            {
                Console.WriteLine("Snake");
                position -= diceValue;
                Console.WriteLine("Current Position is " + position);
            }
        }
    }
}
