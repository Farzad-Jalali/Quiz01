using System.Collections.Generic;

namespace Quiz01.Services.Q2
{
    public interface IGameStatisticGenerator
    {
        IList<decimal> GeneratePlayStatisticForPayouts(int players, int minGames, int maxGames, decimal gameCost);
    }
}