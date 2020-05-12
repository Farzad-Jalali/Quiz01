using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz01.Services.Q2
{

    public class DiceGameService : IDiceGameService
    {
        private readonly decimal gameCost;
        private readonly IGameStatisticGenerator gameStatisticGenerator;

        public DiceGameService(decimal gameCost, IGameStatisticGenerator gameStatisticGenerator)
        {
            this.gameCost = gameCost;
            this.gameStatisticGenerator = gameStatisticGenerator;
        }

        /// <summary>
        /// calculates the average of the payout per each TRY of game, by using some statical data. 
        /// </summary>
        /// <param name="payouts"></param>
        /// <returns></returns>
        public decimal GetAveragePayoutStatistically(int players, int minGames, int maxGames)
        {
            var payoutStatistics = gameStatisticGenerator.GeneratePlayStatisticForPayouts(players: players, minGames: minGames, maxGames: maxGames, gameCost: this.gameCost);

            return payoutStatistics.Sum(x => x) * gameCost / payoutStatistics.Count;
        }

        /// <summary>
        /// It is my RECOMMANDED way of calculating the average payout per each TRY of game
        /// </summary>
        /// <param name="numberOfposibilities">number Of posibilities , in tis cse number of dice's faces</param>
        /// <param name="payoutOfEachPosibility">payout Of Each Posibility, in this case list of numbers tat can be face up on a dice.</param>
        /// <returns></returns>
        public decimal GetCalculatedAveragePayoutMathematically(int numberOfposibilities, IList<int> payoutOfEachPosibility)
        {
            return payoutOfEachPosibility.Sum() * gameCost / numberOfposibilities;
        }
    }
}
