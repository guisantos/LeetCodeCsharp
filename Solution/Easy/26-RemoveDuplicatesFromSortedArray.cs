namespace LeetCode.Solution.Easy;
public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        var replace = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[replace] = nums[i];
                replace += 1;
            }
        }

        return replace;
    }
}
