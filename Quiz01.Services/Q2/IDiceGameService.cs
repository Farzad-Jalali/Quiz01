using System.Collections.Generic;

namespace Quiz01.Services.Q2
{
    public interface IDiceGameService
    {
        decimal GetCalculatedAveragePayoutMathematically(int numberOfposibilities, IList<int> payoutOfEachPosibility);

        decimal GetAveragePayoutStatistically(int players, int minGames, int maxGames);
    }
}