using Microsoft.VisualBasic;
using Quiz01.Services.Q1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xunit;

namespace Quiz01.XUnitTest.Q1
{

    public class Test_RatioCalculator
    {

        [Theory]
        [InlineData(1, new int[] { 1, 1, 2 }, new int[] { 2 })]
        [InlineData(2, new int[] { 1, 1, 2 }, new int[] { 1, 2 }, new int[] { 2 }, new int[] { 1, 1, 2 }, new int[] { 1, 1, 1 })]
        [InlineData(0.5, new int[] { 2 }, new int[] { 2 }, new int[] { 1, 1 }, new int[] { 2 }, new int[] { 2 })]
        public void Test_ratio(decimal expectedRatio, params int[][] rawData)
        {
            var generator = new RatioCalculator();

            var records = rawData.Select(x => new Collection<int>(x) as ICollection<int>).ToList();

            var ratio = generator.GetRatio2sTo1s(records);

            Assert.Equal<decimal>(expectedRatio, ratio);
        }

    }
}
