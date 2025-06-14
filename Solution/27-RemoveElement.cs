using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class RemoveElement
{
    // https://www.youtube.com/watch?v=pGKDzt0gk-A
    // window search index is the number to replace
    // num is the number ahead of index and is being checked if it's different than val
    // if num is different replace the index value with the num value and increment the index
    public int RemoveElementSolution(int[] nums, int val)
    {
        var index = 0;
        foreach (var num in nums)
        {
            if (num != val)
            {
                nums[index] = num;
                index++;
            }
        }

        return index;
    }
}
