using System;
using System.Collections.Generic;

namespace LongestSubArray189
{
    public class DistinctSubset
    {
        public int DistinctSubsetLength(int[] inputSet)
        {
            List<int> resultSet = new List<int>();

            foreach(int value in inputSet)
            {
                if (!resultSet.Contains(value))
                    resultSet.Add(value);
            }

            return resultSet.Count;
        }
    }
}
