namespace LeetCode.Solution.Medium;
public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var output = new int[nums.Length];
        var prefix = 1;
        var postFix = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            output[i] = prefix;
            prefix *= nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            output[i] *= postFix;
            postFix *= nums[i];
        }

        return output;
    }
}
