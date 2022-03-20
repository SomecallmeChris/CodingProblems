using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    public class RomanNumeralsCalculator
    {
        static Dictionary<char, int> numeralValues = new Dictionary<char, int>()
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };
        static int getNumeric(char numeral)
        {
            var value = numeralValues.FirstOrDefault(x => x.Key == numeral).Value;
            return value;
        }

        public int NumeralsToInteger(string numerals)
        {
            int result = 0;
            int prev = numeralValues.FirstOrDefault(x => x.Key == numerals[0]).Value;

            for (int i = 0; i < numerals.Length; i++)
            {
                var value = numeralValues.FirstOrDefault(x => x.Key == numerals[i]).Value;
                if (numerals.Substring(i, numerals.Length - i).Length % 2 != 0)
                    if (numerals.Substring(i, numerals.Length - i).Length < 2)
                        result += value;
                    else
                        if (getNumeric(numerals[i + 1]) > getNumeric(numerals[i]))
                        result -= value;
                    else
                        result += value;

                else if (numerals.Substring(i, numerals.Length - i).Length % 2 == 0)
                    if (getNumeric(numerals[i + 1]) > getNumeric(numerals[i]))
                        result -= value;
                    else
                        result += value;
                prev = value;
            }
            return result;
        }

        public bool NumeralValidation(string toValidate)
        {
            List<char> numerals = new List<char>()
            {
                'M', 'D', 'C', 'L', 'X', 'V', 'I'
            };
            foreach (char numeral in toValidate)
            {
                if (!numerals.Contains(numeral))
                    return false;
            }
            return true;
        }
    }
}
