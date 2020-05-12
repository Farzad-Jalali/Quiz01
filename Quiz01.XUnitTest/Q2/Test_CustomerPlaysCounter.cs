using Quiz01.Services.Q1;
using Quiz01.Services.Q2;
using System;
using System.Linq;
using Xunit;

namespace Quiz01.XUnitTest.Q2
{
    public class Test_CustomerPlaysCounter
    {
        private readonly CustomerPlaysCounter customerPlaysCounter = new CustomerPlaysCounter();

        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 14)]
        [InlineData(4, 7)]
        [InlineData(2, 14)]
        [InlineData(8, 24)]
        [InlineData(11, 31)]
        public void Test_GameStatisticGenerator_10Player_only_1Game(int min, int max)
        {
            int games = customerPlaysCounter.GetPlaysCountRandomly(min, max);

            Assert.InRange<int>(games, min, max);
        }



    }
}

