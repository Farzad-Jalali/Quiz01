using Quiz01.Services.Q1;
using Quiz01.Services.Q2;
using System;
using System.Linq;
using Xunit;

namespace Quiz01.XUnitTest.Q2
{
    public class Test_GameStatisticGenerator
    {
        private readonly GameStatisticGenerator statisticGenerator = new GameStatisticGenerator(new CustomerPlaysCounter(), new DiceRoller());

        [Fact]
        public void Test_GameStatisticGenerator_10Player_only_1Game()
        {
            var oldGames = statisticGenerator.GeneratePlayStatisticForPayouts(10, 1, 6, 1);

            Assert.InRange<int>(oldGames.Count, 10 * 1, 10 * 6);
        }


        [Theory]
        [InlineData(1, 1, 1, 1)]
        [InlineData(4, 3, 3, 1)]
        [InlineData(20, 2, 2, 1)]
        [InlineData(10, 5, 5, 1)]
        public void Test_GameStatisticGenerator_multiPlayer_same_min(int player, int min, int max, decimal gamecost)
        {
            var oldGames = statisticGenerator.GeneratePlayStatisticForPayouts(player, min, max, gamecost);

            Assert.InRange<int>(oldGames.Count, player * min, player * max);
        }
    }
}

