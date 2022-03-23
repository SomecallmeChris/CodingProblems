using System;
using Xunit;

namespace LongestSubArray189.Tests
{
    public class LongestSubArrayTest
    {
        [Fact]
        public void DistinctSubsetLengthTest()
        {
            //Arrange
            DistinctSubset calc = new DistinctSubset();
            int[] set1 = { 5, 1, 3, 5, 2, 3, 4, 1 };
            int[] set2 = { 7, 7, 1, 2, 3, 4, 9, 6, 4, 4 };
            int[] set3 = { 6, 6, 3, 4, 6, 2, 2, 9, 8 };
            int expectedResult1 = 5;
            int expectedResult2 = 7;
            int expectedResult3 = 6;


            //Act
            int result1 = calc.DistinctSubsetLength(set1);
            int result2 = calc.DistinctSubsetLength(set2);
            int result3 = calc.DistinctSubsetLength(set3);

            //Assert
            Assert.Equal(expectedResult1, result1);
            Assert.Equal(expectedResult2, result2);
            Assert.Equal(expectedResult3, result3);

        }
    }
}
