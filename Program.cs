// See https://aka.ms/new-console-template for more information
using SnakeAndLadder1;

Console.WriteLine("Welcome to Snake And Ladder Program");

Console.WriteLine("Calling Player Final Report");
FinalReport finalReport= new FinalReport();
finalReport.Report();

Console.WriteLine("Calling Player to win the Game");
WinTheGame theGame = new WinTheGame();
theGame.win();

Console.WriteLine("Calling Player Exact Winning Position");
ExactWinningPosition ExactWinning = new ExactWinningPosition();
ExactWinning.Exact();

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


