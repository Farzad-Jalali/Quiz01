using Quiz01.Services.Q1;
using System;
using Xunit;

namespace Quiz01.XUnitTest.Q1
{
    public class Test_NumberGenerator
    {
        [Theory]
        [InlineData(1, 2, 50)]
        [InlineData(10, 35, 50)]
        [InlineData(4, 7, 50)]
        [InlineData(77, 90, 50)]
        public void Test_NumberGenerator_Check_WithIn_Range(int min, int max, int times)
        {
            var numGenerator = new NumberGenerator(min: min, max: max);

            while (times-- > 0)
            {
                var randomNumber = numGenerator.NextNumber();
                Assert.InRange<int>(randomNumber, min, max);
            }
        }



        [Fact]
        public void Test_NumberGenerator_Check_Out_of_Range()
        {
            int min = 1;
            int max = 2;
            var numGenerator = new NumberGenerator(min: min, max: max);

            int redo = 1000;

           while(redo-- > 0)
            {
                int tempOutput = numGenerator.NextNumber();
                if (tempOutput > max) max = tempOutput;
                if (tempOutput < min) min = tempOutput;


            }

            Assert.Equal(1, min);
            Assert.Equal(2, max);
        }
    }
}
