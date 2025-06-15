using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy;
public class SearchInsertPosition
{
    // https://www.youtube.com/watch?v=v4J_AWp-6EQ
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;

            // if mid is smaller than target
            // means that the number is to the right of the center
            // move left to mid + 1
            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            // if mid is greater than target
            // means that the number is on the left of the center
            // move right to mid - 1 
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return left;
    }
}
