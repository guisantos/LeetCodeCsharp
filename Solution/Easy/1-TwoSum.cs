namespace LeetCode.Solution.Easy;
public class TwoSum
{
    // O(^2)
    // 
    public int[] TwoSumArray(int[] nums, int target)
    {
        var result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return result;
    }

    // O(n)
    public int[] TwoSumHashMap(int[] nums, int target)
    {
        var hashMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hashMap.TryGetValue(nums[i], out var value))
            {
                return [i, value];
            }

            var diff = target - nums[i];
            hashMap.TryAdd(diff, i);
        }

        return new int[2];
    }
}
