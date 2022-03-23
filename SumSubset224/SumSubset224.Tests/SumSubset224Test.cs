using System;
using Xunit;

namespace SumSubset224.Tests
{
    public class SumSubset224Test
    {
        [Fact]
        public void SmallestSumNotInTest()
        {
            //Arrange
            SubSetCalculator calc = new SubSetCalculator();
            int[] inputArray1 = { 1, 2, 3, 10 };
            int[] inputArray2 = { 1, 2, 4, 5, 9, 12, 17 };
            int[] inputArray3 = { 1, 2, 3, 5, 8, 9, 14, 20 };
            int expectedResult1 = 7;
            int expectedResult2 = 51;
            int expectedResult3 = 63;

            //Act
            int result1 = calc.SmallestSumNotIn(inputArray1);
            int result2 = calc.SmallestSumNotIn(inputArray2);
            int result3 = calc.SmallestSumNotIn(inputArray3);

            //Assert
            Assert.Equal(result1, expectedResult1);
            Assert.Equal(result2, expectedResult2);
            Assert.Equal(result3, expectedResult3);
        }
    }
}
