using System;

namespace LongestSubArray189
{
    class Program
    {
        static void Main(string[] args)
        {
            //[5, 1, 3, 5, 2, 3, 4, 1]
            int[] inputArray = { 5, 1, 3, 5, 2, 3, 4, 1 };
            DistinctSubset calc = new DistinctSubset();

            var output = calc.DistinctSubsetLength(inputArray);
            Console.WriteLine(output);


        }
    }
}
