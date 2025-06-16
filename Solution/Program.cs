using System.Globalization;
using LeetCode.Solution.Easy;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        // two sum

        int[] nums = [2, 1, 5, 3];
        int target = 4;

        var result = TwoSums(nums, target);
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
    }

    public static int[] TwoSums(int[] nums, int target)
    {
        var hashMap = new Dictionary<int, int>();
        int index = 0;
        foreach (var num in nums)
        {
            if (hashMap.ContainsKey(num))
            {
                var oldNum = hashMap[num];
                return [oldNum, index];
            }
            var diff = num - target;
            hashMap.TryAdd(diff, index);

            index++;
        }

        return [0,0];
    }
}
