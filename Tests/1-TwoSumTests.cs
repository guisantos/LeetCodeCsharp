namespace LeetCode.Test;

public class TwoSumTests
{
    [Fact]
    public void Test_TwoSumHashMap()
    {
        int[] nums = [2, 7, 11, 15];
        var target = 9;

        var twoSum = new LeetCode.TwoSum();

        var r = twoSum.TwoSumHashMap(nums, target);

        Assert.Equal(2, r.Length);
        Assert.Equal(0, r[0]);
        Assert.Equal(1, r[1]);
    }
}