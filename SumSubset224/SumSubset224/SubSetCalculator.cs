using System;
using System.Collections.Generic;

namespace SumSubset224
{
    public class SubSetCalculator
    {
        public int SmallestSumNotIn(int[] inputArray)
        {
            int inputLength = inputArray.Length;
            int result = 1;

            for(int i = 0; i < inputLength; i++)
            {
                var found = inputArray[i] <= result;
                if (!found)
                {
                    return result;
                }

                result += inputArray[i];
            }

            return result;
        }
    }
}
