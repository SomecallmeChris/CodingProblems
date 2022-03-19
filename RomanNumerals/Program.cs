using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    class Program
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

        static int NumeralsToInteger(string numerals)
        {
            int result = 0;
            int prev  = numeralValues.FirstOrDefault(x => x.Key == numerals[0]).Value;

            foreach(char numeral in numerals)
            {
                var value  = numeralValues.FirstOrDefault(x => x.Key == numeral).Value;
                if(value == prev)
                    result += value;
                Console.WriteLine($"Current: {value}, Previous : {prev}");
                prev = value;

            }

            return result;
        }

        static bool NumeralValidation(string toValidate)
        {
            List<char> numerals = new List<char>()
            {
                'M', 'D', 'C', 'L', 'X', 'V', 'I'
            };
            foreach(char numeral in toValidate)
            {
                if(!numerals.Contains(numeral))
                    return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            string romanNumerals = "XXI";
            //Console.WriteLine("Insert Roman Numerals: ");
            //string romanNumerals = Console.ReadLine();
            if(!NumeralValidation(romanNumerals))
                Console.WriteLine("Input contains values not in the Roman Numeric System");
            int output = NumeralsToInteger(romanNumerals);

            //Console.WriteLine(output);
        }
    }
}
