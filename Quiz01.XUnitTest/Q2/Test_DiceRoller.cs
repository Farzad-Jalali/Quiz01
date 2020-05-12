using Quiz01.Services.Q1;
using Quiz01.Services.Q2;
using System;
using System.Linq;
using Xunit;

namespace Quiz01.XUnitTest.Q2
{
    public class Test_DiceRoller
    {
        private readonly IDiceRoller diceRoller = new DiceRoller();

        [Fact]
        public void Test_GameStatisticGenerator_10Player_only_1Game()
        {
            int count = 10;
            while(count-->0)
            {
                int faceUpValue = diceRoller.RollTheDice();
                Assert.InRange<int>(faceUpValue, 1,6);

            }
            
        }

 
    }
}

