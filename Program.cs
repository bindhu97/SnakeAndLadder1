﻿// See https://aka.ms/new-console-template for more information
using SnakeAndLadder1;

Console.WriteLine("Welcome to Snake And Ladder Program");

Console.WriteLine("Calling RollstheDice");
RollstheDice rollstheDice = new RollstheDice();
rollstheDice.Dice();

Console.WriteLine("Calling Game Start Position");
StartPosition startPosition = new StartPosition();
startPosition.GameStart();

