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
            //Act
            //Assert
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
