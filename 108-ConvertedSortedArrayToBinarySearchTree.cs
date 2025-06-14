namespace LeetCode;

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

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}