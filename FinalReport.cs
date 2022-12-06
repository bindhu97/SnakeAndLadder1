using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder1
{
    internal class FinalReport
    {
        public void Report() 
        {
            int positionplayer1 = 0;
            int positionplayer2 = 0;
            int counterP1 = 0;
            int counterP2 = 0;
           int  WINNING_POSITION = 100;

            while (positionplayer1 <= WINNING_POSITION && positionplayer2 <= WINNING_POSITION)
            {
                Random rand = new Random();
                int diceValue1 = (int)(rand.NextInt64(6) + 1);
                Console.WriteLine("PLAYER1 --> ");
                Console.WriteLine("Dice Value is ==> " + diceValue1);
                int option = (int)rand.NextInt64(3);

                counterP1++;
                if (positionplayer1 == WINNING_POSITION)
                {
                    Console.WriteLine("<==============>Player 1 Won The Game<===============>");
                    break;
                }
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        positionplayer1 += diceValue1;
                        Console.WriteLine("Current Position is ==>" + positionplayer1);

                        if (positionplayer1 > 100)
                        {
                            positionplayer1 = positionplayer1 - diceValue1;
                            Console.WriteLine("Current Position is ==>" + positionplayer1);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        positionplayer1 -= diceValue1;
                        Console.WriteLine("Current Position is ==>" + positionplayer1);

                        if (positionplayer1 < 0)
                        {
                            positionplayer1 = 0;
                            Console.WriteLine("Current Position is ==>" + positionplayer1);
                        }
                        break;
                    default:
                        Console.WriteLine("Not Correct");
                        break;
                }
                Console.WriteLine("Dice Roll Count for Player1 ===>" + counterP1);
                Console.WriteLine("-----------------------------------------------------");

                int diceValue2 = (int)(rand.NextInt64(6) + 1);
                Console.WriteLine("PLAYER2 --> ");
                Console.WriteLine("Dice Value is ==> " + diceValue2);
                int option2 = (int)rand.NextInt64(3);
                counterP2++;
                if (positionplayer2 == WINNING_POSITION)
                {
                    Console.WriteLine("<==============>Player 2 Won The Game<===============>");
                    break;
                }
                switch (option2)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        positionplayer2 += diceValue2;
                        Console.WriteLine("Current Position is ==>" + positionplayer2);

                        if (positionplayer2 > 100)
                        {
                            positionplayer2 = positionplayer2 - diceValue2;
                            Console.WriteLine("Current Position is ==>" + positionplayer2);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        positionplayer2 -= diceValue2;
                        Console.WriteLine("Current Position is ==>" + positionplayer2);

                        if (positionplayer2 < 0)
                        {
                            positionplayer2 = 0;
                            Console.WriteLine("Current Position is ==>" + positionplayer2);
                        }
                        break;
                    default:
                        Console.WriteLine("Not Correct");
                        break;
                }
                Console.WriteLine("Dice Roll Count for Player2 ===>" + counterP2);
                Console.WriteLine("-------------------------------------------------");
            }
            if (positionplayer1 == WINNING_POSITION)
                Console.WriteLine("***Player 1 Won The Game***");
        else
                Console.WriteLine("***Player 2 Won The Game***");
        }
    }
}
