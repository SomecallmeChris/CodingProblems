using System;

namespace SumSubset224
{
    class Program
    {
        static void Main(string[] args)
        {
            SubSetCalculator calc = new SubSetCalculator();
            int[] inputArray = { 1, 2, 4, 5, 9, 12, 17 };

            int res = calc.SmallestSumNotIn(inputArray);

            Console.WriteLine(res);
        }
    }
}
