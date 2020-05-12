using Quiz01.Services.Q1;
using Quiz01.Services.Q2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.Services
{
    public interface IMyFactory
    {
        PopulationService CreatePopulationService();

        DiceGameService CreateDiceGameService();
    }


    public class MyFactory : IMyFactory
    {
        public PopulationService CreatePopulationService()
        {
            var q1 = new PopulationService(new RatioCalculator(), new CollectionGenerator(new NumberGenerator(1, 2)));
            return q1;
        }

        public DiceGameService CreateDiceGameService()
        {
            var q2 = new DiceGameService(1, new GameStatisticGenerator(new CustomerPlaysCounter(), new DiceRoller()));
            return q2;
        }
    }
}
