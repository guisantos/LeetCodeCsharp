using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Medium;
public class MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        // Initialize maxSub to the first element to handle all-negative arrays
        var maxSub = nums[0];

        // curSum keeps track of the current running subarray sum
        var curSum = 0;

        // Iterate over each element in the array
        foreach (var item in nums)
        {
            // If the current sum is negative, reset it (starting a new subarray)
            if (curSum < 0)
            {
                curSum = 0;
            }

            // Add the current element to the running sum
            curSum += item;

            // Update maxSub if the current subarray sum is greater
            maxSub = Math.Max(maxSub, curSum);
        }

        // Return the maximum subarray sum found
        return maxSub;
    }
}
