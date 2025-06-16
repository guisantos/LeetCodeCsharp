namespace LeetCode.Solution.Easy;
public class ContainsDuplicated
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashMap = new Dictionary<int,int>();

        foreach (int i in nums)
        {
            if (hashMap.TryGetValue(i, out var hash))
            {
                return true;
            }

            hashMap.Add(i, 0);
        }

        return false;
    }
}
