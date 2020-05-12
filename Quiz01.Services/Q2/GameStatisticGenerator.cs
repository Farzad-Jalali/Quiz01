using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.Services.Q2
{
    public class GameStatisticGenerator : IGameStatisticGenerator
    {
        private readonly ICustomerPlaysCounter customerPlaysCounter;
        private readonly IDiceRoller diceRoller;

        public GameStatisticGenerator(ICustomerPlaysCounter customerPlaysCounter, IDiceRoller diceRoller)
        {
            this.diceRoller = diceRoller;
            this.customerPlaysCounter = customerPlaysCounter;
        }

        /// <summary>
        /// this method calculates the total payout for a number of times that player like to play.
        /// </summary>
        /// <param name="players">number of players</param>
        /// <param name="minGames">minimum number of games</param>
        /// <param name="maxGames">maximum number of games</param>
        /// <returns></returns>
        public IList<decimal> GeneratePlayStatisticForPayouts(int players, int minGames, int maxGames,decimal gameCost)
        {
            var payoutList = new List<decimal>();


            while (players-- > 0)
            {
                var games = customerPlaysCounter.GetPlaysCountRandomly(minGames: minGames, maxGames: maxGames);

                while (games-- > 0)
                {
                    var payout = diceRoller.RollTheDice() * gameCost;
                    payoutList.Add(payout);
                }
            }

            return payoutList;
        }

    }
}
