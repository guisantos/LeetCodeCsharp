using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy;
public class MergedSortedArray
{
    // https://www.youtube.com/watch?v=EIVeJLgPMLw
    // nums1 =[1,2,3,0,0,0] 
    // m = 3
    // nums2 = [2,5,6] 
    // n = 3
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var p1 = m - 1;
        var p2 = n - 1;
        var i = m + n - 1;

        while (p2 >= 0)
        {
            if (p1 >= 0 && nums1[p1] > nums1[p2])
            {
                nums1[i--] = nums1[p1--];
            }
            else
            {
                nums1[i--] = nums2[p2--];
            }
        }
    }
}
