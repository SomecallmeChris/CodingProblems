using System;

namespace RomanNumerals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numeralConverter = new RomanNumeralsCalculator();
            string romanNumerals = "";
            while (romanNumerals != "quit")
            {
                Console.WriteLine("Insert Roman Numerals: ");
                romanNumerals = Console.ReadLine();
                if (!numeralConverter.NumeralValidation(romanNumerals))
                    Console.WriteLine("Input contains values not in the Roman Numeric System");
                int output = numeralConverter.NumeralsToInteger(romanNumerals);

                Console.WriteLine($"Converted: {output}");
            }
        }
    }
}
