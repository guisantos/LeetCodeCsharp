using LeetCode.Solution.Helpers;

namespace LeetCode.Solution.Easy;

public class ConvertedSortedArrayToBinarySearchTree
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        return Helper(left, right, nums);
    }

    public TreeNode Helper(int left, int right, int[] nums)
    {
        if (left > right)
        {
            return null;
        }

        var mid = (left + right) / 2;
        var node = new TreeNode(nums[mid]);
        node.left = Helper(left, mid - 1, nums);
        node.right = Helper(mid + 1, right, nums);

        return node;
    }

    
}