using System;
using Xunit;
using RomanNumerals;

namespace RomanNumerals.Tests
{
    public class RomanNumeralsTests
    {
        [Fact]
        public void NumeralValidation()
        {
            //Arrange
            var romanNumerals = new RomanNumeralsCalculator();
            string inputOne = "MMXVI";
            string inputTwo = "CHXVI";
            bool expectedResultOne = true;
            bool expectedResultTwo = false;

            //Act
            var resultOne = romanNumerals.NumeralValidation(inputOne);
            var resultTwo = romanNumerals.NumeralValidation(inputTwo);

            //Assert
            Assert.Equal(expectedResultOne, resultOne);
            Assert.Equal(expectedResultTwo, resultTwo);
        }

        [Fact]
        public void NumeralCalculation()
        {
            //Arrange
            var romanNumerals = new RomanNumeralsCalculator();
            string easyInput = "IV";
            string mediumInput = "CCVII";
            string hardInput = "MDCCLXXVI";
            int expectedValueEasy = 4; //IV
            int expectedValueMedium = 207; //CCVII
            int expectedValueHard = 1776; //MDCCLXXVI

            //Act
            var resultEasy = romanNumerals.NumeralsToInteger(easyInput);
            var resultMedium = romanNumerals.NumeralsToInteger(mediumInput);
            var resultHard = romanNumerals.NumeralsToInteger(hardInput);

            //Assert
            Assert.Equal(expectedValueEasy, resultEasy);
            Assert.Equal(expectedValueMedium, resultMedium);
            Assert.Equal(expectedValueHard, resultHard);
        }
    }
}
