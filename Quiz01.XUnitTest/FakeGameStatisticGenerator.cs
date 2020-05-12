using Quiz01.Services.Q2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.XUnitTest
{
    public class FakeGameStatisticGenerator : IGameStatisticGenerator
    {
        public IList<decimal> GeneratePlayStatisticForPayouts(int players, int minGames, int maxGames, decimal gameCost)
        {
            return new List<decimal>() {  2, 2, 4, 4, 6, 6 };
        }
    }
}
