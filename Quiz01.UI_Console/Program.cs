using Quiz01.Services;
using Quiz01.Services.Q1;
using Quiz01.Services.Q2;
using System;
using System.Collections.Generic;

namespace Quiz01.UI_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            IMyFactory factory = new MyFactory();

            // Question1 
            var ratio = factory.CreatePopulationService().RatioPerformanceCheck(1000, 50);

            Console.WriteLine($"*******************************");

            Console.WriteLine($"QUESTION 1 (Population):  ");
            Console.WriteLine($"Ratio of 2s to 1s for 1000 collection with index of 50 ");
            Console.WriteLine($"Ratio is : {ratio}");
            Console.WriteLine($"");
            Console.WriteLine($"*******************************");
            Console.WriteLine($"");


            // Question2 

            var diceGame = factory.CreateDiceGameService();
            Console.WriteLine($"QUESTION 2 (Dice Game):");
            Console.WriteLine($"When I calculate the average payout per each TRY of games, I assumed that customer has to pay each time that roll te dice.");
            Console.WriteLine($"Average payout has calculated in 2 different ways.");
            Console.WriteLine($"");

            Console.WriteLine($"GetCalculatedAveragePayoutMathematically: this method is using the laws of 'Probability and Statistics for Computer Scientists' which I studied in university in late 90's .");
            Console.WriteLine($"I strongly RECOMMENDED this method because it doesn't rely on chance and can't be corrupted by bad data.");
            var averagePayout1 = diceGame.GetCalculatedAveragePayoutMathematically(6, new List<int>() { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine($"Average Payout (Mathematically) is : {averagePayout1}");
            Console.WriteLine($"");

            Console.WriteLine($"*******************************");

            Console.WriteLine($"");
            Console.WriteLine($"GetAveragePayoutStatistically: this method is using an internal engine to generate some random statiscal data then based on that will calculates the average payout.");
            Console.WriteLine($"The main advantage of this method is that if the game is FIXED and you have real data , still you can find the relatively close answer");
            var averagePayout2 = diceGame.GetAveragePayoutStatistically(players: 1000, minGames: 1, maxGames: 6);
            Console.WriteLine($"Average Payout (Statistically) is : {averagePayout2:0.000}");
            Console.WriteLine($"*******************************");



        }
    }
}
