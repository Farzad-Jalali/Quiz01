using Quiz01.Services.Q1;
using System;
using System.Linq;
using Xunit;

namespace Quiz01.XUnitTest.Q1
{
    public class Test_GameStatisticGenerator
    {
        private readonly CollectionGenerator FakecollectionGenerator = new CollectionGenerator(new FakeNumber1Generator());
        
        private readonly CollectionGenerator collectionGenerator1 = new CollectionGenerator(new NumberGenerator(1,2));
        
        [Fact]
        public void Test_CollectionGenerator_Mock_INumberGenerator_Always_Full_Index10()
        {

            var output1 = FakecollectionGenerator.NextCollection(10);

            Assert.NotNull(output1);
            // becausewe only get 1 , so the collection has to be fully filled
            Assert.True(output1.Count == 10);
        }

        [Fact]
        public void Test_CollectionGenerator_Mock_INumberGenerator_Always_Full_Index20()
        {

            var output1 = FakecollectionGenerator.NextCollection(20);

            Assert.NotNull(output1);
            // becausewe only get 1 , so the collection has to be fully filled
            Assert.True(output1.Count == 20);
        }

        [Fact]
        public void Test_CollectionGenerator_Correct_Lenght_10()
        {
            
            var output1 = collectionGenerator1.NextCollection(10);

            Assert.NotNull(output1);
            Assert.True(output1.Count <= 10);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(35)]
        public void Test_CollectionGenerator_Correct_Lenght_Multi(int index)
        {
             var output1 = collectionGenerator1.NextCollection(index);

            Assert.NotNull(output1);
            Assert.True(output1.Count <= index);
        }


        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(35)]
        public void Test_CollectionGenerator_2s_Count(int index)
        {
            
            var output1 = collectionGenerator1.NextCollection(index);

            int twosCount = output1.Where(x => x == 2).Count();

            Assert.InRange<int>(twosCount, 0, 1);
        }



        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void Test_CollectionGenerator_2s_Position(int index)
        {
            
            var output1 = collectionGenerator1.NextCollection(index);


            if (output1.Count == index)
            {
                //when have full collection , so they must be all 1 except te last digit can be 2 or 1
                var sum = output1.Sum(x => x);
                Assert.InRange<int>(sum, index, index + 1);
            }
            else if (output1.Count < index && output1.Count > 0)
            {
                // when te collection is not full 
                //then the sum is equal lenght , or only bigger by 1 because the last digit must be 2
                var sum = output1.Sum(x => x);
                Assert.Equal(sum, output1.Count + 1);

                //when the collection is not full ten the last digit has to be 2
                Assert.Equal(2, output1.ToArray()[output1.Count - 1]);

            }
            else
            {
                //this code should be excuted
                //so if we get here means someting is wrong
                Assert.True(false);
            }

        }


    }
}
