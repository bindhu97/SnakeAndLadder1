// See https://aka.ms/new-console-template for more information
using SnakeAndLadder1;

Console.WriteLine("Welcome to Snake And Ladder Program");

Console.WriteLine("Calling Player Reaches Winning Position");
ReachesWinningPosition winningPosition = new ReachesWinningPosition();
winningPosition.Reaches();

Console.WriteLine("Calling ChecksForOption");
ChecksForOption checks = new ChecksForOption();
checks.checkoption();

Console.WriteLine("Calling RollstheDice");
RollstheDice rollstheDice = new RollstheDice();
rollstheDice.Dice();

Console.WriteLine("Calling Game Start Position");
StartPosition startPosition = new StartPosition();
startPosition.GameStart();


