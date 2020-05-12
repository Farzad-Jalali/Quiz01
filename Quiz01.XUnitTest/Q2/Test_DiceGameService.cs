using Quiz01.Services;
using Quiz01.Services.Q1;
using Quiz01.Services.Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Quiz01.XUnitTest.Q2
{
    public class Test_DiceGameService
    {
        private readonly DiceGameService realService = (new MyFactory()).CreateDiceGameService();

        //mock the static generator
        private readonly DiceGameService fakeService = new DiceGameService(1, new FakeGameStatisticGenerator());



        [Fact]
        public void Test_GetCalculatedAveragePayoutMathematically_Dice_6faces()
        {
            var average = realService.GetCalculatedAveragePayoutMathematically(6, new List<int>() { 1, 2, 3, 4, 5, 6 });

            Assert.Equal(3.5m, average);
        }

        [Fact]
        public void Test_GetCalculatedAveragePayoutMathematically_Coin_2faces()
        {
            var average = realService.GetCalculatedAveragePayoutMathematically(2, new List<int>() { 1, 2 });

            Assert.Equal(1.5m, average);
        }


        [Fact]
        public void Test_GetCalculatedAveragePayoutMathematically_Dice_4faces()
        {
            var average = realService.GetCalculatedAveragePayoutMathematically(4, new List<int>() { 1, 2, 3, 4 });

            Assert.Equal(2.5m, average);
        }


        [Fact]
        public void Test_GameStatisticGenerator_FakeGameStatisticGenerator()
        {
           var average = fakeService.GetAveragePayoutStatistically(10, 1, 6);
            Assert.Equal(4m, average);
        }
    }
}

